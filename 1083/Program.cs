using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _1083 {
    class Program {
        static void Main(string[] args) {
            string input = Console.ReadLine();
            int n = int.Parse(input);

            input = Console.ReadLine();
            string[] inputarray = input.Split(' ');
            int[] numarray = inputarray.Select(int.Parse).ToArray();

            Dictionary<int,int> Alist = new Dictionary<int, int>();

            for (int i = 0; i < n; i++) {
                int a = Math.Abs(numarray[i] - (i+1));//i的值比第i个数的值少1
                if (Alist.ContainsKey(a)) {
                    Alist[a]++;
                }
                else {
                    Alist.Add(a,1);
                }
            }

            IEnumerable<KeyValuePair<int, int>> order = Alist.OrderByDescending(pair => pair.Key);//题目要求从大到小输出，因此把得到的Alist按照key的值排序
            foreach (var pair in order) {//Ienumerable只能用foreach遍历
                if(pair.Value==1)continue;
                else {
                    Console.WriteLine(pair.Key+" "+pair.Value);
                }
            }

        }
    }
}