using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1063 {
    class Program {
        static void Main(string[] args) {
            string input = Console.ReadLine();
            int n = int.Parse(input);//由第一行的字符串转换为数字，得到行数

            double max = 0;
            for (int i = 0; i < n; i++) {                
                input = Console.ReadLine();
                string[] inputarray = input.Split(' ');
                double[] numarray = inputarray.Select(double.Parse).ToArray();
                double M = Math.Sqrt(Math.Pow(numarray[0], 2)+Math.Pow(numarray[1],2));              
                if (M > max) {
                    max = M;
                }             
            }
            //循环结束之后找到了最大的数max，然后只需要输出一次这个max就可以了
            Console.WriteLine("{0:F2}", max);
        }
    }
}
