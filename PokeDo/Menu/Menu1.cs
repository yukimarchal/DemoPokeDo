using PokeDo.Quest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeDo.Menu
{
    internal class Menu1
    {
        public void MenuPokemon(Pokemon.Pokemon myPokemon)
        {
            Console.Clear();
            myPokemon.CalcLevel(myPokemon._levelTable);
            myPokemon.CalcExpTillNextLevel();
            myPokemon.ShowStatus();


            myPokemon._exp += 6;

            Console.WriteLine("Press any key to go back to the menu");
            Console.WriteLine();
            Console.ReadLine();
            Console.Clear();
        }

    }
}
