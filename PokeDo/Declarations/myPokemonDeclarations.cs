using PokeDo.Pokemon;
using PokeDo.Quest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PokeDo.Menu;

namespace PokeDo.Declarations
{
    internal class myPokemonDeclarations
    {
        public Pokemon.Pokemon ChoosePokemon(PokeType type1, PokeType type2, PokeType type3)
        {
            Pokemon.Pokemon myPokemon = new Pokemon.Pokemon();
            QuestGestion gestion = new QuestGestion();
            int userInput;
            int answer = 2;

            Texts.IntroOak();

            while (answer == 2)
            {
                Console.Write("You can have one. Go on choose!");
                Texts.Period();
                Console.WriteLine();
                Console.WriteLine("Please select by number");
                Console.WriteLine();
                Console.WriteLine();

                Console.WriteLine("1 : Bulbasaur < Grass type >");
                Console.WriteLine();
                Console.WriteLine("2 : Charmander < Fire type >");
                Console.WriteLine();
                Console.WriteLine("3 : Squirtle < Water type >");
                Console.WriteLine();

                userInput = Tools.newUserInput(3);
                Console.WriteLine();
                Console.Clear();

                switch (userInput)
                {
                    case 1:
                        myPokemon = Bulbasaur(type1, ref answer);

                        break;

                    case 2:
                        myPokemon = Charmander(type2, ref answer);

                        break;

                    case 3:
                        myPokemon = Squirtle(type3, ref answer);

                        break;
                }

                
            }

            Console.Write("This POKEMON is really quite energetic! ");
            Texts.Period();
            Console.WriteLine();
            Console.Write("Now, everything is set. Let’s go!");
            Texts.Period();
            Console.WriteLine();
            Console.ReadLine();
            Console.Clear();

            return myPokemon;
        }

        public Pokemon.Pokemon Bulbasaur(PokeType type1, ref int answer)
        {
            Pokemon.Pokemon myPokemon = new Pokemon.Pokemon();
            QuestGestion gestion = new QuestGestion();
            int userInput;
            Console.WriteLine();

            PokeAscii.ShowAscii("Bulbasaur");

            Console.Write("I see! BULBASAUR is your choice. ");
            Texts.Period();
            Console.WriteLine();
            Console.WriteLine("It has strong health and normal defense but weak attack. ");
            Console.Write("So, you want to go with the GRASS POKEMON BULBASAUR? ");
            Texts.Period();
            Console.WriteLine();

            Console.WriteLine("Please answer by number => 1 : YES / 2 : NO");
            Console.WriteLine();

            answer = Tools.newUserInput(2);
            Console.WriteLine();

            if (answer == 1)
            {
                myPokemon._type = type1;
                myPokemon._HP = 3;
                myPokemon._attack = 1;
                myPokemon._defense = 2;
                myPokemon._name.Add("Bulbasaur");
                myPokemon._name.Add("Ivysauer");
                myPokemon._name.Add("Venusauer");
            }
            Console.Clear();
            return myPokemon;
        }

        public Pokemon.Pokemon Charmander(PokeType type2, ref int answer)
        {
            Pokemon.Pokemon myPokemon = new Pokemon.Pokemon();
            QuestGestion gestion = new QuestGestion();
            int userInput;
            Console.WriteLine();

            PokeAscii.ShowAscii("Charmander");

            Console.Write("Ah! CHARMANDER is your choice. ");
            Texts.Period();
            Console.WriteLine();
            Console.WriteLine("It has strong attack and normal health but weak defense. ");
            Console.Write("So, you’re claiming the FIRE POKEMON CHARMANDER?");
            Texts.Period();
            Console.WriteLine();

            Console.WriteLine("Please answer by number => 1 : YES / 2 : NO");
            Console.WriteLine();

            answer = Tools.newUserInput(2);
            Console.WriteLine();

            if (answer == 1)
            {

                myPokemon._type = type2;
                myPokemon._HP = 2;
                myPokemon._attack = 3;
                myPokemon._defense = 1;
                myPokemon._name.Add("Charmander");
                myPokemon._name.Add("Charmeleon");
                myPokemon._name.Add("Charizard");
            }
            Console.Clear();
            return myPokemon;
        }

        public Pokemon.Pokemon Squirtle(PokeType type3, ref int answer)
        {
            Pokemon.Pokemon myPokemon = new Pokemon.Pokemon();
            QuestGestion gestion = new QuestGestion();
            int userInput;
            Console.WriteLine();

            PokeAscii.ShowAscii("Squirtle");

            Console.Write("Hm! SQUIRTLE is your choice.");
            Texts.Period();
            Console.WriteLine();
            Console.WriteLine("It has strong defense and normal attack but weak health. ");
            Console.Write("So, you’ve decided on the WATER POKEMON SQUIRTLE? ");
            Texts.Period();
            Console.WriteLine();

            Console.WriteLine("Please answer by number => 1 : YES / 2 : NO");
            Console.WriteLine();

            answer = Tools.newUserInput(2);
            Console.WriteLine();

            if (answer == 1)
            {
                myPokemon._type = type3;
                myPokemon._HP = 1;
                myPokemon._attack = 2;
                myPokemon._defense = 3;
                myPokemon._name.Add("Squirtle");
                myPokemon._name.Add("Wartortle");
                myPokemon._name.Add("Blastoise");
            }
            Console.Clear();
            return myPokemon;
        }
    }
}
