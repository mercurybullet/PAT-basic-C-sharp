using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1038 {
    class Program {
        static void Main(string[] args) {
            string input = Console.ReadLine();
            int n = int.Parse(input);

            input = Console.ReadLine();
            string[] inputarray1 = input.Split(' ');
            int[] numarray = inputarray1.Select(int.Parse).ToArray();
            Dictionary<int, int> grades = new Dictionary<int, int>();
            for (int i = 0; i < n; i++) {
                if (grades.ContainsKey(numarray[i])) {
                    grades[numarray[i]] += 1;
                }
                else {
                    grades.Add(numarray[i], 1);
                }
            }

            input = Console.ReadLine();
            string[] inputarray2 = input.Split(' ');
            int m = int.Parse(inputarray2[0]);
            int[] numarray2 = inputarray2.Skip(1).Select(int.Parse).ToArray();

            StringBuilder output = new StringBuilder();
            for (int i = 0; i < m; i++) {
                if (grades.ContainsKey(numarray2[i])) {
                    output.Append(grades[numarray2[i]] + " ");
                }
                else {
                    output.Append("0 ");
                }
            }
            Console.WriteLine(output.ToString().Trim());
        }
    }
}