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
            player2 = new Player("Играч 2");

            player1.Pokemons.Add(new Pokemon(1, "Pikachu", 70, 50, 60, 100, 1));
            player1.Pokemons.Add(new Pokemon(2, "Charizard", 85, 75, 80, 100, 1));
            player1.Pokemons.Add(new Pokemon(3, "Blastoise", 80, 80, 80, 100, 1));

            player2.Pokemons.Add(new Pokemon(4, "Mew", 60, 90, 90, 100, 2));
            player2.Pokemons.Add(new Pokemon(5, "Gardevoir", 70, 65, 70, 100, 2));
            player2.Pokemons.Add(new Pokemon(6, "Lucario", 80, 60, 70, 100, 2));
        }

        public void StartGame()
        {
            ChoosePokemon(player1);
            ChoosePokemon(player2);

            while (player1.HasAlivePokemon() && player2.HasAlivePokemon())
            {
                PlayerTurn(player1, player2);

                if (!player2.HasAlivePokemon())
                    break;

                PlayerTurn(player2, player1);
            }

            if (player1.HasAlivePokemon())
                Console.WriteLine("Играч 1 печели!");
            else
                Console.WriteLine("Играч 2 печели!");
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

        private void ChoosePokemon(Player player)
        {
            Console.WriteLine();
            Console.WriteLine($"{player.Name} избери покемон:");

            for (int i = 0; i < player.Pokemons.Count; i++)
            {
                if (player.Pokemons[i].IsAlive)
                {
                    Console.WriteLine($"{i + 1}. {player.Pokemons[i].Name} ({player.Pokemons[i].Health} HP)");
                }
            }

            int choice = int.Parse(Console.ReadLine());

            while (!player.Pokemons[choice - 1].IsAlive)
            {
                Console.WriteLine("Този покемон е мъртъв. Избери друг.");
                choice = int.Parse(Console.ReadLine());
            }

            player.ActivePokemon = player.Pokemons[choice - 1];
        }
    }
}
