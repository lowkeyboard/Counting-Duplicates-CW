using System;
using System.Linq;

namespace CountingDuplicates
{
    class Program
    {

        public static int DuplicateCount(string str)
        {
            
            str.ToUpper();
            char[] charArr = str.ToCharArray();

            Array.Sort(charArr);


            string newStr = new string(charArr);
            newStr = newStr.ToLower();


            char[] charX = newStr.ToCharArray();

            Array.Sort(charX);


            string SnewStr = new string(charX);

            // this did not work out for some reason string pattern = @"[0-9a-z]+";    //@"(\w)\1";
            // so here is another way: 

            return SnewStr
                .GroupBy(x => x)
                .Count(x => x.Count() > 1);

        }


        static void Main(string[] args)
        {
            Console.WriteLine(DuplicateCount("Indivisibilities")); 

        }
    }
}
