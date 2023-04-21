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
            self.SquareDecorate = (obj.GetComponent<ReferenceCollector>().GetObject("SquareDecorate") as GameObject).GetComponent<SpriteRenderer>();
            self.Star = (obj.GetComponent<ReferenceCollector>().GetObject("Star") as GameObject).GetComponent<SpriteRenderer>();
            self.StarSquare = (obj.GetComponent<ReferenceCollector>().GetObject("StarSquare") as GameObject).GetComponent<SpriteRenderer>();
            if ((obj.GetComponent<ReferenceCollector>().GetObject("AttackPoint") as GameObject)!=null)
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
            self.Star = null;
            self.StarSquare = null;
            self.AttackPoint = null;
            self.SquareDecorate = null;
        }
    }
    [FriendClass(typeof(TowerChargeComponent))]
    public static class TowerChargeComponentSystem
    {
        public static void SetChargeBar(this TowerChargeComponent self,float value,TowerState TowerState)
        {
            Material mat = self.ChargeBar.material;
            mat.SetFloat("_FillType", 0);
            mat.SetFloat("_FillAmount", value);
            if (TowerState == TowerState.NormalAttack)
            {
                self.StarSquare.sprite = IconHelper.LoadIconSprite("GameElement", "StarSquareNormal");
                self.Star.sprite = IconHelper.LoadIconSprite("GameElement", "StarNormal");
                self.ChargeBar.sprite = IconHelper.LoadIconSprite("GameElement", "BarNormal");
                self.SquareDecorate.gameObject.SetActive(false);
            }
            if (TowerState == TowerState.SkillAttack)
            {
                self.StarSquare.sprite = IconHelper.LoadIconSprite("GameElement", "StarSquareBright");
                self.Star.sprite = IconHelper.LoadIconSprite("GameElement", "StarBright");
                self.ChargeBar.sprite = IconHelper.LoadIconSprite("GameElement", "BarBright");
                self.SquareDecorate.gameObject.SetActive(true);
            }
            if(value == 1)
            {
                self.StarSquare.sprite = IconHelper.LoadIconSprite("GameElement", "StarSquareBright");
                self.Star.sprite = IconHelper.LoadIconSprite("GameElement", "StarBright");
                self.ChargeBar.sprite = IconHelper.LoadIconSprite("GameElement", "BarBright");
                self.SquareDecorate.gameObject.SetActive(true);
            }
        }
        public static void Init(this TowerChargeComponent self)
        {
            Material mat = self.ChargeBar.material;
            mat.SetFloat("_FillType", 0);
            mat.SetFloat("_FillAmount", 0);
            self.StarSquare.sprite = IconHelper.LoadIconSprite("GameElement", "StarSquareNormal");
            self.Star.sprite = IconHelper.LoadIconSprite("GameElement", "StarNormal");
            self.ChargeBar.sprite = IconHelper.LoadIconSprite("GameElement", "BarNormal");
            self.SquareDecorate.gameObject.SetActive(false);
        }
        public static void JudgeChargeBar(this TowerChargeComponent self,List<int> TalentIds)
        {
            self.TowerChargeBarGroup.gameObject.SetActive(false);
            for (int i=0;i<TalentIds.Count;i++)
            {
                int TalentId = TalentIds[i];
                if(((TalentId - 1) % 6 + 1) == 1 || ((TalentId - 1) % 6 + 1) == 2)
                {
                    self.TowerChargeBarGroup.gameObject.SetActive(true);
                }
            }
        }
    }
}
