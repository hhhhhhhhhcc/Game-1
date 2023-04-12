namespace ET
{
    public interface LogicSkill//技能时间调用
    {

    }
    public interface Skill//放技能调用
    {

    }
    public interface ChanceSkill//概率技能
    {

    }
    public interface LogicBuff//每帧调用buff
    {

    }
    public interface BeforeBuild//建造塔之前调用
    {

    }
    public interface AfterBuild//建造塔之前调用
    {

    }
    public interface LogicAddBuff//每帧调用提供buff
    { 

    }
    public interface PlayerLogic//玩家技能(有持续时间的上这个接口)
    {

    }
    public interface PlayerAfterKillCoin//全局杀怪获得金币调用这个接口
    {

    }
    public interface PlayerInitTowerSkill//玩家技能用到塔 传塔的参数
    {

    }
    public interface PlayerInitPositionSkill//玩家技能用到位置 传位置参数
    {

    }
    public interface PlayerInitZoneSkill//玩家技能  用到队伍传递队伍参数
    {

    }


}
