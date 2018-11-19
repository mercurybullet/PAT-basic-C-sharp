using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1029 {
    class Program {
        static void Main(string[] args) {
            string input1 = Console.ReadLine();
            string input2 = Console.ReadLine();
            input1 = input1.ToUpper();
            input2 = input2.ToUpper();


            var set1 = new HashSet<char>(); //正确的输入
            var set2 = new HashSet<char>(); //残缺的输入
            var set3 = new HashSet<char>(); //输出

            foreach (var c2 in input2) {
                set2.Add(c2);
            }

            string output = "";
            foreach (var c1 in input1) {
                if (!set2.Contains(c1)) {
                    //剔除集合2与集合1重合的元素，剩下的是坏键
                    if (!set3.Contains(c1)) {
                        set3.Add(c1);
                        output += c1;
                    }
                }
            }

            Console.WriteLine(output);
        }
    }
}