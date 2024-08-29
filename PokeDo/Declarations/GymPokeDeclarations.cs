using PokeDo.Pokemon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeDo.Declarations
{
    internal class GymPokeDeclarations
    {
        public Pokemon.Pokemon Geodude(PokeType type)
        {
            Pokemon.Pokemon geodude = new Pokemon.Pokemon();
            geodude._type = type;
            geodude._HP = 24;
            geodude._attack = 24;
            geodude._defense = 24;
            geodude._name.Add("Geodude");
            return geodude;
        }
    }
}
