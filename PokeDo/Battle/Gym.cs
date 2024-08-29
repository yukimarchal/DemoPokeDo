using PokeDo.Pokemon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeDo.Battle
{
    [Serializable]
    internal class Gym
    {
        public int _gymNumber { get; set; }
        public string _gymName { get; set; }
        public string _gymLeader { get; set; }
        public Pokemon.Pokemon _pokemon { get; set; }
        public string _badgeName { get; set; }
        public Boolean isOwned { get; set; } = false;
        public Gym() { }
    }
}
