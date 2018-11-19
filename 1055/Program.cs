using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1055 {
    class Program {
        class Person {
            public string Name;
            public int Height;
        }

        static void Main(string[] args) {
            string input = Console.ReadLine();
            string[] inputarray = input.Split(' ');
            int n = int.Parse(inputarray[0]);
            int k = int.Parse(inputarray[1]);

            #region 获取输入

            var list = new List<Person>();

            for (int i = 0; i < n; i++) {
                input = Console.ReadLine();
                inputarray = input.Split(' ');
                var man = new Person();
                man.Name = inputarray[0];
                man.Height = int.Parse(inputarray[1]);
                list.Add(man);
            }

            #endregion

            #region 排序

            var ordered = list.OrderByDescending(p => p.Height).ThenBy(p => p.Name);

            var queue = new Queue<Person>(ordered); // ABCDEFG

            #endregion

            #region 处理最后一排

            var linklist = new LinkedList<Person>();

            for (int i = 0; i < n / k + n % k; i++) {
                if (i % 2 == 0) {
                    linklist.AddLast(queue.Dequeue());
                }
                else {
                    linklist.AddFirst(queue.Dequeue());
                }
            }

            StringBuilder output = new StringBuilder();
            foreach (var item in linklist) {
                output.Append(item.Name);
                output.Append(' ');
            }

            output.Remove(output.Length - 1, 1);
            Console.WriteLine(output.ToString());

            #endregion

            #region 处理其他排

            for (int j = 0; j < k - 1; j++) {
                linklist.Clear();

                for (int i = 0; i < n / k; i++) {
                    if (i % 2 == 0) {
                        linklist.AddLast(queue.Dequeue());
                    }
                    else {
                        linklist.AddFirst(queue.Dequeue());
                    }
                }

                output.Clear();
                foreach (var item in linklist) {
                    output.Append(item.Name);
                    output.Append(' ');
                }

                output.Remove(output.Length - 1, 1);
                Console.WriteLine(output.ToString());
            }

            #endregion
        }
    }
}