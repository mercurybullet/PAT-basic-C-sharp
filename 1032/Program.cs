using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1032 { //字典中找出最大value的key
    class Program {
        static void Main(string[] args) {
            string input = Console.ReadLine();
            int n = int.Parse(input);
            Dictionary<int, int> grades = new Dictionary<int, int>();
            string output = "";

            for (int i = 0; i < n; i++) {
                string[] inputarray = Console.ReadLine().Split(' ');
                int[] numarray = inputarray.Select(int.Parse).ToArray();
                if (grades.ContainsKey(numarray[0])) {
                    grades[numarray[0]] += numarray[1];//grades的value加上读进来的值
                }
                else {
                    grades.Add(numarray[0], numarray[1]);
                }
            }

            var max = grades.OrderByDescending(pair => pair.Value).First();

            output = max.Key + " " + max.Value;
            Console.WriteLine(output);
        }
    }
}