using MyNamespace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MyNamespace
{
    class Game
    {
        private BattleInfo battleInfo = BattleInfo.getInstanse();

        private Player player1;
        private Player player2;

        public Game() 
        {
            WeatherSet();
            LocationSet();

            Console.WriteLine($"Player 1:");
            player1 = new Player();

            Console.WriteLine($"Player 2:");
            player2 = new Player();
        }

        private void WeatherSet()
        {
            BattleInfo battleInfo = BattleInfo.getInstanse();
            Console.WriteLine($"\nChoose Weather");
            Console.WriteLine($"\n1 -- Sun");
            Console.WriteLine($"2 -- Rain");
            Console.WriteLine($"3 -- Wind");
            Console.WriteLine($"4 -- Snow");

            ConsoleKeyInfo key = Console.ReadKey();

            switch (key.KeyChar)
            {
                case '1':
                    battleInfo.Weather = Weather.Sun;
                    break;
                case '2':
                    battleInfo.Weather = Weather.Rain;
                    break;
                case '3':
                    battleInfo.Weather = Weather.Wind;
                    break;
                case '4':
                    battleInfo.Weather = Weather.Snow;
                    break;
                default:
                    Console.WriteLine($"Wrong key\n");
                    WeatherSet();
                    break;
            }
        }

        private void LocationSet()
        {
            BattleInfo battleInfo = BattleInfo.getInstanse();
            Console.WriteLine($"\nChoose location");
            Console.WriteLine($"\n1 -- Plato");
            Console.WriteLine($"2 -- Mountains");
            Console.WriteLine($"3 -- Forest");

            ConsoleKeyInfo key = Console.ReadKey();

            switch ( key.KeyChar )
            {
                case '1':
                    battleInfo.Location = Location.Plato;
                    break;
                case '2':
                    battleInfo.Location = Location.Mountains;
                    break;
                case '3':
                    battleInfo.Location = Location.Forest;
                    break;
                default:
                    Console.WriteLine($"Wrong key\n");
                    LocationSet();
                    break;
            }
        }
        private void DisplayPlayers()
        {
            Console.Clear();
            Console.WriteLine("Player 1");
            player1.GetHeroStats();

            Console.WriteLine("\n\nPlayer 2");
            player2.GetHeroStats();

        }

        private bool IsDead(Player player)
        {
            if (player.getHeroHealth() <= 0)
                return true; 
            return false;
        }

        public void Play()
        {

            Fight();

            Reset();

            Shop();

            Play();
        }

        public void Shop()
        {
            Console.Clear();
            Console.WriteLine($"Shop:\n\n1 -- Sword -- 200 G\n2 -- Shield -- 170 G\n3 -- Magic wand -- 180 G\n4 -- ANNIHILATOR CANON!!1! -- 9999 G");

            // Equipment 
        }

        public void Fight()
        {

            player1.GetDamage();

            player1.Action();

            DisplayPlayers();

            if (IsDead(player1))
                return;

            player2.GetDamage();

            player2.Action();

            DisplayPlayers();

            if (IsDead(player2))
                return;

            Fight();
        }

        public void Reset()
        {
            if (IsDead(player1))
                player1.HeroReset();

            if (IsDead(player2))
                player2.HeroReset();
        }
    }
}
