using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNamespace
{
    internal class Sword : Equipment
    {
        public Sword()
        {
            PhysicalAttackPower = 50;
            MagicalAttackPower = 10;
            ResistanceToPhysical = 20;
            ResistanceToMagical = 5;
            CriticalChance = 10;
            DodgeChance = -10;
        }

        public int EquipmentSpecialAttack() { return 110; }
    }
}
