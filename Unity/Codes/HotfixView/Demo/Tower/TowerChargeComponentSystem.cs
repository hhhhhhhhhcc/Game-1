using System.Collections.Generic;
using UnityEngine;
namespace ET
{
    public class TowerChargeComponentAwakeSystem : AwakeSystem<TowerChargeComponent>
    {
        public override void Awake(TowerChargeComponent self)
        {
            GameObject obj = self.GetParent<Tower>().GetComponent<GameObjectComponent>().GameObject;
            self.TowerChargeBarGroup = obj.GetComponent<ReferenceCollector>().GetObject("TowerChargeBar") as GameObject;
            self.ChargeBar = (obj.GetComponent<ReferenceCollector>().GetObject("ChargeBar") as GameObject).GetComponent<SpriteRenderer>();
            if((obj.GetComponent<ReferenceCollector>().GetObject("AttackPoint") as GameObject)!=null)
            {
                self.AttackPoint = (obj.GetComponent<ReferenceCollector>().GetObject("AttackPoint") as GameObject).transform;
            }
        }
    }
    public class TowerChargeComponentDestroySystem : DestroySystem<TowerChargeComponent>
    {
        public override void Destroy(TowerChargeComponent self)
        {
            self.TowerChargeBarGroup = null;
            self.ChargeBar = null;
        }
    }
    [FriendClass(typeof(TowerChargeComponent))]
    public static class TowerChargeComponentSystem
    {
        public static void SetChargeBar(this TowerChargeComponent self,float value)
        {
            Material mat = self.ChargeBar.material;
            mat.SetFloat("_FillType", 0);
            mat.SetFloat("_FillAmount", value);
        }
        public static void JudgeChargeBar(this TowerChargeComponent self,List<int> TalentIds)
        {
            bool visual = false;
            for(int i=0;i<TalentIds.Count;i++)
            {
                int TalentId = TalentIds[i];
                if(((TalentId - 1) % 6 + 1) == 1 || ((TalentId - 1) % 6 + 1) == 2)
                {
                    visual = true;
                }
            }
            if(visual)
            {
                self.TowerChargeBarGroup.gameObject.SetActive(true);
            }
            else
            {
                self.TowerChargeBarGroup.gameObject.SetActive(false);
            }
        }
    }
}
