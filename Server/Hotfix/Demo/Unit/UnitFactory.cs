﻿using System;
using UnityEngine;

namespace ET
{
    [FriendClass(typeof(Unit))]
    [FriendClass(typeof(LevelComponent))]
    public static class UnitFactory
    {
        public static Unit Create(Scene scene, Player player, UnitType unitType)
        {
            UnitComponent unitComponent = scene.GetComponent<UnitComponent>();
            switch (unitType)
            {
                case UnitType.Player:
                {
                        Unit unit = unitComponent.AddChildWithId<Unit, int>(player.Id, 1001);
                        unit.ServerId = player.ServerId;
                        //ChildType测试代码 取消注释 编译Server.hotfix 可发现报错
                        /*unitComponent.AddChild<Player, string>("Player");
                        unit.AddComponent<MoveComponent>();
                        unit.Position = new Vector3(-10, 0, -10);*/
                        
                        NumericComponent numericComponent = unit.AddComponent<NumericComponent>();
                        unit.AddComponent<BagComponent>();
                        unit.AddComponent<LevelComponent>();
                        FightItemComponent fightitemcomponent = unit.AddComponent<FightItemComponent>();
                        fightitemcomponent.AddFightItemByConfigId(3001);
                        fightitemcomponent.AddFightItemByConfigId(3004);
                        fightitemcomponent.AddFightItemByConfigId(3007);
                        fightitemcomponent.AddFightItemByConfigId(3010);
                        fightitemcomponent.AddFightItemByConfigId(3013);
                        fightitemcomponent.AddFightItemByConfigId(6001);
                        fightitemcomponent.AddFightItemByConfigId(6002);
                        fightitemcomponent.AddFightItemByConfigId(6003);
                        fightitemcomponent.AddFightItemByConfigId(6004);
                        fightitemcomponent.AddFightItemByConfigId(9001);
                        fightitemcomponent.AddFightItemByConfigId(9002);
                        fightitemcomponent.AddFightItemByConfigId(9003);
                        fightitemcomponent.AddFightItemByConfigId(9004);
                        foreach (var config in PlayerNumericConfigCategory.Instance.GetAll())
                        {
                            if(config.Value.BaseValue == 0)
                            {
                                continue;
                            }
                            if(config.Key < 3000)
                            {
                                int basekey = config.Key * 10 + 1;
                                numericComponent.SetNoEvent(basekey, config.Value.BaseValue);
                            }
                            else
                            {
                                numericComponent.SetNoEvent(config.Key, config.Value.BaseValue);
                            }
                        }
                        numericComponent.Set(NumericType.Gold, 10000);
                        numericComponent.SetNoEvent(NumericType.IsInMatch, 0);
                        numericComponent.SetNoEvent(NumericType.RoomIndex, 0);
                        numericComponent.SetNoEvent(NumericType.IsReadyGame, 0);
                        numericComponent.SetNoEvent(NumericType.Position, 0);
                        numericComponent.SetNoEvent(NumericType.LevelId, 0);
                        numericComponent.SetNoEvent(NumericType.GameMoney, 0);
                        unitComponent.Add(unit);
                        // 加入aoi
                        //unit.AddComponent<AOIEntity, int, Vector3>(9 * 1000, unit.Position);
                        return unit;
                        
                }
                default:
                    throw new Exception($"not such unit type: {unitType}");
            }
        }
    }
}