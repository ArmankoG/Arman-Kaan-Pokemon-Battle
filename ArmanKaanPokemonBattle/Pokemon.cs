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
            int attacker = rnd.Next(0, Attack + 1);
            int defender = rnd.Next(0, enemy.Defence + 1);

            Console.WriteLine($"{Name} атакува с {attacker}");
            Console.WriteLine($"{enemy.Name} защитава с {defender}");

            //todo - да се направи if проверка за това дали атакуващия е по-силен от защитата, и противоположното, да се направи и метод Heal
        }
    }
}
