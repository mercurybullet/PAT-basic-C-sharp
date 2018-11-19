using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1070 {
    class Program {
        static void Main(string[] args) {
            string n = Console.ReadLine();
            int N = int.Parse(n); //得到数字个数n

            string input = Console.ReadLine();
            string[] inputarray = input.Split(' ');
            int[] numarray = inputarray.Select(int.Parse).ToArray();
            List<int> v = numarray.OrderBy(item => item).ToList(); //得到n个数字的升序数组

            int rope1 = v[0];
            int rope2;
            for (int i = 1; i < N; i++) {
                rope2 = v[i];
                var result = (rope1 + rope2) / 2;
                rope1 = result;
            }

            Console.WriteLine(rope1);
        }

    }
}