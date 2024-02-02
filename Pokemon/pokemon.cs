using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    public class pokemon
    {
        protected int id;
        protected string name;
        protected Image pic;
        protected int level;
        protected pokemonType type;
        protected pokemonAbilities abilities;
        protected int Hp;
        protected int Att;
        protected int Def;
        protected int SAtt;
        protected int SDef;
        protected int Speed;

        public string Name()
        {
            return name;
        }
        public Image Picture()
        {
            return pic;
        }
    }
    public enum pokemonType
    {
        Grass, Poison, Electr, Normal, Fairy, Psychic
    }
    public enum pokemonAbilities
    {
        Overgrow, chlorophyll, Cute_Charm, Competitive, Frisk, Immunity, Thick_Fat, Gluttony, Run_Away, Pickup, Volt_Absorb, Natural_Cure
    }
}
