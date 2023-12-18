using MyNamespace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNamespace
{
    class Archer : Hero
    {
        public Archer(string Name)
        {
            this.Name = Name;


            this.Health = 120;
            this.AttackPower = 75;
            this.PhysicalAttackPower = 75;
            this.MagicalAttackPower = 20;
            this.ResistanceToPhysical = 30;
            this.ResistanceToMagical = 30;
            this.CriticalChance = 40;
            this.DodgeChance = 75;
            this.heal = 0;
            this.UltimateAttack = 0;
        }
    }
}
