using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Practice
{
    class LINQ_Problems
    {
        public static void Problem1()
        {
            List<string> words = new List<string>() { "the", "bike", "this", "it", "tenth", "mathematics" };
            var searchForSubstring = words.Where(w => w.Contains("th"));

            WriteList(searchForSubstring);
        }

        public static void Problem2()
        {
            List<string> names = new List<string>() { "Mike", "Dan", "Scott", "Nick", "Mike" };
            // Return a copy without duplicates
            var noDupes = names.Select(n => n).Distinct();

            WriteList(noDupes);
        }

        public static void Problem3()
        {

        }

        public static void Problem4()
        {
            string lameName = "Terrill";
            // output should be a string: "E1I1L2R2T1"
            var alphabeticallyOrdered = lameName.GroupBy(l => l).Select(l => char.ToUpper(l.Key)).OrderBy(l => l);

            var _alphabeticallyOrdered = lameName.GroupBy(x => x)
              .Where(g => g.Count() > 0)
              .Select(y => new { Element = y.Key, Counter = y.Count() }).ToList();

            WriteList(_alphabeticallyOrdered);
        }

        public static void WriteList<T>(IEnumerable<T> dataStructure)
        {
            foreach(T item in dataStructure)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey(false);
        }

    }
}
