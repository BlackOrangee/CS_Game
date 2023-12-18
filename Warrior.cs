using MyNamespace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNamespace
{
    class Warrior : Hero
    {
        public Warrior(string Name)
        {
            this.Name = Name;
            this.Health = 200;
            this.AttackPower = 65;
            this.PhysicalAttackPower = 65;
            this.MagicalAttackPower = 5;
            this.ResistanceToPhysical = 60;
            this.ResistanceToMagical = 20;
            this.CriticalChance = 10;
            this.DodgeChance = 20;
            this.heal = 0;
            this.UltimateAttack = 0;
        }
    }
}
