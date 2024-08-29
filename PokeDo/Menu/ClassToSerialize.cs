using PokeDo.Battle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeDo.Menu
{

    [Serializable]
    internal class ClassToSerialize
    {
        public List<string> _name { get; set; }
        public int? _pass { get; set; }
        public Pokemon.Pokemon _myPokemon { get; set; }
        public List<Gym> _gymList { get; set; }
        public List<Quest.Quest> _questList { get; set; }
        public ClassToSerialize() { }

        public void ParameterToSerialize(int? pass, Pokemon.Pokemon myPokemon, List<string> name, List<Gym> gymList, List<Quest.Quest> questList)
        {
            _pass = pass;
            _myPokemon = myPokemon;
            _gymList = gymList;
            _questList = questList;
            _name = name;
        }

        public void ParameterToDeSerialize(ref int? pass, ref Pokemon.Pokemon myPokemon, ref List<string> name, ref List<Gym> gymList, ref List<Quest.Quest> questList)
        {
            pass = _pass;
            myPokemon = _myPokemon;
            gymList = _gymList;
            questList = _questList;

            foreach (var item in _name) 
            {
                name.Add(item);
            }

        }
    }
}
