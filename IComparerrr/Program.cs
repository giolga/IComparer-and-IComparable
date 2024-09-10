using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IComparerrr
{

    class Cow : IComparable<Cow>
    {
        public string Name { get; set; }
        public int Weight { get; set; }
        static Random random = new Random();
        public Cow(string name)
        {
            Name = name;
            Weight = random.Next(500, 1000);
        }

        public int CompareTo(Cow other)
        {
            return Name.CompareTo(other.Name);
        }
    }
 
    class MyCowComparer : IComparer<Cow>
    {
        public int Compare(Cow left, Cow right)
        {
            //return left.Weight - right.Weight;
            if (left.Weight > right.Weight) return 1;
            if (left.Weight < right.Weight) return -1;
            return 0;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<int> myPartyAges = new List<int>() { 35, 39, 10, 42, 88, 42, 99};
            List<Cow> lis = new List<Cow>() {
                new Cow("Betsy"), new Cow("Georgy"), new Cow("Abby"),
                new Cow("Dough"), new Cow("Bacon"), new Cow("Beef")
            };
            lis.Sort(new MyCowComparer());
            lis.ForEach(c => { Console.WriteLine(c.Name + " " + c.Weight); });

            Console.WriteLine(lis[0].CompareTo(lis[1]));

            Console.ReadKey();
        }
    }
}
