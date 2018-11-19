using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1022 {
    class Program {
        static void Main(string[] args) {
            string input = Console.ReadLine();
            string[] numarray = input.Split(' ');
            long A = long.Parse(numarray[0]);
            long B = long.Parse(numarray[1]);
            int D = int.Parse(numarray[2]);
            long sum = A + B;

            StringBuilder sb = (Convert(sum, D));
            for (int i = sb.Length - 1; i >= 0; i--) {
               Console.Write(sb[i]);

            }

            Console.WriteLine();
        }

        public static StringBuilder Convert(long A, long D) {
            StringBuilder sb = new StringBuilder();
            while (A / D != 0) {
                sb.Append(A % D);
                A = A / D;
            }

            sb.Append(A % D);
            return sb;
         
        }
    }
}
