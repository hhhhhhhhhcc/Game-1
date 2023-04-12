using System;
using System.Collections.Generic;

namespace ET
{
    [FriendClass(typeof(GameComponent))]
    public static class SceneChangeHelper
    {
        // 场景切换协程
        public static async ETTask SceneChangeTo(Scene zoneScene, string sceneName, long sceneInstanceId)
        {
            //zoneScene.RemoveComponent<AIComponent>();
            CurrentScenesComponent currentScenesComponent = zoneScene.GetComponent<CurrentScenesComponent>();
            currentScenesComponent.Scene?.Dispose(); // 删除之前的CurrentScene，创建新的
            Scene currentScene = SceneFactory.CreateCurrentScene(sceneInstanceId, zoneScene.Zone, sceneName, currentScenesComponent);
            UnitComponent unitComponent = currentScene.AddComponent<UnitComponent>();

            
            // 可以订阅这个事件中创建Loading界面
            Game.EventSystem.Publish(new EventType.SceneChangeStart() { ZoneScene = zoneScene });

            // 等待CreateMyUnit的消息
            WaitType.Wait_CreateMyUnit waitCreateMyUnit = await zoneScene.GetComponent<ObjectWait>().Wait<WaitType.Wait_CreateMyUnit>();
            M2C_CreateMyUnit m2CCreateMyUnit = waitCreateMyUnit.Message;
            Unit unit = UnitFactory.Create(currentScene, m2CCreateMyUnit.Unit);
            unitComponent.Add(unit);

            //zoneScene.RemoveComponent<AIComponent>();
            //Game.EventSystem.PublishAsync(new EventType.SceneChangeFinish() { ZoneScene = zoneScene, CurrentScene = currentScene }).Coroutine();
            await TimerComponent.Instance.WaitAsync(1000);
            if (sceneName == "Map1")
            {
                GameHelper.InitMainHomeComponent(currentScene);
                Game.EventSystem.PublishAsync(new EventType.HideGameUI() { ZoneScene = zoneScene, CurrentScene = currentScene }).Coroutine();
            }
            if(sceneName == "Game")
            {
                GameHelper.AddRoomIndex(zoneScene);
                GameHelper.InitGameComponent(currentScene);
            }
            Game.EventSystem.PublishAsync(new EventType.SceneChangeFinish() { ZoneScene = zoneScene }).Coroutine();
        }
    }
}