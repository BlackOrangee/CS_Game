using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNamespace
{
    internal class AnnihilatorCannon : Equipment
    {
        public AnnihilatorCannon() 
        {
            PhysicalAttackPower = 999;
            MagicalAttackPower = 999;
            ResistanceToPhysical = 0;
            ResistanceToMagical = 0;
            CriticalChance = 99;
            DodgeChance = 99;
        }

        public int EquipmentSpecialAttack() { return 9999; }
    }
}
