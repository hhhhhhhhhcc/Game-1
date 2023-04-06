using ET.EventType;
using System.Collections.Generic;

namespace ET
{
    public class GameUpdateWaveInfoEvent : AEventAsync<EventType.GameUpdateWaveInfo>
    {
        protected override async ETTask Run(GameUpdateWaveInfo args)
        {
            List<int> monsterconfigid = args.CurrentWaveAllMonsterConfigId;//怪物config
            List<int> monsteroadid = args.CurrentWaveAllMonsterRoadId;//怪物路线
            Dictionary<int ,Dictionary<int,int>> monsterwaveinfo = new Dictionary<int, Dictionary<int, int>>();  //路线  configid  数量
            if (monsterconfigid != null)
            {
                for (int i = 0; i < monsterconfigid.Count; i++)
                {
                    int roadid = monsteroadid[i];//怪物路线
                    Log.Debug(roadid.ToString());
                    int configid = monsterconfigid[i];//怪物configId
                    if(!monsterwaveinfo.ContainsKey(roadid))//不存在这个路线的怪物
                    {
                        Dictionary<int,int> monsternumberdict = new Dictionary<int, int>();
                        monsternumberdict.Add(configid, 1);
                        monsterwaveinfo.Add(roadid, monsternumberdict);
                    }
                    else//存在这个路线的怪物 
                    {
                        Dictionary<int,int> monsternumberdict = monsterwaveinfo[roadid];
                        if(monsternumberdict.ContainsKey(configid))//且存在这个configid的怪物
                        {
                            monsternumberdict[configid]++;
                        }
                        else//不存在这个configid的怪物
                        {
                            monsternumberdict.Add(configid, 1);
                        }
                    }
                }
            }//路线id configid 数量
            args.zonescene.GetComponent<UIComponent>().GetDlgLogic<DlgGameUI>().UpdateGameWaveInfo(args.CurrentWaveNumber, monsterwaveinfo);
            await ETTask.CompletedTask;
        }
    }
}
