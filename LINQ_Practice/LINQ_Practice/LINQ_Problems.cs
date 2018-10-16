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
            var noDupes = names.Distinct();

            WriteList(noDupes);
        }

        public static void Problem3()
        {
            List<string> classGrades = new List<string>()
            {
                "80,100,92,89,65",
                "93,81,78,84,69",
                "73,88,83,99,64",
                "98,100,66,74,55"
            };

            
            foreach(string studentsGrades in classGrades)
            {
                var listOfInts = studentsGrades.Split(',').Select(Int32.Parse).ToList();
                WriteList(listOfInts);
            }

            //WriteList();
        }

        public static void Problem4()
        {
            string lameName = "Terrill";
            // output should be a string: "E1I1L2R2T1"
            var alphabeticallyOrdered = lameName.Select(l => char.ToUpper(l)).OrderBy(l => l).Distinct();

            //This is the sollution being used for the moment
            var _alphabeticallyOrdered = lameName.GroupBy(x => x).Where(g => g.Count() > 0).Select(y => new { Element = Char.ToUpper(y.Key), Counter = y.Count() }).OrderBy(l => l.Element);
            foreach(var item in _alphabeticallyOrdered)
            {
                Console.Write(item.Element);
                Console.Write(item.Counter);
            }
            Console.ReadKey();

            var __alphabeticallyOrdered = lameName.ToCharArray().OrderBy(c => c).GroupBy(c => char.ToUpper(c)).Select(c => char.ToUpper(c.Key));

            //WriteList(_alphabeticallyOrdered);
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
