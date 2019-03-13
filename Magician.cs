using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW100319
{
    class Magician: IComparable<Magician>
    {
        public string Name { get; private set; }
        public string BirthTown { get; private set; }
        public string FavoriteSpell { get; private set; }

        public Magician(string name, string birthTown, string favoriteSpell)
        {
            Name = name;
            BirthTown = birthTown;
            FavoriteSpell = favoriteSpell;
        }

        public string this[string name]
        {
            get
            {
                switch (name)
                {
                    case "Name": return this.Name;
                    case "BirthTown": return this.BirthTown;
                    case "FavoriteSpell": return this.FavoriteSpell;
                    default: return "Unknown";
                }
            }            
        }

        public override string ToString()
        {
            return $"Magician Name: {Name,10}, Favorite Spell is: {FavoriteSpell,10}, BirthTwon: {BirthTown,10} .";
        }

        public int CompareTo(Magician other)
        {
            return this.Name.CompareTo(other.Name);
        }
    }
}
