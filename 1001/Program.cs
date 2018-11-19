using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1001 {
    class Program {
        static void Main(string[] args) {
            string input = Console.ReadLine();            
            int n = int.Parse(input);
            int count = 0;
            while (n!=1) {
                if (n % 2 == 0) {
                    n = n / 2;
                    count++;
                }
                else {
                    n = (3 * n + 1) / 2;
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
