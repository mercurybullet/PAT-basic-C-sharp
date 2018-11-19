using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1046 {
    class Program {
        static void Main(string[] args) {
            string input = Console.ReadLine();

            int n = int.Parse(input);
            int count1 = 0;
            int count2 = 0;

            for (int i = 0; i < n; i++) {
                input = Console.ReadLine();
                string[] inputarray = input.Split(' ');

                int[] numarray = inputarray.Select(int.Parse).ToArray();

                int sum = numarray[0] + numarray[2];


                if (sum == numarray[1] && sum != numarray[3]) {
                    count2++;
                }

                if (sum == numarray[3] && sum != numarray[1]) {
                    count1++;
                }
            }

            Console.WriteLine(count1 + " " + count2);
        }
    }
}