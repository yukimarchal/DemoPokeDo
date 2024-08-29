using PokeDo.Menu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeDo.Battle
{
    internal class GymGestion
    {
        public List<Gym> _gymList = new List<Gym>();

        public void ShowGyms()
        {
            for (int i = 0; i < _gymList.Count; i++)
            {
                if (_gymList[i].isOwned)
                {
                    Console.WriteLine($"{_gymList[i]._gymName}, {_gymList[i]._badgeName} : Owned");
                }
                else
                {
                    Console.WriteLine($"{_gymList[i]._gymName}, {_gymList[i]._badgeName} : Not owened");
                }
            }
        }

        public Boolean AccessGym(int gymNumberToChallenge)
        {
            Boolean isAccessible = false;
            if (gymNumberToChallenge == 1) // gymNumber starts from 1
            {
                return isAccessible = true;
            }
            else if (_gymList[gymNumberToChallenge -2].isOwned) // _gymList starts from 0
            {
                return isAccessible = true;
            }
            return isAccessible;
        }

        public Boolean Battle(Pokemon.Pokemon p1, Pokemon.Pokemon p2, int gymNumberToChallenge)
        {
            int battleHP_p1 = p1._HP;
            int battleHP_p2 = p2._HP;
            Boolean isWon = false;
            int damage;

            while (!(battleHP_p1 <= 0 || battleHP_p2 <= 0))
            {
                damage = CalcDamage(p1, p2);
                Console.WriteLine($"{p1._name[0]}'s attack!");
                Console.WriteLine($"{p2._name[0]}'s got {damage} damage!");
                battleHP_p2 -= damage;
                Console.WriteLine();
                Thread.Sleep(1000);

                if (!(battleHP_p1 <= 0 || battleHP_p2 <= 0))
                {
                    damage = CalcDamage(p2, p1);
                    Console.WriteLine($"{p2._name[0]}'s attack!");
                    Console.WriteLine($"{p1._name[0]}'s got {damage} damage!");
                    battleHP_p1 -= damage;
                    Console.WriteLine();
                    Thread.Sleep(1000);
                }
            }

            Console.WriteLine();
            Console.WriteLine();

            if (battleHP_p1 <= 0)
            {
                Console.Write("You have lost... Do more quests, get stronger and come back again!");
                Texts.Period();
                Console.ReadLine();
                Console.Clear();
            }
            else
            {
                Console.Write("Bravo! You won!");
                Texts.Period();
                Console.ReadLine();
                Console.Clear();

                _gymList[gymNumberToChallenge-1].isOwned = true; // _gymList starts from 0
                isWon = true;
            }
            return isWon;
        }

        public int CalcDamage(Pokemon.Pokemon p1, Pokemon.Pokemon p2)
        {
            Random rdm = new Random();
            int damage;

            if (p1._attack - p2._defense <= 0)
            {
                damage = 1;
            }
            else
            {
                damage = p1._attack - p2._defense;
            }

            if (p1._type._effective.Contains(p2._type._typeName))
            {
                damage = (int)(damage * (rdm.Next(150,200)/100M));
            }
            else if (p1._type._notEffective.Contains(p2._type._typeName))
            {
                damage = (int)(damage * (rdm.Next(50, 100) / 100M)) ;
            }
            
            //if(damage <= 0)
            //{
            //    damage = 1;
            //}

            return damage;
        }
    }
}
