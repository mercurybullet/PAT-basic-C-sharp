using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1011 {
    class Program {
        static void Main(string[] args) {
            long A;
            long B;
            long C;

            string input = Console.ReadLine();
            int n = int.Parse(input);//n表示总共有几行字符串
            for (int i = 0; i < n; i++) { //for循环里处理的是一行的数据，i+1表示正在处理的这一行
                input = Console.ReadLine();
                string[] inputarray = input.Split(' '); //将input分割装入inputarray
                A = long.Parse(inputarray[0]); //将inputarray的值赋给A、B、C
                B = long.Parse(inputarray[1]);
                C = long.Parse(inputarray[2]);
                if (A + B > C) {
                    Console.WriteLine("Case #" + (i+1) + ": true");
                }
                else {
                    Console.WriteLine("Case #" + (i+1) + ": false");
                }
            }


           
        }
    }
}