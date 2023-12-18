using MyNamespace;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNamespace
{
    class Hero
    {
        public string Name { get; set; }
        public int MaxHealth { get; set; }
        public int Health { get; set; }
        public int AttackPower { get; set; }
        public int PhysicalAttackPower { get; set; }
        public int MagicalAttackPower { get; set; }
        public int ResistanceToPhysical { get; set; }
        public int ResistanceToMagical { get; set; }
        public int CriticalChance { get; set; }
        public int DodgeChance { get; set; }
        public int heal { get; set; }
        public int UltimateAttack { get; set; }
        public int TotalDamage { get; set; }

        private Dictionary<string, Equipment> equipmentList = new Dictionary<string, Equipment>();


        public delegate int AttackDelegate(BattleInfo battleInfo);

        Dictionary<string, AttackDelegate> skils = new Dictionary<string, AttackDelegate>();

        public Hero(string name)
        {
            this.Name = name;


        }


        public void RemooveEquipment(string name)
        {
            if (equipmentList.ContainsKey(name))
            {
                DeEquipEquipment(equipmentList[name]);

                equipmentList.Remove(name);
            }
        }

        public void setEquipment(string name, Equipment equipment)
        {
            RemooveEquipment(name);

            equipmentList.Add(name, equipment);

            EquipEquipment(equipment);
        }

        private void DeEquipEquipment(Equipment item)
        {
            this.PhysicalAttackPower -= item.PhysicalAttackPower;
            this.MagicalAttackPower -= item.MagicalAttackPower;
            this.ResistanceToPhysical -= item.ResistanceToPhysical;
            this.ResistanceToMagical -= item.ResistanceToMagical;
            this.CriticalChance -= item.CriticalChance;
            this.DodgeChance -= item.DodgeChance;
        }

        private void EquipEquipment(Equipment item)
        {
            this.PhysicalAttackPower += item.PhysicalAttackPower;
            this.MagicalAttackPower += item.MagicalAttackPower;
            this.ResistanceToPhysical += item.ResistanceToPhysical;
            this.ResistanceToMagical += item.ResistanceToMagical;
            this.CriticalChance += item.CriticalChance;
            this.DodgeChance += item.DodgeChance;
        }

        public int Attack()
        {
            BattleInfo battleInfo = BattleInfo.getInstanse();

            Random random = new Random();

            int dogeChange = random.Next(0, 100);

            if (dogeChange <= this.DodgeChance)
            {
                return 0;
            }

            int critChance = random.Next(0, 100);

            int attack = battleInfo.AttackPower;

            battleInfo.gold = attack;

            if (critChance <= battleInfo.CriticalChance)
            {
                attack *= 2;
            }

            if (battleInfo.AttackType == AttackType.Physical)
            {
                attack -= ResistanceToPhysical;
            }
            else
            {
                attack -= ResistanceToMagical;
            }

            if (attack <= 0)
            {
                return 0;
            }
            TotalDamage += attack;
            return attack;
        }

        public int Defense(int attack)
        {
            return attack / 2;
        }

        public void Heal(int heal)
        {
            if ((Health + heal) >= MaxHealth)
                Health = MaxHealth;

            Health += heal;
        }


    }
}
