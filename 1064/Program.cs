using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1064 {
    class Program {
        static void Main(string[] args) {
            string input = Console.ReadLine();
            int n = int.Parse(input);
            input = Console.ReadLine();
            string[] inputarray = input.Split(' ');
            int[] numarray = inputarray.Select(int.Parse).ToArray();
            HashSet<int> set = new HashSet<int>();//hashset里的元素是互不重复的，不会重复加入元素
            for (int i = 0; i < n; i++) {
                set.Add(numarray[i] / 1000 + (numarray[i] % 1000) / 100 + (numarray[i] % 100 / 10) + (numarray[i] % 10));
            }
            Console.WriteLine(set.Count);//输出不重复数的个数

            var ordered=set.OrderBy(item => item);//将数组从小到大排序
            string output = "";
            foreach (var item in ordered) {
                output += item+" ";
            }

            Console.WriteLine(output.Trim());
        }
    }
}