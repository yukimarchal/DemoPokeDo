using PokeDo.Battle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeDo.Declarations
{
    internal class GymDeclarations
    {
        public Gym Pewter(Pokemon.Pokemon p1)
        {
            Gym pewter = new Gym();
            pewter._gymNumber = 1; // _gymList starts from 0
            pewter._gymName = "Pewter gym";
            pewter._gymLeader = "Brock";
            pewter._pokemon = p1;
            pewter._badgeName = "Boulder badge";
            return pewter;
        }

    }
}
