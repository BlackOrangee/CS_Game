using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNamespace
{
    internal class Shield : Equipment
    {
        public Shield() 
        {
            PhysicalAttackPower = 5;
            MagicalAttackPower = 2;
            ResistanceToPhysical = 40;
            ResistanceToMagical = 15;
            CriticalChance = -10;
            DodgeChance = -20;
        }

        public int EquipmentSpecialAttack() { return 20; }
    }
}
