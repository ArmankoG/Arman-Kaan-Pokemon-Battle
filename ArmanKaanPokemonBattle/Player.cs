using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmanKaanPokemonBattle
{
    public class Player
    {
        public string Name { get; set; }

        public List<Pokemon> Pokemons { get; set; }

        public Pokemon ActivePokemon { get; set; }

        public Player(string name)
        {
            Name = name;
            Pokemons = new List<Pokemon>();
        }

        public bool HasAlivePokemon()
        { 
            foreach (Pokemon p in Pokemons)
            {
                if (p.IsAlive)
                    return true;
            }
            return false;
        }

        public void HealReservePokemons()
        {
            //todo
        }
    }
}
