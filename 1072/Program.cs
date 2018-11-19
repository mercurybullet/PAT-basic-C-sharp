using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1072 {
    class Program {
        static void Main(string[] args) {
            string[] input = Console.ReadLine().Split(' ');
            int n = int.Parse(input[0]); //学生人数

            string[] str = Console.ReadLine().Split(' '); //违禁物品编号

            HashSet<string> things = new HashSet<string>(str); //违禁物品列表

            int banthings = 0;
            int banstu = 0;

            for (int i = 0; i < n; i++) {
                string[] input2 = Console.ReadLine().Split(' '); //学生一行信息
                string name = input2[0]; //学生姓名
                List<string> forbi = new List<string>(); //用来学生物品中的装违禁物品
                for (int j = 1; j < input2.Length; j++) {
                    string item = input2[j]; //学生物品的表示
                    if (things.Contains(item)) {
                        forbi.Add(item); //找出学生物品中的违禁物品,存进forbi列表里
                    }
                }

                if (forbi.Count > 0) {
                    banstu += 1; //每次检查一个学生，检查出违禁物品就把学生数加1
                    banthings += forbi.Count; //算出违禁学生数和违禁物品数

                    var sb = new StringBuilder();
                    sb.Append(name);
                    sb.Append(": ");
                    foreach (var item in forbi) {
                        sb.Append(item);
                        sb.Append(' ');
                    }

                    Console.WriteLine(sb.ToString().Trim()); //姓名缩写，物品编号
                }
            }

            Console.WriteLine(banstu + " " + banthings); //
        }
    }
}