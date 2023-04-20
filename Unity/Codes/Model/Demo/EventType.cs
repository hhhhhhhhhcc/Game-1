using UnityEngine;
using System.Collections.Generic;

namespace ET
{
    namespace EventType
    {
        public struct AppStart
        {
        }

        public struct SceneChangeStart
        {
            public Scene ZoneScene;
        }
        
        
        public struct SceneChangeFinish
        {
            public Scene ZoneScene;
            public Scene CurrentScene;
        }

        public class ChangePosition: DisposeObject
        {
            public static readonly ChangePosition Instance = new ChangePosition();

            public Unit Unit;
            public Monster Monster;
            public Tower Tower;
            public Bullet Bullet;
            public Base Base;
            public Troop troop;
            public WrapVector3 OldPos = new WrapVector3();

            // 因为是重复利用的，所以用完PublishClass会调用Dispose
            public override void Dispose()
            {
                this.Unit = null;
                this.Monster = null;
                this.Tower = null;
                this.Bullet = null;
                this.Base = null;
                this.troop = null;
            }
        }
    

        public class ChangeRotation: DisposeObject
        {
            public static readonly ChangeRotation Instance = new ChangeRotation();
                   
            public Unit Unit;
            public Monster Monster;
            public Tower Tower;
            public Bullet Bullet;
            public Base Base;
            public Troop troop;
            // 因为是重复利用的，所以用完PublishClass会调用Dispose
            public override void Dispose()
            {
                this.Unit = null;
                this.Monster = null;
                this.Tower = null;
                this.Bullet = null;
                this.Base = null;
                this.troop = null;
            }
        }

        public struct PingChange
        {
            public Scene ZoneScene;
            public long Ping;
        }
        
        public struct AfterCreateZoneScene
        {
            public Scene ZoneScene;
        }
        
        public struct AfterCreateCurrentScene
        {
            public Scene CurrentScene;
        }
        
        public struct AfterCreateLoginScene
        {
            public Scene LoginScene;
        }

        public struct AppStartInitFinish
        {
            public Scene ZoneScene;
        }

        public struct LoginFinish
        {
            public Scene ZoneScene;
        }

        public struct LoadingBegin
        {
            public Scene Scene;
        }

        public struct LoadingFinish
        {
            public Scene Scene;
        }

        public struct EnterMapFinish
        {
            public Scene ZoneScene;
        }

        public struct AfterUnitCreate
        {
            public Unit Unit;
        }
        
        public struct MoveStart
        {
            public Unit Unit;
        }

        public struct MoveStop
        {
            public Unit Unit;
        }
        public struct ShowGameUI
        {
            public Scene ZoneScene;
            public int MatchMode;
        }
        public struct HideGameUI
        {
            public Scene ZoneScene;
            public Scene CurrentScene;
        }

        public struct AfterUnitCreateTower
        {
            public Scene zonescene;
            public Tower Tower;
            public float TowerPx;
            public float TowerPy;
            public List<int> TalentIds;
        }
        public struct AfterUnitCreateMonster
        {
            public Scene CurrentScene;
            public Monster Monster;
            public bool PlayerBuy;
        }
        public struct AfterUnitCreateBullet
        {
            public Bullet Bullet;
            public Tower Tower;
            public Monster Monster;
        }
        public struct MonsterDeath
        {
            public Scene currentscene;
            public Monster Monster;
            public bool IsAdd;
            public int ExtraCoin;
        }
        public struct BulletDestroy
        {
            public Scene currentscene;
            public Bullet Bullet;
            public bool IsDelay;
            public string DelayAnimatorName;
        }
        public struct DisReadyAndShowWindow
        {
            public Scene scene;
        }
        public struct ShowGameResult
        {
            public Scene zonescene;
            public bool Result;
            public List<int> ItemId;
            public List<int> ItemNumber;
            public int Star;
        }
        public struct ShowDamageValueMonster
        {
            public Scene currentscene;
            public int damagevalue;
            public Monster monster;
        }
        public struct AfterUnitCreateBase
        {
            public Scene currentscene;
            public Base baseitem;
        }
        public struct ShowDamageValueBase
        {
            public Scene currentscene;
            public int damagevalue;
            public Base baseitem;
        }
        public struct TowerLaser
        {
            public Scene currentscene;
            public Tower tower;
            public List<Monster> monster;
            public int index;
        }
        public struct TowerChargeBar
        {
            public Tower tower;
            public float SizeX;
        }
        public struct LogicMonsterPos
        {
            public List<Monster> monsters;
            public int FrameDt;
        }
        public struct SettingTower
        {
            public Scene zonescene;
            public Tower tower;
            public long TowerId;
            public int opttype;
            public int optId;
            public bool invalid;
        }
        public struct LogicBulletPos
        {
            public Scene currentscene;
            public List<Bullet> bullets;
            public int FrameDt;
        }
        public struct ChangeUnitAnimatorState
        {
            public Scene currentscene;
            public Entity entity;
            public string AnimatorName;
        }
        public struct ShowMapUI
        {
            public Scene currentscene;
            public string MapName;
        }
        public struct HideMapUI
        {
            public Scene currentscene;
        }
        
        public struct GameUpdateWaveInfo
        {
            public Scene zonescene;
            public int CurrentWaveNumber;
            public List<int> CurrentWaveAllMonsterConfigId;
            public List<int> CurrentWaveAllMonsterRoadId;
        }
        public struct GameUpdateTimeLeftInfo
        {
            public Scene zonescene;
            public int Time;
        }
        public struct BulletBeforeDestroyAnimator
        {
            public Entity entity;
            public string AnimatorName;
        }
        public struct RefreshTalentUI
        {
            public Scene zonescene;
        }
        public struct MonsterMove
        {
            public Monster monster;
            public bool flip;
        }
        public struct TimeChangeBulletPos
        {
            public Bullet bullet;
            public Vector3 v;
            public float speed;
        }
        public struct TimeChangeMonsterPos
        {
            public Monster monster;
            public Vector3 v;
            public float speed;
        }
        public struct AfterUnitCreateTroop
        {
            public Troop Troop;
            public float TroopX;
            public float TroopY;
        }

    }
}