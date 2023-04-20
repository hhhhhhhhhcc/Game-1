using System;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

namespace ET
{
	[FriendClass(typeof(GameComponent))]
	[FriendClass(typeof(Bullet))]
	[FriendClass(typeof(SingleDamageBullet))]
    [FriendClass(typeof(RangeDamageBullet))]
    [FriendClass(typeof(MulRangeDamageBullet))]
	[FriendClass(typeof(Tower))]
	[FriendClass(typeof(Monster))]
	[FriendClass(typeof(Base))]
	[FriendClass(typeof(Troop))]
    public static class UnitFactory
    {
        public static Unit Create(Scene currentScene, UnitInfo unitInfo)
        {
	        UnitComponent unitComponent = currentScene.GetComponent<UnitComponent>();
	        Unit unit = unitComponent.AddChildWithId<Unit, int>(unitInfo.UnitId, unitInfo.ConfigId);
	        unitComponent.Add(unit);
	        
	        unit.Position = new Vector3(unitInfo.X, unitInfo.Y, unitInfo.Z);
	        unit.Forward = new Vector3(unitInfo.ForwardX, unitInfo.ForwardY, unitInfo.ForwardZ);
	        
	        NumericComponent numericComponent = unit.AddComponent<NumericComponent>();
	        for (int i = 0; i < unitInfo.Ks.Count; ++i)
	        {
		        numericComponent.Set(unitInfo.Ks[i], unitInfo.Vs[i]);
	        }
	        /*unit.AddComponent<MoveComponent>();
	        if (unitInfo.MoveInfo != null)
	        {
		        if (unitInfo.MoveInfo.X.Count > 0)
		        {
			        using (ListComponent<Vector3> list = ListComponent<Vector3>.Create())
			        {
				        list.Add(unit.Position);
				        for (int i = 0; i < unitInfo.MoveInfo.X.Count; ++i)
				        {
					        list.Add(new Vector3(unitInfo.MoveInfo.X[i], unitInfo.MoveInfo.Y[i], unitInfo.MoveInfo.Z[i]));
				        }

				        unit.MoveToAsync(list).Coroutine();
			        }
		        }
	        }*/

	        unit.AddComponent<ObjectWait>();

	        //unit.AddComponent<XunLuoPathComponent>();
	        //Game.EventSystem.Publish(new EventType.AfterUnitCreate() {Unit = unit});
            return unit;
        }

