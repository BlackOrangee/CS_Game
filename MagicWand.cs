using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNamespace
{
    internal class MagicWand : Equipment
    {
        public MagicWand() 
        {
            PhysicalAttackPower = 5;
            MagicalAttackPower = 50;
            ResistanceToPhysical = 1;
            ResistanceToMagical = 25;
            CriticalChance = 10;
            DodgeChance = 8;
        }

        public int EquipmentSpecialAttack() { return 120; }
    }
}