using PokeDo.Quest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeDo.Menu
{
    internal class Menu2
    {
        public void MenuQuest(Pokemon.Pokemon myPokemon)
        {
            Console.Clear();
            QuestGestion gestion = new QuestGestion();
            gestion.ShowQuest();
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Do you want to make a change to quests?");
            Console.WriteLine();
            Console.WriteLine("Please answer by number => 1 : YES / 2 : NO");
            Console.WriteLine();

            int isContinue_int = Tools.newUserInput(2);
            Console.WriteLine();

            if (isContinue_int == 1)
            {
                Boolean isChecked = gestion.CheckPass();

                if (isChecked)
                {
                    while (isContinue_int == 1)
                    {
                        Console.Clear();
                        gestion.ShowQuest();
                        gestion.ChangeQuest(myPokemon);

                        //myPokemon.CalcLevel();
                        //myPokemon.CalcExpTillNextLevel();
                        //myPokemon.ShowStatus();
                        //Console.WriteLine();

                        Console.WriteLine("Do you want to continue making changes to other quests?");
                        Console.WriteLine();
                        Console.WriteLine("Please answer by number => 1 : YES / 2 : NO");
                        Console.WriteLine();

                        isContinue_int = isContinue_int = Tools.newUserInput(2);
                        Console.WriteLine();
                        Console.Clear();
                    }
                }
            }
            else 
            { 
                Console.WriteLine("OK. Good Luck!");
                Thread.Sleep(1000);
                Console.Clear();
            }
        }
    }
}
