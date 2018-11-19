using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1043 {
    class Program {//考验数据处理的思路
        static void Main(string[] args) {
            string input = Console.ReadLine();
            string output = "";
            int P = 0;
            int A = 0;
            int T = 0;
            int e= 0;
            int s = 0;
            int t = 0;
            foreach (var item in input) {
                if (item.ToString() == "P") {
                   P+=1;
                }
                if (item.ToString() == "A") {
                   A += 1;
                }
                if (item .ToString()=="T") {
                    T += 1;
                }

                if (item.ToString() == "e") {
                    e += 1;
                }

                if (item.ToString() == "s") {
                    s += 1;
                }

                if (item.ToString() == "t") {
                    t += 1;
                }
            }

            while (P>0||A>0||T>0||e>0||s>0||t>0) {//当PTAest这些字符的个数大于0
                if (P > 0) {
                    output += "P";
                    P--;
                }

                if (A > 0) {
                    output += "A";
                    A--;
                }

                if (T > 0) {
                    output += "T";
                    T--;
                }
                if (e > 0) {
                    output += "e";
                    e--;
                }

                if (s > 0) {
                    output += "s";
                    s--;
                }

                if (t > 0) {
                    output += "t";
                    t--;
                }
            }
            Console.WriteLine(output);
        }
    }
}
