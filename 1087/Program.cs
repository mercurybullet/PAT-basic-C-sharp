using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _1087 {
    class Program {
        static void Main(string[] args) {
            string input = Console.ReadLine();
            int num = int.Parse(input);
            double n = Math.Pow(10, 4);

            HashSet<double> numarray = new HashSet<double>();

            for (int i = 1; i <= num; i++) {
                int sum = (i / 2) + (i / 3) + (i / 5);
                numarray.Add(sum);

            }
            int count = numarray.Count;
            Console.WriteLine(count);
        }
    }
}