using PokeDo.Pokemon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using PokeDo.Menu;

namespace PokeDo.Quest
{
    internal class QuestGestion
    {
        public List<Quest> _questList = new List<Quest>();
        public int? _pass = null;

        public QuestGestion()
        {
            for (int i = 1; i <= 10; i++)
            {
                _questList.Add(new Quest(i));
            }
        }

        public void SetPass()
        {
            do
            {
                Console.WriteLine("Before starting, please set your passcode between 1000-9999");
                Console.WriteLine();

                int.TryParse(Console.ReadLine(), out int temp);

                if (temp >= 1000 && temp <= 9999)
                {
                    _pass = temp;
                    Console.Clear();
                    
                }
                else
                {
                    Console.WriteLine("Invalid passcode");
                    Thread.Sleep(2000);
                    Console.Clear();
                }
            } while (_pass == null);
        }

        public Boolean CheckPass()
        {
            int userInput = -1;
            Boolean isChecked = false;
            for (int i = 0; i < 3; i++)
            {
                Console.Clear();
                Console.WriteLine("Please enter your passcode of 4 numbers");
                Console.WriteLine();

                isChecked = int.TryParse(Console.ReadLine(), out userInput);
                Console.WriteLine();

                if (userInput >= 1000 && userInput <= 9999)
                {
                    Console.WriteLine("Passcode is checked");
                    Thread.Sleep(1000);
                    Console.Clear();
                    return isChecked;
                }
                else
                {
                    isChecked = false;
                    Console.WriteLine($"Invalid number. Please select by numbers between 1000-9999");
                    Thread.Sleep(1000);
                    Console.Clear();
                }
            }
            Console.WriteLine("You have already tried 3 times. Going back to the menu");
            Thread.Sleep(1000);
            Console.Clear();
            return isChecked;
        }

        public void ShowQuest()
        {
            for (int i = 0; i < _questList.Count; i++)
            {
                Console.WriteLine($"Quest No.{_questList[i]._questNumber} : Name = {_questList[i]._questName}  Difficulty = [{_questList[i]._difficulty}]");
                Console.WriteLine();
                Console.WriteLine();
            }
        }

        public void ChangeQuest(Pokemon.Pokemon p1)
        {
            Console.WriteLine("Which quest do you want to change?");
            Console.WriteLine();
            Console.WriteLine("Please select by quest number");
            Console.WriteLine();

            int questNumberInput = Tools.newUserInput(10);
            Console.Clear();


            for (int i = 0; i < _questList.Count; i++)
            {
                if (questNumberInput == _questList[i]._questNumber)
                {
                    Console.WriteLine("What do you want to change?");
                    Console.WriteLine();
                    Console.WriteLine("Please select the number");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("1 : Quest name and difficulty");
                    Console.WriteLine();
                    Console.WriteLine("2 : Quest status");
                    Console.WriteLine();

                    int userInput = Tools.newUserInput(2);
                    Console.Clear();

                    switch (userInput)
                    {
                        case 1:
                            EnterQuestName(i);

                            SelectDifficulty(i);

                            break;
                        case 2:
                            FinishQuest(i, p1);
                            break;
                    }
                }
            }
        }

        public void EnterQuestName (int questNumber)
        {
            Console.WriteLine("Please enter the new quest name");
            Console.WriteLine();

            _questList[questNumber]._questName = Console.ReadLine();

            Console.Clear();    
        }

        public void SelectDifficulty(int questNumber)
        {
            Console.WriteLine("Please enter the new difficulty by number");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("1 : Easy");
            Console.WriteLine();
            Console.WriteLine("2 : Normal");
            Console.WriteLine();
            Console.WriteLine("3 : Difficult");
            Console.WriteLine();

            int userInput = userInput = Tools.newUserInput(3);

            switch (userInput)
            {
                case 1:
                    _questList[questNumber]._difficulty = enum_difficulty.easy;

                    break;
                case 2:
                    _questList[questNumber]._difficulty = enum_difficulty.normal;

                    break;
                case 3:
                    _questList[questNumber]._difficulty = enum_difficulty.difficult;
                    break;
            }

            Console.Clear();
        }

        public void FinishQuest(int questNumber, Pokemon.Pokemon myPokemon)
        {
            Console.WriteLine("Is the quest done?");
            Console.WriteLine();
            Console.WriteLine("Please answer by number => 1 : YES / 2 : NO");
            Console.WriteLine();
            Console.WriteLine();

            int userInput = Tools.newUserInput(2);
            Console.WriteLine();

            switch (userInput)
            {
                case 1:
                    _questList[questNumber]._isDone = true;
                    AddExp(myPokemon, _questList[questNumber]._difficulty);
                    _questList[questNumber]._questName = "Undefined";
                    _questList[questNumber]._difficulty = enum_difficulty.undefined;

                    myPokemon.CalcLevel(myPokemon._levelTable);
                    myPokemon.CalcExpTillNextLevel();
                    myPokemon.ShowStatus();
                    Console.WriteLine();

                    break;
                case 2:
                    Console.WriteLine("OK! Good Luck!");

                    break;
            }
        }

        public void AddExp(Pokemon.Pokemon pokemon, enum_difficulty difficulty)
        {
            Random random = new Random();
            if (difficulty == enum_difficulty.easy)
            {
                pokemon._exp += random.Next(1, 3);
            }
            else if (difficulty == enum_difficulty.normal)
            {
                pokemon._exp += random.Next(2, 4);
            }
            else if (difficulty == enum_difficulty.difficult)
            {
                pokemon._exp += random.Next(3, 5);
            }
        }

        //public Quest? this[int questNumber]
        //{
        //    get
        //    {
        //        //foreach (Quest quest in _questList)
        //        //{
        //        //    if (quest._questNumber == questNumber)
        //        //        return quest;
        //        //}
        //        //throw new Exception();
        //        return _questList.SingleOrDefault(quest => quest._questNumber == questNumber);
        //    }
        //}
    }
}
