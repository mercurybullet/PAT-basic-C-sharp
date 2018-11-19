using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1019 {
    class Program {
        static void Main(string[] args) {
            string input = Console.ReadLine();

            while (true) {
                char[] desc = input.ToCharArray().OrderByDescending(c => c - '0').ToArray();
                string descstring = new string(desc);
                int descnum = int.Parse(descstring);

                char[] asce = input.ToCharArray().OrderBy(c => c - '0').ToArray();
                string ascestring = new string(asce);
                int ascenum = int.Parse(ascestring);

                int result = descnum - ascenum;

                string resstring = result.ToString("D4");

                Console.WriteLine(descstring + " - " + ascestring + " = " + resstring);
                
                if (result == 6174 || result == 0) {
                    break;
                }

                input = resstring;
            }


        }
    }
}
