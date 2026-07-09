using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmanKaanPokemonBattle
{
    internal class Game
    {
        Player player1;
        Player player2;

        public Game()
        {
            player1 = new Player("Играч 1");
            player1 = new Player("Играч 2");
        }

        public void StartGame() // да се довърши
        {
            ChoosePokemon(player1);
            ChoosePokemon(player2);
        }

        private void PlayerTurn(Player current, Player enemy)
        {
            Console.WriteLine();
            Console.WriteLine($"Ход на {current.Name}");
            Console.WriteLine($"Ваш покемон: {current.ActivePokemon.Name} ({current.ActivePokemon.Health} HP)");
            Console.WriteLine($"Противник: {enemy.ActivePokemon.Name} ({enemy.ActivePokemon.Health} HP)");

            Console.WriteLine("1. Атака");
            Console.WriteLine("2. Смяна");

            int choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                current.ActivePokemon.AttackEnemy(enemy.ActivePokemon);

                if (!enemy.ActivePokemon.IsAlive && enemy.HasAlivePokemon())
                {
                    Console.WriteLine($"{enemy.Name} избира нов покемон.");
                    ChoosePokemon(enemy);
                }
            }
            else
            {
                ChoosePokemon(current);
            }

            current.HealReservePokemons();
        }

        private void ChoosePokemon() // също така да се довърши
        {
            Console.WriteLine();
            Console.WriteLine($"избери покемон:");
        }
    }
}
