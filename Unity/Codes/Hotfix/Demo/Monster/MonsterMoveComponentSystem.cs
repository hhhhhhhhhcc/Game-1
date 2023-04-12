using UnityEngine;
namespace ET
{
    [FriendClass(typeof(GameComponent))]
    public class MonsterMoveComponentAwakeSystem : AwakeSystem<MonsterMoveComponent,int>
    {
        public override void Awake(MonsterMoveComponent self,int navid)
        {
            self.NavPos = self.ZoneScene().CurrentScene().GetComponent<GameComponent>().MonsterNavs[navid];
            self.AllDistance = 0;
            self.AllReadyRun = 0;
            for(int i = 0;i<self.NavPos.Length - 1;i++)
            {
                self.AllDistance = self.AllDistance + Vector3.Distance(self.NavPos[i], self.NavPos[i + 1]);
            }
            self.LogicPos = new Vector3();
        }
    }
    public class MonsterMoveComponentUpdateSystem : UpdateSystem<MonsterMoveComponent>
    {
        public override void Update(MonsterMoveComponent self)
        {
            self.Move();
        }
    }
    public class MonsterMoveComponentDestroySystem : DestroySystem<MonsterMoveComponent>
    {
        public override void Destroy(MonsterMoveComponent self)
        {
           
        }
    }
    [FriendClass(typeof(Monster))]
    [FriendClass(typeof(MonsterMoveComponent))]
    public static class MonsterMoveComponentSystem
    {
        public static void OnLogic(this MonsterMoveComponent self,int dt)
        {
            self.OnLogicMoveUpdate(dt);
        }
        public static void OnLogicMoveUpdate(this MonsterMoveComponent self, int dt_ms)
        {
            self.JudgeDir();
            if (self == null) return;
            if (self.GetParent<Monster>() == null) return;
            if (self.GetParent<Monster>().State != MonsterState.Run) return;
            self.GetParent<Monster>().Position = self.LogicPos;
            Vector3 src = self.GetParent<Monster>().Position;
            Vector3 dst = self.NavPos[self.CurrentPos];
            Vector3 dir = dst - src;
            float len = dir.magnitude;
            if (len <= 0)//已经到目标点了
            {
                self.CurrentPos++;
                self.OnLogicMoveUpdate(dt_ms);
                return;
            }

            bool isArrived = false;
            float time = len / self.GetParent<Monster>().Speed;//到当前目的地需要用的时间 30
            float dt = dt_ms / (float)1000;//一帧的时间 66
            int det = (int)((dt - time) * 1000);//36

            if (time < dt)//time < dt  说明走过了   time >= dt 说明还没到
            {
                dt = time;
                isArrived = true;
            }

            self.GetParent<Monster>().Position = self.GetParent<Monster>().Position + dir.normalized * dt * self.GetParent<Monster>().Speed;
            self.AllReadyRun = self.AllReadyRun + dt * (float)(self.GetParent<Monster>().Speed);
            self.LogicPos = self.GetParent<Monster>().Position;

            if (isArrived)
            {
                self.CurrentPos++;
                if (self.CurrentPos >= self.NavPos.Length)//超出了总路程范围 就造成伤害
                {
                    int monsterzone = self.GetParent<Monster>().Zone;
                    Base baseitem = self.ZoneScene().CurrentScene().GetComponent<GameComponent>().GetBaseByZone(monsterzone);
                    DamageHelper.MonsterSingleAttackBase(self.ZoneScene().CurrentScene(), self.GetParent<Monster>(), baseitem).Coroutine();
                }
                else//否则把剩下的路程迭代完
                {
                    self.OnLogicMoveUpdate(det);
                }
            }
        }
        public static void JudgeDir(this MonsterMoveComponent self)
        {
            if (self == null) return;
            if (self.GetParent<Monster>() == null) return;
            if(self.GetParent<Monster>().State == MonsterState.Control)//被控制了
            {
                Vector3 dir = self.GetDir();
                if ((dir.x <= 0 && dir.y < 0) || (dir.x <= 0 && dir.y > 0 && (dir.y / dir.x) >= -0.15f)) //左下角
                {
                    Game.EventSystem.PublishAsync(new EventType.ChangeUnitAnimatorState() { currentscene = self.ZoneScene().CurrentScene(), entity = self.GetParent<Monster>(), AnimatorName = "LDSJ" }).Coroutine();
                }
                else if ((dir.x > 0 && dir.y <= 0) || (dir.x > 0 && dir.y > 0 && (dir.y / dir.x) <= 0.15f)) //右下角
                {
                    Game.EventSystem.PublishAsync(new EventType.ChangeUnitAnimatorState() { currentscene = self.ZoneScene().CurrentScene(), entity = self.GetParent<Monster>(), AnimatorName = "RDSJ" }).Coroutine();
                }
                else if ((dir.x < 0 && dir.y >= 0) && (dir.y / dir.x) <= -0.15f)//左上角
                {
                    Game.EventSystem.PublishAsync(new EventType.ChangeUnitAnimatorState() { currentscene = self.ZoneScene().CurrentScene(), entity = self.GetParent<Monster>(), AnimatorName = "LUSJ" }).Coroutine();
                }
                else if ((dir.x >= 0 && dir.y > 0) && (dir.y / dir.x) >= 0.15f)//右上角
                {
                    Game.EventSystem.PublishAsync(new EventType.ChangeUnitAnimatorState() { currentscene = self.ZoneScene().CurrentScene(), entity = self.GetParent<Monster>(), AnimatorName = "RUSJ" }).Coroutine();
                }
            }
            else if(self.GetParent<Monster>().State == MonsterState.NormalAttack)
            {

            }
            else if(self.GetParent<Monster>().State == MonsterState.Run)//走路
            {
                Vector3 dir = self.GetDir();
                if ((dir.x <= 0 && dir.y < 0) || (dir.x <= 0 && dir.y > 0 && (dir.y / dir.x) >= -0.15f)) //左下角
                {
                    Game.EventSystem.PublishAsync(new EventType.ChangeUnitAnimatorState() { currentscene = self.ZoneScene().CurrentScene(), entity = self.GetParent<Monster>(), AnimatorName = "LD" }).Coroutine();
                }
                else if ((dir.x > 0 && dir.y <= 0) || (dir.x > 0 && dir.y > 0 && (dir.y / dir.x) <= 0.15f)) //右下角
                {
                    Game.EventSystem.PublishAsync(new EventType.ChangeUnitAnimatorState() { currentscene = self.ZoneScene().CurrentScene(), entity = self.GetParent<Monster>(), AnimatorName = "RD" }).Coroutine();
                }
                else if ((dir.x < 0 && dir.y >= 0) && (dir.y / dir.x) <= -0.15f)//左上角
                {
                    Game.EventSystem.PublishAsync(new EventType.ChangeUnitAnimatorState() { currentscene = self.ZoneScene().CurrentScene(), entity = self.GetParent<Monster>(), AnimatorName = "LU" }).Coroutine();
                }
                else if ((dir.x >= 0 && dir.y > 0) && (dir.y / dir.x) >= 0.15f)//右上角
                {
                    Game.EventSystem.PublishAsync(new EventType.ChangeUnitAnimatorState() { currentscene = self.ZoneScene().CurrentScene(), entity = self.GetParent<Monster>(), AnimatorName = "RU" }).Coroutine();
                }
            }
        }
        public static Vector3 GetDir(this MonsterMoveComponent self)
        {
            if(self.CurrentPos < self.NavPos.Length)
            {
                return self.NavPos[self.CurrentPos] - self.GetParent<Monster>().Position;
            }
            else
            {
                return new Vector3(0, 0, 0);
            }
        }
        public static void Move(this MonsterMoveComponent self)
        {
            if (self == null) return;
            if (self?.ZoneScene()?.CurrentScene()?.GetComponent<GameComponent>()?.SingleGameModeState == false) return;
            if (self.GetParent<Monster>().State != MonsterState.Run || self.GetParent<Monster>().IsDead) return;
            if (Vector3.Distance(self.GetParent<Monster>().Position, self.NavPos[self.NavPos.Length - 1]) < 0.01f)
            {
                int monsterzone = self.GetParent<Monster>().Zone;
                Base baseitem = self.ZoneScene().CurrentScene().GetComponent<GameComponent>().GetBaseByZone(monsterzone);
                DamageHelper.MonsterSingleAttackBase(self.ZoneScene().CurrentScene(), self.GetParent<Monster>(), baseitem).Coroutine();
            }
            if (self.CurrentPos < self.NavPos.Length)
            {
                Vector3 v = self.NavPos[self.CurrentPos] - self.GetParent<Monster>().Position;
                if (Vector3.Distance(self.NavPos[self.CurrentPos], self.GetParent<Monster>().Position) > 0.01f)
                {
                    Game.EventSystem.PublishAsync(new EventType.TimeChangeMonsterPos() { monster = self.GetParent<Monster>(), v = v, speed = self.GetParent<Monster>().Speed }).Coroutine();
                }
                else
                {
                    self.CurrentPos++;
                }
            }
            else
            {
                return;
            }
        }
    }
}
