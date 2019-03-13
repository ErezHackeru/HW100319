using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW100319
{
    class Knight : IComparable<Knight>
    {
        public string Name { get; private set; }
        public string BirthTown { get; private set; }
        public string Title { get; private set; }

        public string this[string name]
        {
            get
            {
                switch (name)
                {
                    case "Name": return this.Name;
                    case "BirthTown": return this.BirthTown;
                    case "Title": return this.Title;
                    default: return "Unknown";
                }
                    
            }
        }

        public Knight(string name, string birthTown, string title)
        {
            Name = name;
            BirthTown = birthTown;
            Title = title;
        }

        public override string ToString()
        {
            return $"Knight Name: {Name,10}, Title: {Title,10}, BirthTwon: {BirthTown,10} .";
        }

        public int CompareTo(Knight other)
        {
            return this.Name.CompareTo(other.Name);
        }
    }
}
