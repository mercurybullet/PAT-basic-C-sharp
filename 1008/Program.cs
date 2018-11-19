using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1008 {
    class Program {
        static void Main(string[] args) {
            string input = Console.ReadLine();
            string[] numarray = input.Split(' ');
            int N = int.Parse(numarray[0]);
            int M = int.Parse(numarray[1]);
            input = Console.ReadLine();
            int[] numbers = input.Split(' ').Select(int.Parse).ToArray();

            string output = "";
            for (int i = N-M; i <= N - 1; i++) {
                output += numbers[i]+" ";
            }

            for (int i = 0; i <= N - M - 1; i++) {
                output += numbers[i] + " ";
            }

            output = output.Trim();
            Console.WriteLine(output);
        }
    }
}
