using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW100319
{
    class Program
    {
        static void Main(string[] args)
        {
            RoundTable<Knight> knights = new RoundTable<Knight>();
            knights.Add(new Knight("Moshe", "Egypt", "Shmot"));
            knights.Add(new Knight("Yakov", "Egypt", "Shmot"));
            knights.Add(new Knight("Reuven", "Egypt", "Shmot"));
            knights.Add(new Knight("Yehoshua", "Egypt", "Shmot"));
            Console.WriteLine("!========================================!");
            foreach (Knight item in knights)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("!========================================!");
            Console.WriteLine(knights[3]);
            Console.WriteLine("!========================================!");
            knights.RemoveAt(6);
            foreach (Knight item in knights)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("!========================================!");
            Knight knight1 = new Knight("Yakov", "Egypt", "Shmot");
            knights.InsertAt(3, knight1);
            foreach (Knight item in knights)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("!========================================!");
            Console.WriteLine(knights.GetRounded(7));
            Console.WriteLine("!========================================!");
            knights.Clear();
            foreach (Knight item in knights)
            {
                Console.WriteLine(item);
            }
            RoundTable<Magician> Magicians = new RoundTable<Magician>();
            Magicians.Add(new Magician("Ester", "Egypt", "Malka"));
            Magicians.Add(new Magician("Haman", "Kush", "Kishkush"));
            Magicians.Add(new Magician("Harvona", "Egypt", "EtzGavoha"));
            Magicians.Add(new Magician("Mordechai", "Paras", "Dod"));
            Console.WriteLine(Magicians[2]);
            Console.WriteLine("!========================================!");
            foreach (Magician item in Magicians)
            {
                Console.WriteLine(item);
            }
            Magicians.RemoveAt(7);
            Console.WriteLine("!========================================!");
            foreach (Magician item in Magicians)
            {
                Console.WriteLine(item);
            }



            Console.ReadKey();
        }
    }
}
