using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
namespace ET
{
	[ObjectSystem]
	public class ESNextWaveAwakeSystem : AwakeSystem<ESNextWave,Transform> 
	{
		public override void Awake(ESNextWave self,Transform transform)
		{
			self.uiTransform = transform;
			self.WaveInfoTimer = 0;
			self.waveInfoTrigger = false;
		}
	}
    public class ESNextWaveUpdateSystem : UpdateSystem<ESNextWave>
    {
        public override void Update(ESNextWave self)
        {
            if(self.waveInfoTrigger == true)
			{
				self.WaveInfoTimer = self.WaveInfoTimer + Time.deltaTime;
				if(self.WaveInfoTimer > 0.1f)
				{
					self.E_NextWaveInfoBaseImage.gameObject.SetActive(true);
					if(self.currenwaveinfo.Count > 0)
					{
						int count = 0;
                        string description = "";
                        foreach (int monsterid in self.currenwaveinfo.Keys)
						{
							if (count % 2 == 0 && count > 0) description = description + "\n";
							MonsterConfig monsterconfig = MonsterConfigCategory.Instance.Get(monsterid);
							FightItemConfig fightitemconfig = FightItemConfigCategory.Instance.Get(monsterconfig.MonsterConfigId);
							string monstername = fightitemconfig.FightItemName;
							int monstercount = self.currenwaveinfo[monsterid];
                            description = description + monstername + " x" + monstercount;
							if (count % 2 == 0) description = description + "      ";
							count++;
                        }
						self.E_NextWaveInfoDescriptionText.SetText(description);

                    }
				}
			}
			else
			{
				self.WaveInfoTimer = 0;
                self.E_NextWaveInfoBaseImage.gameObject.SetActive(false);
            }
        }
    }



    [ObjectSystem]
	public class ESNextWaveDestroySystem : DestroySystem<ESNextWave> 
	{
		public override void Destroy(ESNextWave self)
		{
			self.DestroyWidget();
		}
	}
	[FriendClass(typeof(ESNextWave))]
	[FriendClass(typeof(GameComponent))]
	public static class ESNextWaveSystem
	{ 
		public static void Register(this ESNextWave self,int roadId)
		{
			self.RegisterTriggerEvent();
            if (self.ZoneScene().CurrentScene().GetComponent<GameComponent>().MatchMode == 1)
			{
                self.E_NextWaveIconButton.AddListener(() => { self.NextWave(); });
            }
			if(self.ZoneScene().CurrentScene().GetComponent<GameComponent>().MatchMode != 1)
			{
				self.E_NextWaveInfoWarmText.gameObject.SetActive(false);
			}
			self.InitArrow(roadId);
		}
		public static void InitArrow(this ESNextWave self,int roadId)
		{
			List<Vector3[]> vector3s = self.ZoneScene().CurrentScene().GetComponent<GameComponent>().MonsterNavs;
            int levelId = self.ZoneScene().CurrentScene().GetComponent<GameComponent>().LevelId;
            LevelConfig levelconfig = LevelConfigCategory.Instance.Get(levelId);
            MapConfig mapconfig = MapConfigCategory.Instance.Get(levelconfig.MapId);
            if (roadId <= mapconfig.WaveInfoX.Length) 
			{
				Vector3 src = vector3s[roadId - 1][0];
				float x = mapconfig.WaveInfoX[roadId - 1] / 100.0f;
                float y = mapconfig.WaveInfoY[roadId - 1] / 100.0f;
				Vector3 dst = new Vector2(x, y);
				Vector3 dir = src - dst;
                float value = Mathf.Atan(dir.y / dir.x) * Mathf.Rad2Deg;
                if (dir.x >= 0 && dir.y > 0)//第一象限 +  45  -135
				{
					self.E_NextWaveArrowImage.transform.rotation = Quaternion.Euler(0, 0, -180 + value);
					self.E_NextWaveInfoBaseImage.transform.localPosition = new Vector3(-279, -166, 0);
				}
                if (dir.x < 0 && dir.y >= 0)//第二象限 -  135   -45
                {
					self.E_NextWaveArrowImage.transform.rotation = Quaternion.Euler(0, 0,  value);
                    self.E_NextWaveInfoBaseImage.transform.localPosition = new Vector3(279, -166, 0);
                }
                if (dir.x <= 0 && dir.y < 0)//第三象限 + -135  45
                {
					self.E_NextWaveArrowImage.transform.rotation = Quaternion.Euler(0, 0, value);
                    self.E_NextWaveInfoBaseImage.transform.localPosition = new Vector3(279, 166, 0);
                }
                if (dir.x > 0 && dir.y <= 0)//第四象限 -  -45  135
                {
					self.E_NextWaveArrowImage.transform.rotation = Quaternion.Euler(0, 0, -180 + value);
                    self.E_NextWaveInfoBaseImage.transform.localPosition = new Vector3(-279, 166, 0);
                }
            }

        }
		public static void RegisterTriggerEvent(this ESNextWave self)
		{
            EventTrigger.Entry entry1 = new EventTrigger.Entry();
            entry1.eventID = EventTriggerType.PointerEnter;
            entry1.callback.AddListener((data1) =>
            {
				self.ShowWaveInfo();
            });
            self.E_NextWaveIconEventTrigger.triggers.Add(entry1);
            EventTrigger.Entry entry2 = new EventTrigger.Entry();
            entry2.eventID = EventTriggerType.PointerExit;
            entry2.callback.AddListener((data2) =>
            {
				self.HideWaveInfo();
            });
            self.E_NextWaveIconEventTrigger.triggers.Add(entry2);
        }
		public static void NextWave(this ESNextWave self)
		{
			self.ZoneScene().GetComponent<UIComponent>().GetDlgLogic<DlgGameUI>().NextWave();
		}
		public static void UpdateWaveInfo(this ESNextWave self,Dictionary<int,int> waveinfo)
		{
			self.currenwaveinfo.Clear();
			self.currenwaveinfo = waveinfo;
		}
		public static void ShowWaveInfo(this ESNextWave self)
		{
			self.waveInfoTrigger = true;
		}
		public static void HideWaveInfo(this ESNextWave self)
		{
			self.waveInfoTrigger = false;
		}
		public static void ShowWindow(this ESNextWave self)
		{
			self.uiTransform.gameObject.SetActive(true);
            self.E_NextWaveInfoBaseImage.gameObject.SetActive(false);
			self.waveInfoTrigger = false;
        }
		public static void HideWindow(this ESNextWave self)
		{
			self.uiTransform.gameObject.SetActive(false);
            self.E_NextWaveInfoBaseImage.gameObject.SetActive(false);
            self.waveInfoTrigger = false;
        }
	}

}
