using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class ResonanceFrequencySkill : Entity,IAwake,IDestroy, LogicAddBuff
    {
        public Dictionary<string,int> param = new Dictionary<string,int>();
    }
}
