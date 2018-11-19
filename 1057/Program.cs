using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1057 {
    class Program {
        static void Main(string[] args) {
            string input = Console.ReadLine();

            int sum = 0;
            foreach (char c in input) {
                if (c >= 'a' && c <= 'z') {
                    sum += (c - 'a' + 1);
                }
                else if (c >= 'A' && c <= 'Z') {
                    sum += (c - 'A' + 1);
                }
            }

            string output = "";

            while (sum >= 1) {
                output += sum % 2;
                sum = sum / 2;
            }

            int count1 = 0; //0的个数

            foreach (var c in output) {
                if (c != '1') {
                    count1++;
                }
            }

            int count2 = output.Length - count1; //1的个数
            Console.WriteLine(count1 + " " + count2);
        }
    }
}