using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1036 {
    class Program {
        static void Main(string[] args) {
            string input = Console.ReadLine();
            string[] inputarray = input.Split(' ');
            
            int N = int.Parse(inputarray[0]); //正方形的长度
            char C = char.Parse(inputarray[1]); //组成正方形的字符
            int n = N / 2 + N % 2;

            string Buffer = "";//第一行和最后一行
            string Buffer2 = C.ToString();//中间行

            if (N == 1) {
               Console.WriteLine(C);
                return;
            }

            for (int i = 0; i < N; i++) {
                Buffer += C;
            }//第一行与最后一行


            for (int i = 0; i <N-2 ; i++) {
                Buffer2 += ' ';
            }//中间的一行加空格
            Buffer2 = Buffer2 + C;


            Console.WriteLine(Buffer);
            for (int i = 0; i < n-2; i++) {
                Console.WriteLine(Buffer2);
            }//输入N行中间一行

            Console.WriteLine(Buffer);
            
        }
    }
}