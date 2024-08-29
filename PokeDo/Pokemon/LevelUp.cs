using PokeDo.Pokemon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PokeDo
{
    internal class LevelUp
    {
        public List<int> _levelTable = new List<int>();
        Random random = new Random();

        public int AddStatus(enum_strength strength)
        {
            if (strength == enum_strength.Weak)
            {
                return random.Next(1, 3);
            }
            else if (strength == enum_strength.Normal)
            {
                return random.Next(2, 4);
            }
            else if (strength == enum_strength.Strong)
            {
                return random.Next(3, 5);
            }
            return 0;
        }

        public void CreateLevelTable()
        {
            int temp = 0;
            _levelTable.Add(0);
            _levelTable.Add(0);
            for (int i = 2; i <= 100; i++)
            {
                temp += (i - 1) + 9;
                _levelTable.Add(temp);
                //Console.WriteLine($"level[{i}] : {_levelTable[i]}");
            }
        }
    }
}
