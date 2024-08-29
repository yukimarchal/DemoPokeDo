using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PokeDo.Battle;
using PokeDo.Menu;

namespace PokeDo.Menu
{
    internal class Menu3
    {
        public void MenuBattle(Pokemon.Pokemon myPokemon, GymGestion gestionGym)
        {
            Console.Clear();
            gestionGym.ShowGyms();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Select gym by the number");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("1 : Pewter gym");
            Console.WriteLine();
            Console.WriteLine("2 : Go back to the menu");
            Console.WriteLine();

            int userInput = Tools.newUserInput(2);
            Console.WriteLine();

            switch (userInput)
            {
                case 1:
                    gestionGym.AccessGym(userInput);

                    Texts.BrockBefore();

                    Boolean isWon = gestionGym.Battle(myPokemon, gestionGym._gymList[userInput - 1]._pokemon, userInput);

                    if (isWon) Texts.BrockAfter();

                    break;
                case 2:
                    Console.WriteLine("OK! Good Luck!");
                    Console.WriteLine();
                    Thread.Sleep(1000);
                    Console.Clear();
                    break;
            }
        }
    }
}
