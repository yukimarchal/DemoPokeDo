using PokeDo.Menu;

namespace PokeDo.Pokemon
{
    [Serializable]
    internal class Pokemon
    {       
        public List<string> _name = new List<string>();
        public PokeType _type { get; set; }
        public int _HP { get; set; }
        public int _attack { get; set; }
        public int _defense { get; set; }
        public int _exp { get; set; }
        public int _level { get; set; } = 1;
        public int _expTillNextLevel { get; set; }
        public Pokemon() { }

        public string ChangeName()
        {
            string name;
            if (_exp >= 735)
            {
                name = _name[2];
            }
            else if (_exp >= 165)
            {
                name = _name[1];
            }
            else
            {
                name = _name[0];
            }

            PokeAscii.ShowAscii(name);

            return name;
        }
        public void ShowStatus()
        {
            string name = ChangeName();

            PokeAscii.ShowAscii(name);

            Console.WriteLine($"Name : {name}");
            Console.WriteLine();
            Console.WriteLine($"HP : {_HP}");
            Console.WriteLine();
            Console.WriteLine($"Attack : {_attack}");
            Console.WriteLine();
            Console.WriteLine($"Defense : {_defense}");
            Console.WriteLine();
            Console.WriteLine($"Level : {_level}");
            Console.WriteLine();
            Console.WriteLine($"EXP : {_exp}");
            Console.WriteLine();
            Console.WriteLine($"EXP until next level : {_expTillNextLevel}");
            Console.WriteLine();
        }
        public void CalcLevel (List<int> levelTable)
        {
            for (int i = levelTable.Count-1; i >= 0; i--)
            {
                if(_exp >= levelTable[i])
                {
                    _level = i;
                    _HP += this.AddStatus(this._type._strengthHP);
                    _attack += this.AddStatus(this._type._strengthAttack);
                    _defense += this.AddStatus(this._type._strengthDefense);
                    break;
                }
            }
        }
        public void CalcExpTillNextLevel ()
        {
            _expTillNextLevel = _levelTable[_level+1] - _exp;
        }

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
                temp += (i - 1) + 3;
                _levelTable.Add(temp);
                //Console.WriteLine($"level[{i}] : {_levelTable[i]}");
            }
        }
    }
}
