using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1084 {
    class Program {
        static void Main(string[] args) {
            string input = Console.ReadLine();
            string[] inputarray = input.Split(' ');
            string d = inputarray[0];
            int N = int.Parse(inputarray[1]);

            for (int i = 0; i < N-1; i++) {
                d = getNum(d);
            }
            Console.WriteLine(d);
        }

        static string getNum(string d) {
            StringBuilder temp = new StringBuilder();
            char prev = d[0];
            int count = 1;
            for (int i = 1; i < d.Length; i++) {
                char current = d[i];
                if (current == prev) {
                    count++;
                }
                else {                   
                    temp.Append(prev);
                    temp.Append(count);//输出已经结束计数的数字出现的次数和数字本身
                    prev=current;
                    count = 1;
                }
            }

            temp.Append(prev);
            temp.Append(count);
            return temp.ToString();
        }
    }
}