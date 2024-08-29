using PokeDo.Pokemon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeDo.Declarations
{
    internal class TypeDeclarations
    {
        public PokeType grass()
        {
            PokeType grass = new PokeType();
            grass._typeName = enum_type.Grass;
            grass._strengthHP = enum_strength.Strong;
            grass._strengthAttack = enum_strength.Weak;
            grass._strengthDefense = enum_strength.Normal;
            grass._effective.Add(enum_type.Water);
            grass._effective.Add(enum_type.Ground);
            grass._effective.Add(enum_type.Rock);
            grass._notEffective.Add(enum_type.Fire);
            grass._notEffective.Add(enum_type.Grass);
            grass._notEffective.Add(enum_type.Poison);
            grass._notEffective.Add(enum_type.Flying);
            grass._notEffective.Add(enum_type.Bug);
            grass._notEffective.Add(enum_type.Dragon);
            return grass;
        }

        public PokeType fire()
        {
            PokeType fire = new PokeType();
            fire._typeName = enum_type.Fire;
            fire._strengthHP = enum_strength.Normal;
            fire._strengthAttack = enum_strength.Strong;
            fire._strengthDefense = enum_strength.Weak;
            fire._effective.Add(enum_type.Grass);
            fire._effective.Add(enum_type.Ice);
            fire._effective.Add(enum_type.Bug);
            fire._notEffective.Add(enum_type.Fire);
            fire._notEffective.Add(enum_type.Water);
            fire._notEffective.Add(enum_type.Rock);
            fire._notEffective.Add(enum_type.Dragon);
            return fire;
        }

        public PokeType water()
        {
            PokeType water = new PokeType();
            water._typeName = enum_type.Water;
            water._strengthHP = enum_strength.Weak;
            water._strengthAttack = enum_strength.Normal;
            water._strengthDefense = enum_strength.Strong;
            water._effective.Add(enum_type.Fire);
            water._effective.Add(enum_type.Ground);
            water._effective.Add(enum_type.Rock);
            water._notEffective.Add(enum_type.Water);
            water._notEffective.Add(enum_type.Grass);
            water._notEffective.Add(enum_type.Dragon);
            return water;
        }

        public PokeType rock()
        {
            PokeType rock = new PokeType();
            rock._typeName = enum_type.Rock;
            rock._effective.Add(enum_type.Fire);
            rock._effective.Add(enum_type.Fighting);
            rock._effective.Add(enum_type.Flying);
            rock._effective.Add(enum_type.Bug);
            rock._notEffective.Add(enum_type.Fighting);
            rock._notEffective.Add(enum_type.Ground);
            return rock;
        }
    }
}
