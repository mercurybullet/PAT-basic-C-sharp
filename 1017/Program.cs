using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1017 {
    class Program {
        static void Main(string[] args) {
            string input = Console.ReadLine();
            string[] inputarray = input.Split(' ');
            string a = inputarray[0];
            string b = inputarray[1];
            int B = int.Parse(b);
            string Q = "";

            if (a.Length < 5) {
                int A = int.Parse(a);
                Console.WriteLine(A/B + " " + A%B);
                return;
            }


            int getnum = (a[0] - '0') * 10 + (a[1] - '0'); //取出来的数getnum
            Q += (getnum / B).ToString();
            int r = getnum % B;
            for (int i = 2; i < a.Length; i++) {
                getnum = r * 10 + (a[i] - '0');
                Q += (getnum / B).ToString();
                r = getnum % B;
            }

            int R = r;
            Console.WriteLine(Q + " " + R);
        }
    }
}