using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Practice
{
    class LINQ_Problems
    {

        public static void Problem2()
        {
            List<string> names = new List<string>() { "Mike", "Dan", "Scott", "Nick", "Mike" };
            // Return a copy without duplicates
            var noDupes = names.Select(n => n).Distinct();

            foreach(var item in noDupes)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }

    }
}
