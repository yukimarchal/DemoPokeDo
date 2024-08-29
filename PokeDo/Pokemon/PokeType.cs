using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeDo.Pokemon
{
    internal class PokeType
    {
        public enum_type _typeName { get; set; }
        public enum_strength _strengthHP { get; set; }
        public enum_strength _strengthAttack { get; set; }
        public enum_strength _strengthDefense { get; set; }

        public List<enum_type> _effective = new List<enum_type>();
        public List<enum_type> _notEffective = new List<enum_type>();

    }
}
