using System.Collections.Generic;

namespace ET
{
    [FriendClass(typeof(Bullet))]
    [FriendClass(typeof(Monster))]
    [FriendClass(typeof(Base))]
    [FriendClass(typeof(GameComponent))]
    [FriendClass(typeof(Tower))]
    public static class DamageHelper
    {
        public static async ETTask BulletSingleAttackMonster(Scene currentscene,Bullet bullet,Monster monster,int PhysicsDamage,int MagicDamage,int IsAP,int Multiplier, int ExtraCoin)
        {
            if (bullet.Type < monster.Type || bullet.BulletZone != monster.Zone) return;
            int hp = monster.Hp;
            if (hp == 0) return;
            int AllAttack = DamageHelper.ReturnValue(PhysicsDamage,MagicDamage, monster,IsAP,Multiplier);
            hp = hp - AllAttack;
            BuffHelper.MonsterAddBuff( monster , bullet.BuffParam).Coroutine();
            if (hp <= 0)
            {
                hp = 0;
                //抛出死亡事件    延时死亡
            }
            monster.Hp = hp; ;//监听生命数值 刷新怪物UI
            Game.EventSystem.PublishAsync(new EventType.ShowDamageValueMonster() { currentscene = currentscene, damagevalue = AllAttack, monster = monster}).Coroutine();
            Game.EventSystem.PublishAsync(new EventType.MonsterDeath() { Monster = monster, currentscene = currentscene, IsAdd = true ,ExtraCoin = ExtraCoin}).Coroutine();
            await ETTask.CompletedTask;
        }
        public static async ETTask TowerSingleAttackMonster(Scene currentscene, Tower tower, Monster monster,int PhysicsDamage, int MagicDamage, int IsAP, int Multiplier, int ExtraCoin)
        {
            if (tower.Type < monster.Type || tower.Zone != monster.Zone) return;
            int hp = monster.Hp; ;
            if (hp == 0) return;
            int AllAttack = DamageHelper.ReturnValue(PhysicsDamage, MagicDamage, monster, IsAP, Multiplier);
            hp = hp - AllAttack;
            //BuffHelper.MonsterAddBuff(monster , BuffId).Coroutine();
            if (hp <= 0)
            {
                hp = 0;
                //抛出死亡事件    延时死亡
            }
            monster.Hp = hp; ;//监听生命数值 刷新怪物UI
            Game.EventSystem.PublishAsync(new EventType.ShowDamageValueMonster() { currentscene = currentscene, damagevalue = AllAttack, monster = monster }).Coroutine();
            Game.EventSystem.PublishAsync(new EventType.MonsterDeath() { Monster = monster, currentscene = currentscene, IsAdd = true,ExtraCoin = ExtraCoin }).Coroutine();
            await ETTask.CompletedTask;
        }
        public static async ETTask MonsterSingleAttackBase(Scene currentscene,Monster monster,Base baseitem)
        {
            int basehp = baseitem.Hp;
            int monsterattack = monster.Attack;
            basehp = basehp - monsterattack;
            monster.Hp = 0;
            if (basehp <= 0) basehp = 0;
            baseitem.Hp = basehp;
            await Game.EventSystem.PublishAsync(new EventType.ShowDamageValueBase() { currentscene = currentscene, damagevalue = monsterattack, baseitem = baseitem });
            await Game.EventSystem.PublishAsync(new EventType.MonsterDeath() { Monster = monster, currentscene = currentscene,IsAdd = false });
            if (basehp == 0)//基地爆炸游戏结束
            {
                GameComponent gameComponent = currentscene.GetComponent<GameComponent>();
                if (gameComponent == null || gameComponent.GameEnding == false) return;
                gameComponent.GameEnding = false;
                int basezone = baseitem.Zone;
                if(currentscene.GetComponent<GameComponent>().MatchMode == 1)
                {
                    if (basezone == 1) await currentscene.GetComponent<GameComponent>().WinGame(2, 0);
                }
                if (currentscene.GetComponent<GameComponent>().MatchMode == 2)
                {
                    if (basezone == 1) await currentscene.GetComponent<GameComponent>().WinGame(2, currentscene.GetComponent<GameComponent>().Base2.Hp);
                    if (basezone == 2) await currentscene.GetComponent<GameComponent>().WinGame(1, currentscene.GetComponent<GameComponent>().Base1.Hp);
                }

            }
            await ETTask.CompletedTask;
        }
        public static async ETTask BulletRangeAttackMonster(Scene currentscene, Bullet bullet, List<Monster> monsters,int PhysicsDamage,int MagicDamage, int IsAP, int Multiplier,int ExtraCoin)
        {
            foreach (Monster monster in monsters)
            {
                if (bullet.Type < monster.Type || bullet.BulletZone != monster.Zone) return;
                if (ExtraCoin != 0)
                {
                    Unit unit = UnitHelper.GetMyUnitFromCurrentScene(currentscene);
                    NumericComponent unitnumeric = unit.GetComponent<NumericComponent>();
                    unitnumeric.Set(NumericType.GameMoney, unitnumeric.GetAsInt(NumericType.GameMoney) + ExtraCoin);
                }
                int hp = monster.Hp;
                if (hp == 0) continue;
                int AllAttack = ReturnValue(PhysicsDamage, MagicDamage, monster, IsAP, Multiplier);
                hp = hp - AllAttack;
                BuffHelper.MonsterAddBuff(monster, bullet.BuffParam).Coroutine();
                if (hp <= 0)
                {
                    hp = 0;
                    //抛出死亡事件    延时死亡
                }
                monster.Hp = hp; ;//监听生命数值 刷新怪物UI
                Game.EventSystem.PublishAsync(new EventType.ShowDamageValueMonster() { currentscene = currentscene, damagevalue = AllAttack, monster = monster }).Coroutine();
                Game.EventSystem.PublishAsync(new EventType.MonsterDeath() { Monster = monster, currentscene = currentscene, IsAdd = true , ExtraCoin = 0 }).Coroutine();
            }
            await ETTask.CompletedTask;
        }
        public static async ETTask BuffAttackMonster(Scene currentscene,int PhysicsDamage,int MagicDamage,Monster monster,int ExtraCoin)
        {
            int hp = monster.Hp;
            if (hp == 0) return;
            int MonsterPhysicsDefence = monster.PhysicsDefense;//怪物物理防御
            int MonsterMagicDefence = monster.MagicDefense;//怪物法术防御
            int AllPhysicsAttack = PhysicsDamage - MonsterPhysicsDefence;
            if (AllPhysicsAttack <= 0) AllPhysicsAttack = 0;
            int AllMagicAttack = MagicDamage - MonsterMagicDefence;
            if (AllMagicAttack <= 0) AllMagicAttack = 0;
            int AllAttack = AllPhysicsAttack + AllMagicAttack;
            hp = hp - AllAttack;
            if (hp <= 0)
            {
                hp = 0;
                //抛出死亡事件    延时死亡
            }
            monster.Hp = hp;//监听生命数值 刷新怪物UI
            Game.EventSystem.PublishAsync(new EventType.ShowDamageValueMonster() { currentscene = currentscene, damagevalue = AllAttack, monster = monster }).Coroutine();
            Game.EventSystem.PublishAsync(new EventType.MonsterDeath() { Monster = monster, currentscene = currentscene, IsAdd = true, ExtraCoin = ExtraCoin }).Coroutine();

            await ETTask.CompletedTask;
        }
        public static int ReturnValue(int PhysicsDamage,int MagicDamage,Monster monster,int IsAP,int Multiplier)
        {
            int MonsterPhysicsDefence = monster.PhysicsDefense;//怪物物理防御
            int MonsterMagicDefence = monster.MagicDefense;//怪物法术防御
            int AllPhysicsAttack = PhysicsDamage - MonsterPhysicsDefence * (100 - IsAP) / 100;
            if (AllPhysicsAttack <= 0) AllPhysicsAttack = 0;
            int AllMagicAttack = MagicDamage - MonsterMagicDefence;
            if (AllMagicAttack <= 0) AllMagicAttack = 0;
            float AllAttack = (float)AllPhysicsAttack + (float)AllMagicAttack;
            if(monster.GetComponent<ResonanceBuffComponent>() != null)
            {
                Multiplier = Multiplier + monster.GetComponent<ResonanceBuffComponent>().GetExtraDamage();
            }
            return (int)(AllAttack * (float)Multiplier / 100.0f);

        }
    }
}
