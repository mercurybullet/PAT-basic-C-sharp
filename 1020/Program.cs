using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1020 {
    class Program {
        static void Main(string[] args) {
            string input = Console.ReadLine();
            string[] numarray = input.Split(' ');
            float N = float.Parse(numarray[0]); //种类数，一共N种月饼
            float D = float.Parse(numarray[1]); //市场最大需求量
            float sum = 0;

            input = Console.ReadLine();
            string[] inputarray1 = input.Split(' ');
            float[] num = inputarray1.Select(float.Parse).ToArray(); //每种月饼个数组成的数组

            input = Console.ReadLine();
            string[] inputarray2 = input.Split(' ');
            float[] price = inputarray2.Select(float.Parse).ToArray(); //每种月饼的总售价

            while (D>0) {
                int max = 0;
                for (int i = 0; i < N; i++) {
                    if (price[i] / num[i] > price[max] / num[max]) {
                        max = i;
                    } //找出哪种价格月饼单价最高
                }

                if (num[max] < D) {
                    //如果单价最高的月饼库存比需求少
                    sum += price[max];
                    D -= num[max];
                    price[max] = 0;
                }
                else {
                    sum += price[max] * D / num[max];
                    D = 0;
                }
            }
           

            Console.WriteLine("{0:F2}",sum);
            return;
        }
    }
}