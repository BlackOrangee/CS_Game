using MyNamespace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNamespace
{
    class BattleInfo
    {
        public int AttackPower { get; set; }
        public AttackType AttackType { get; set; }
        public int CriticalChance { get; set; }
        public Weather Weather { get; set; }
        public Location Location { get; set; }
        public int gold {  get; set; }
        
        private BattleInfo()
        {
            AttackPower = 0;
            AttackType = AttackType.Physical;
            CriticalChance = 0;
            Weather = Weather.Sun;
            Location = Location.Plato;
            gold = 0;
        }

        private static BattleInfo battleInfo = null;

        public static BattleInfo getInstanse()
        {
            if (battleInfo == null)
                battleInfo = new BattleInfo();

            return battleInfo;
        }
    }
}
