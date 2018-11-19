using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1061 {
    class Program {
        static void Main(string[] args) {
            string input = Console.ReadLine();
            string[] inputarray = input.Split(' ');
            int N = int.Parse(inputarray[0]);//学生人数，也就是行数
            int M = int.Parse(inputarray[1]);//题目数量，也就是列数

            string value = Console.ReadLine();
            string[] inputarray2 = value.Split(' ');//每题分值


            string trueanswer = Console.ReadLine();
            string[] inputarray3 = trueanswer.Split(' ');//正确答案

            for (int i = 0; i < N; i++) {
                string answer = Console.ReadLine();
                string[] inputarray4 = answer.Split(' ');//学生回答
                int score = 0;
                for (int j=0;j<M;j++) {
                    if (inputarray4[j]==inputarray3[j]) {
                        score += int.Parse(inputarray2[j]);
                    }
                }

                Console.WriteLine(score);
            }
          
        }
    }
}
