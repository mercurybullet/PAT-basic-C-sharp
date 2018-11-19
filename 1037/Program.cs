using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1037 {
    class Program {
        static void Main(string[] args) {
            string input = Console.ReadLine();
            string[] inputarray = input.Split(' ');
            string[] P = inputarray[0].Split('.');
            string[] A = inputarray[1].Split('.');
            int K1 = int.Parse(P[2]);
            int S1 = int.Parse(P[1]);
            int G1 = int.Parse(P[0]);

            int K2 = int.Parse(A[2]);
            int S2 = int.Parse(A[1]);
            int G2 = int.Parse(A[0]);

            int Pall = K1 + S1 * 29 + G1 * 29 * 17;
            int Aall = K2 + S2 * 29 + G2 * 29 * 17;
            int m = Aall - Pall;

            string prefix = "";
            if (m < 0) {
                m = (-m);
                prefix = "-";
            }

            int mg = m / (29 * 17);
            int ms = m % (29 * 17) / 29;
            int mk = m % 29;

            Console.WriteLine(prefix + mg + "." + ms + "." + mk);
        }
    }
}