		public static async ETTask<Monster> CreateMonster(Scene currentscene,int monsterconfigId,long monsterid,int MonsterNavId,int MonsterZone,bool PlayerBuy)
		{
			if (currentscene == null) return null;
            IdGenerater.Instance.AddLastId(monsterid);
            MonsterComponent monstercomponent = currentscene.GetComponent<MonsterComponent>();
			Monster monster = monstercomponent.AddChildWithId<Monster, int>(monsterid, monsterconfigId);
			monstercomponent.Add(monster);
			monster.MaxHp = monster.Config.Hp;
			FightItemConfig fightitemconfig = FightItemConfigCategory.Instance.Get(monster.Config.MonsterConfigId);
			monster.Type = fightitemconfig.Type;
			monster.Hp = monster.Config.Hp;
			monster.Speed = monster.Config.Speed / 1000.0f;
			monster.ReturnMoney = monster.Config.DropMoney;
			monster.Zone = MonsterZone;
			monster.Attack = monster.Config.MonsterAttack;
			monster.PhysicsDefense = monster.Config.Defense[0];
			monster.MagicDefense = monster.Config.Defense[1];
            monster.PlayerBuy = PlayerBuy;
            monster.AddComponent<MonsterMoveComponent, int>(MonsterNavId);
            await Game.EventSystem.PublishAsync(new EventType.AfterUnitCreateMonster() { Monster = monster ,CurrentScene = currentscene});
            currentscene.GetComponent<GameComponent>().AllEnemy.Add(monster);
            return monster;
        }
		public static async ETTask<Troop> CreateAssembleTroop(Scene currentscene,int Hp,int attackdamage,int attackinterval,int attackrange,int speed,long troopId,float TroopX,float TroopY,string prefabname,int zone)
		{
			if (currentscene == null) return null;
			TroopComponent troopcomponent = currentscene.GetComponent<TroopComponent>();
            Troop troop = troopcomponent.AddChildWithId<Troop>(troopId);
			troop.Hp = Hp;
			troop.MaxHp = Hp;
			troop.AttackIntervalTimer = attackinterval;
			troop.AttackDamage = attackdamage;
			troop.AttackRange = attackrange;
			troop.speed = speed / 1000.0f;
			troop.Zone = zone;
			troop.PrefabName = prefabname;
			troop.Position = new Vector2(TroopX,TroopY);
			await Game.EventSystem.PublishAsync(new EventType.AfterUnitCreateTroop() { Troop = troop });
			currentscene.GetComponent<GameComponent>().AllTroop.Add(troop);
            return troop;
        }
		public static async ETTask<Tower> CreateTower(Scene currentscene,int configId,float Px,float Py,int TowerZone,long TowerId,List<int> TalentIds) 
		{
            TowerComponent towercomponent = currentscene.GetComponent<TowerComponent>();
            Tower tower = towercomponent.AddChildWithId<Tower, int>(TowerId, configId);

			tower.AttackRange = (float)(tower.Config.Range / 1000.0f);
            tower.PhysicsAttack = tower.Config.Attack[0];
            tower.MagicAttack = tower.Config.Attack[1];
            tower.AttackInterval = tower.Config.AttackInterval;
            tower.Zone = TowerZone;
			tower.Type = tower.Config.Type;
			int NormalSkillId;
			SkillConfig skill;
			string skillname;
			Type skillcomponent;
			//技能
			for(int i=0;i< TalentIds.Count;i++)
			{
				int TalentId = TalentIds[i];
				TalentConfig talentconfig = TalentConfigCategory.Instance.Get(TalentId);
                skill = SkillConfigCategory.Instance.Get(talentconfig.SkillId);
				skillname = skill.Script;
				skillcomponent = Type.GetType("ET." + skillname);
                tower.AddComponent(skillcomponent);
            }
            //普攻
            NormalSkillId = tower.Config.NoramlSkill;
            skill = SkillConfigCategory.Instance.Get(NormalSkillId);
            skillname = skill.Script;
            skillcomponent = Type.GetType("ET." + skillname);
            tower.AddComponent(skillcomponent);
			//end
            await Game.EventSystem.PublishAsync(new EventType.AfterUnitCreateTower() { zonescene = currentscene.ZoneScene(),Tower = tower,TowerPx = Px,TowerPy = Py,TalentIds = TalentIds });
            currentscene.GetComponent<GameComponent>().AllTower.Add(tower);
            return tower;
        }
        public static void UpTower(Scene currentscene, long TowerId,List<int> TalentIds)
        {
            Tower tower = currentscene.GetComponent<TowerComponent>().GetChild<Tower>(TowerId);
            List<Type> types = new List<Type>();
            foreach(Type type in tower.Components.Keys)
            {
                if(typeof(LogicSkill).IsAssignableFrom(type))
                {
                    types.Add(type);
                }
            }
            for(int i=0;i<types.Count; i++)
            {
                Entity component = tower.Components[types[i]];
                component?.Dispose();
            }
            int newconfigId = tower.ConfigId + 1;
            TowerConfig towerconfig = TowerConfigCategory.Instance.Get(newconfigId);
            tower.UpFrame = 23;
            tower.ConfigId = newconfigId;
            tower.Config = towerconfig;
            tower.AttackRange = (float)(towerconfig.Range / 1000.0f);
            tower.PhysicsAttack = towerconfig.Attack[0];
            tower.MagicAttack = towerconfig.Attack[1];
            tower.AttackInterval = towerconfig.AttackInterval;
            int NormalSkillId;
            SkillConfig skill;
            string skillname;
            Type skillcomponent;
            //技能
            for (int i = 0; i < TalentIds.Count; i++)
            {
                int TalentId = TalentIds[i];
                TalentConfig talentconfig = TalentConfigCategory.Instance.Get(TalentId);
                skill = SkillConfigCategory.Instance.Get(talentconfig.SkillId);
                skillname = skill.Script;
                skillcomponent = Type.GetType("ET." + skillname);
                tower.AddComponent(skillcomponent);
            }
            //普攻
            NormalSkillId = tower.Config.NoramlSkill;
            skill = SkillConfigCategory.Instance.Get(NormalSkillId);
            skillname = skill.Script;
            skillcomponent = Type.GetType("ET." + skillname);
            tower.AddComponent(skillcomponent);
            //end
            //播放升级动画
            int levelId = (tower.ConfigId - 1) % 3 + 1;
            string animatorname = (levelId - 1).ToString() + "T" + levelId.ToString();
            Game.EventSystem.PublishAsync(new EventType.ChangeUnitAnimatorState() { currentscene = currentscene, entity = tower, AnimatorName = animatorname }).Coroutine();
        }
        public static async ETTask DeleteTower(Scene currentscene,long TowerId)
		{
            TowerComponent towercomponent = currentscene.GetComponent<TowerComponent>();
			Tower tower = towercomponent.Get(TowerId);
            currentscene.GetComponent<GameComponent>().RemoveTower(tower);
			towercomponent.Remove(TowerId);
            await ETTask.CompletedTask;
		}
		public static async ETTask<Bullet> CreateSingleBullet(Scene currentscene,Tower tower,Monster monster,string BulletPrefabName,int FlySpeed,int IsAP,int multiplier,int ExtraCoin,string BuffParam)//创建单体攻击子弹
		{
			BulletComponent bulletComponent = currentscene.GetComponent<BulletComponent>();
			Bullet bullet = bulletComponent.AddChildWithId<Bullet>(IdGenerater.Instance.GenerateId());
            bullet.BulletPrefabName = BulletPrefabName;
            bullet.BulletZone = tower.Zone;
            bullet.ExtraCoin = ExtraCoin;
			bullet.BuffParam = BuffParam;
			bullet.Type = tower.Type;
            SingleDamageBullet param = bullet.AddComponent<SingleDamageBullet>();
			param.Multiplier = multiplier;
			param.IsAP = IsAP;
			param.Speed = FlySpeed;
			param.PhysicsDamage = tower.PhysicsAttack;
			param.MagicDamage = tower.MagicAttack;
			param.Monster = monster; 
            await Game.EventSystem.PublishAsync(new EventType.AfterUnitCreateBullet() { Bullet = bullet, Tower = tower, Monster = monster});
			currentscene.GetComponent<GameComponent>().AllBullet.Add(bullet);
			return bullet;
		}
        public static async ETTask<Bullet> CreateRangeBullet(Scene currentscene, Tower tower, Monster monster, string BulletPrefabName, int FlySpeed, int damagerange,int IsAP, int multiplier, int ExtraCoin, string BuffParam)//创建群体攻击子弹
        {
            BulletComponent bulletComponent = currentscene.GetComponent<BulletComponent>();
            Bullet bullet = bulletComponent.AddChildWithId<Bullet>(IdGenerater.Instance.GenerateId());
            bullet.BulletPrefabName = BulletPrefabName;
            bullet.BulletZone = tower.Zone;
            bullet.ExtraCoin = ExtraCoin;
			bullet.BuffParam = BuffParam;
            bullet.Type = tower.Type;
            RangeDamageBullet param = bullet.AddComponent<RangeDamageBullet>();
            param.Multiplier = multiplier;
            param.IsAP = IsAP;
			param.ExtraCoin = ExtraCoin;
            param.Speed = FlySpeed;
			param.DamageRange = damagerange;
            param.PhysicsDamage = tower.PhysicsAttack;
            param.MagicDamage = tower.MagicAttack;
            param.DirPos = monster.Position;
            await Game.EventSystem.PublishAsync(new EventType.AfterUnitCreateBullet() { Bullet = bullet, Tower = tower, Monster = monster });
            currentscene.GetComponent<GameComponent>().AllBullet.Add(bullet);
            return bullet;
        }
        public static async ETTask<Bullet> CreateMulRangeBullet(Scene currentscene, Tower tower, Monster monster, string BulletPrefabName, int FlySpeed, int damagerange, int damageinterval,int alltime,int IsAP, int multiplier, int ExtraCoin,string BuffParam)//创建多次群体攻击子弹
        {
            BulletComponent bulletComponent = currentscene.GetComponent<BulletComponent>();
            Bullet bullet = bulletComponent.AddChildWithId<Bullet>(IdGenerater.Instance.GenerateId());
            bullet.BulletPrefabName = BulletPrefabName;
            bullet.BulletZone = tower.Zone;
            bullet.ExtraCoin = ExtraCoin;
			bullet.BuffParam = BuffParam;
            bullet.Type = tower.Type;
            MulRangeDamageBullet param = bullet.AddComponent<MulRangeDamageBullet>();
            param.Multiplier = multiplier;
            param.IsAP = IsAP;
			param.ExtraCoin = ExtraCoin;
            param.Speed = FlySpeed;
            param.DamageRange = damagerange;
			param.SingleDamageInterval = damageinterval;
			param.AllTime = alltime;
            param.PhysicsDamage = tower.PhysicsAttack;
            param.MagicDamage = tower.MagicAttack;
            param.DirPos = monster.Position;
            await Game.EventSystem.PublishAsync(new EventType.AfterUnitCreateBullet() { Bullet = bullet, Tower = tower, Monster = monster });
            currentscene.GetComponent<GameComponent>().AllBullet.Add(bullet);
            return bullet;
        }
        public static async ETTask<Base> CreateBase(Scene currentscene,int zone,int Pos)
		{
			BaseComponent basecomponent = currentscene.GetComponent<BaseComponent>();
			Base baseitem = basecomponent.AddChildWithId<Base>(IdGenerater.Instance.GenerateId());
			baseitem.PosId = Pos;
			baseitem.Zone = zone;
			baseitem.MaxHp = 100;
			baseitem.Hp = 100;
			await Game.EventSystem.PublishAsync(new EventType.AfterUnitCreateBase() { currentscene = currentscene, baseitem = baseitem });
            currentscene.GetComponent<GameComponent>().AllBase.Add(baseitem);
            return baseitem;
		}
    }
}
