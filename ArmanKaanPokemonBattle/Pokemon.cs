using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ArmanKaanPokemonBattle
{
    public class Pokemon
    {
        private static Random rnd = new Random();
        public int Id { get; set; }
        public string Name { get; set; }
        public int Attack { get; set; }
        public int Defence { get; set; }
        public int Strength { get; set; }
        public int Health { get; set; }
        public int Owner { get; set; }
        public bool IsAlive { get; set; }

        public Pokemon(int id, string name, int attack, int defence, int strength, int health, int owner)
        {
            Id = id;
            Name = name;
            Attack = attack;
            Defence = defence;
            Strength = strength;
            Health = health;
            Owner = owner;
            IsAlive = true;
        }

        public void AttackEnemy(Pokemon enemy)
        {
            int att = rnd.Next(0, Attack + 1);
            int def = rnd.Next(0, enemy.Defence + 1);

            Console.WriteLine($"{Name} атакува с {att}");
            Console.WriteLine($"{enemy.Name} защитава с {def}");

            if (att > def)
            {
                int damage = att - def;
                enemy.Health -= damage;

                Console.WriteLine($"Щета: {damage}");

                if (enemy.Health <= 0)
                {
                    enemy.Health = 0;
                    enemy.IsAlive = false;
                    Console.WriteLine($"{enemy.Name} е победен!");
                }
            }
            else
            {
                Console.WriteLine("Няма нанесена щета.");
            }
        }

        public void Heal()
        {
            if (IsAlive == false)
            {
                return;
            }

            Health += Strength / 10;

            if (Health > 100)
            {
                Health = 100;
            }
        }
    }
}
