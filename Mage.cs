using MyNamespace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNamespace
{
    class Mage : Hero
    {
        public Mage(string Name)
        {
            this.Name = Name;
            this.Health = 75;
            this.AttackPower = 150;
            this.PhysicalAttackPower = 10;
            this.MagicalAttackPower = 150;
            this.ResistanceToPhysical = 5;
            this.ResistanceToMagical = 100;
            this.CriticalChance = 30;
            this.DodgeChance = 65;
            this.heal = 0;
            this.UltimateAttack = 0;
        }
    }
}
