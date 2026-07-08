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
        public int Id { get; set; }
        public string Name { get; set; }
        public int Attack { get; set; }
        public int Defence { get; set; }
        public int Strength { get; set; }
        public int Health { get; set; }
        public string Owner { get; set; }
        public bool IsAlive { get; set; }
    }
}
