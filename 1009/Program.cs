using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1009 {
    class Program {
        static void Main(string[] args) {
            string input = Console.ReadLine();
            //分割字符串成数组
            string[] inputarray = input.Split(' ');
            //准备输出的字符串
            string output = "";
            //遍历字符数组，倒序输出
            for (int i = inputarray.Length - 1; i >= 0; i--) {
                output =output+ inputarray[i]+" ";
            }

            output = output.Trim();
            Console.WriteLine(output);
        }
      
    }
}