using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ArmanKaanPokemonBattle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Game game = new Game();
            game.StartGame();

            Console.ReadKey(); // натисни копче за да продължи
        }
    }
}
