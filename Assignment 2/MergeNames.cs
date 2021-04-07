using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
namespace MergeNamesAssignment
{
    public static class MergeNames
    {
        public static string[] UniqueNames(string[] names1, string[] names2)
        {
            //Produces the union of two sequences by using the default equality comparer.    
            IEnumerable<string> combined = names2.Union(names1);

            foreach (var str in combined)
            {
                Console.WriteLine(str);
            }

            Console.WriteLine("\n######################## Linq way ####################");

            //remove duplicates using Linq    

            var result = names1.Concat(names2).GroupBy(s => s).Select(x => x.First()).ToList();
            result.Sort();
            foreach (var str in result)
            {
                Console.WriteLine(str);
            }
            Console.ReadKey();
        }
        public static void Main()
        {
            string[] names1 = new string[] { "Ava", "Emma", "Olivia" };

            string[] names2 = new string[] { "Olivia", "Sophia", "Emma" };

            UniqueNames(names1, names2);
        }
    }
}

