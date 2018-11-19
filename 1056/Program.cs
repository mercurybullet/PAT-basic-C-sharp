using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1056 {
    class Program {
        static void Main(string[] args) {
            string input = Console.ReadLine();
            input = Console.ReadLine();
            string[] inputarray = input.Split(' ');
            int[] numarray = inputarray.Select(int.Parse).ToArray();
            int sum = 0;
            for (int i = 0; i < numarray.Length; i++) {
                int shiwei = numarray[i];
                for (int j = 0; j < numarray.Length; j++) {
                    if (j == i) {
                        continue;
                    }

                    int gewei = numarray[j];
                    int num = shiwei * 10 + gewei;
                    sum += num;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
