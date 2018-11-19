using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1077 {
    class Program {
        static void Main(string[] args) {
            string[] input = Console.ReadLine().Split(' ');
            int[] inputarray = input.Select(int.Parse).ToArray();

            int n = inputarray[0];
            int top = inputarray[1];
            double score = 0;
            List<double> scorearray = new List<double>();

            for (int i = 0; i < n; i++) {
                input = Console.ReadLine().Split(' ');
                int[] numarray = input.Select(int.Parse).ToArray();

                int G2 = numarray[0];


                List<int> nums = new List<int>();
                for (int j = 1; j < n; j++) {
                    nums.Add(numarray[j]);
                }
                //每行数组numarray,把它转换为列表

                int max = 0;
                int min = inputarray[1];
                int count = 0;
                int sum = 0;

                var filtered = nums.Where(num => num >= 0 && num <= top);

                foreach (int num in filtered) {
                    count++;
                    sum += num;
                    if (num > max) {
                        max = num;
                    }

                    if (num < min) {
                        min = num;
                    }
                }
                
                sum -= max;
                sum -= min;

                double G1 = (double) sum / (count - 2);
                score = Math.Round(((G1 + G2) / 2), MidpointRounding.AwayFromZero);
                scorearray.Add(score);
            }


            for (int i = 0; i < n; i++) {
                Console.WriteLine(scorearray[i]);
            }
        }
    }
}