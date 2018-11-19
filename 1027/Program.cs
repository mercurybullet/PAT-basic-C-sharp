using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1027 {
    class Program {
        static void Main(string[] args) {
            string input = Console.ReadLine();
            string[] inputarray = input.Split(' ');
            int num = int.Parse(inputarray[0]);
            string star = inputarray[1];

            int i = 1;
            for (;; i++) {
                if (num < 2 * (i + 1) * (i + 1) - 1) {
                    break;
                }
            }

            for (int j = i; j > 0; j--) {
                for (int blank = i - j; blank > 0; blank--) {
                    Console.Write(" ");
                }

                for (int count = j * 2 - 1; count > 0; count--) {
                    Console.Write(star);
                }

                Console.WriteLine();
            }

            for (int j = 2; j <= i; j++) {
                for (int blank = i - j; blank > 0; blank--) {
                    Console.Write(" ");
                }

                for (int count = j * 2 - 1; count > 0; count--) {
                    Console.Write(star);
                }

                Console.WriteLine();
            }

            Console.WriteLine(num - (2 * i * i - 1));
        }
    }
}
