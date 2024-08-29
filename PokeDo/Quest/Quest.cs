using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeDo.Quest
{
    [Serializable]
    internal class Quest
    {
        public int _questNumber { get; set; }
        public string? _questName { get; set; } = "Undefined";
        public enum_difficulty _difficulty { get; set; } = enum_difficulty.undefined;
        public Boolean _isDone { get; set; } = true;

        public Quest() { }
        public Quest(int questNumber) 
        {
            _questNumber = questNumber;
        } 
    }
}
