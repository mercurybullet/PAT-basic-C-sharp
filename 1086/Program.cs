using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1086 {
    class Program {
        static void Main(string[] args) {
            string[] input = Console.ReadLine().Split(' ');
            int A = int.Parse(input[0]);
            int B = int.Parse(input[1]);
            string sum = (A * B).ToString();
            List<char> mus = new List<char>();
            for (int i = sum.Length - 1; i >= 0; i--) {
                mus.Add(sum[i]);
            }

            Console.WriteLine(new string(mus.ToArray()));
        }
    }
}