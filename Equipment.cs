using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNamespace
{
    internal class Equipment
    {
        public int PhysicalAttackPower { get; set; }
        public int MagicalAttackPower { get; set; }
        public int ResistanceToPhysical { get; set; }
        public int ResistanceToMagical { get; set; }
        public int CriticalChance { get; set; }
        public int DodgeChance { get; set; }
        public int heal { get; set; }

        public int EquipmentSpecialAttack() {  return 0; }
    }
}
