using MyNamespace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNamespace
{
    class Player
    {
        private Hero hero;

        private string name = "name";
        private int Damage { get; set; }
        private int Gold { get; set; }

        private Dictionary<string, Equipment> inventory = new Dictionary<string, Equipment>();

        public void HeroReset()
        {
            Console.WriteLine($"{name} is dead\n\nCreating a new hero:\n\n");
            hero = new Hero();
            NameEnter();
            ClassChoose();
        }

        public int getHeroTotalDamage()
        {
            return hero.TotalDamage;
        }

        public int getHeroHealth()
        {
            return hero.Health;
        }

        public void GetHeroStats()
        {
            Console.WriteLine($"\nGold: {Gold}\nName: {hero.Name}\nHealth: {hero.Health}\n" +
                $"Physical attack power: {hero.PhysicalAttackPower}\nMagical attack power: {hero.MagicalAttackPower}\n" +
                $"Resistance to physical: {hero.ResistanceToPhysical}\nResistance to magical: {hero.ResistanceToMagical}\n" +
                $"Critical chance: {hero.CriticalChance}\nDodge chance: {hero.DodgeChance}");
        }

        private void NameEnter()
        {
            Console.WriteLine($"Enter the hero name: ");
            name = Console.ReadLine();
            Console.Write($"\n");
        }

        private void ClassChoose()
        {
            Console.WriteLine($"\nChoose hero class: ");
            Console.WriteLine($"1 -- Warrior");
            Console.WriteLine($"2 -- Mage");
            Console.WriteLine($"3 -- Archer\n");

            bool correct = false;

            do
            {
                ConsoleKeyInfo choose = Console.ReadKey();
                Console.Write($"\n");

                switch (choose.KeyChar)
                {
                    case '1':
                        hero = new Warrior(name);
                        correct = true;
                        break;

                    case '2':
                        hero = new Mage(name);
                        correct = true;
                        break;

                    case '3':
                        hero = new Archer(name);
                        correct = true;
                        break;

                    default:
                        Console.WriteLine($"\nWrong key\n");
                        correct = false;
                        break;
                }
            } while (!correct);
        }

        public Player()
        {
            NameEnter();
            ClassChoose();
        }

        public void GetDamage()
        {
            Damage = hero.Attack();
        }

        private void AttackOptions()
        {
            BattleInfo battleInfo = BattleInfo.getInstanse();

            Console.WriteLine($"\nAttack options: ");
            Console.WriteLine($"1 -- Physical");
            Console.WriteLine($"2 -- Magical\n");

            bool correct = false;

            do
            {
                ConsoleKeyInfo choose = Console.ReadKey();
                Console.Write($"\n");

                switch (choose.KeyChar)
                {
                    case '1':
                        battleInfo.AttackPower = hero.PhysicalAttackPower;
                        battleInfo.AttackType = AttackType.Physical;
                        battleInfo.CriticalChance = hero.CriticalChance;
                        correct = true;
                        break;

                    case '2':
                        battleInfo.AttackPower = hero.MagicalAttackPower;
                        battleInfo.AttackType = AttackType.Magical;
                        battleInfo.CriticalChance = hero.CriticalChance;
                        correct = true;
                        break;

                    default:
                        Console.WriteLine($"\nWrong key");
                        correct = false;
                        break;
                }
            } while (!correct);
        }

        public void Action()
        {
            BattleInfo battleInfo = BattleInfo.getInstanse();

            
            Console.WriteLine($"\n{name} turn");
            Console.WriteLine($"1 -- Heal");
            Console.WriteLine($"2 -- Defense");
            Console.WriteLine($"3 -- Attack");
            if (hero.UltimateAttack >= 3)
                Console.WriteLine($"4 -- Ultimate attack");
            Console.WriteLine($"\n");

            bool correct = false;

            do
            {
                ConsoleKeyInfo choose = Console.ReadKey();
                Console.Write($"\n");

                switch (choose.KeyChar)
                {
                    case '1':
                        hero.Heal(50);
                        hero.Health -= Damage;
                        correct = true;
                        break;

                    case '2':
                        hero.Health -= hero.Defense(Damage);
                        correct = true;
                        break;

                    case '3':
                        // Player attack logic
                        AttackOptions();
                        hero.Health -= Damage;
                        correct = true;
                        break;

                    case '4':
                        // Player ultimate attack logic
                        AttackOptions();
                        battleInfo.AttackPower = battleInfo.AttackPower + (battleInfo.AttackPower * 2) / 10;
                        hero.UltimateAttack = 0;
                        hero.Health -= Damage;
                        correct = true;
                        break;
                    default:
                        Console.WriteLine($"\nWrong key");
                        correct = false;
                        break;
                }
                Gold += battleInfo.gold;
            } while (!correct);
        }
    }
}
