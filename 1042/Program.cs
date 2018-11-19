using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1042 {
    class Program {
        static void Main(string[] args) {
            int[] alpha = new int[26];
            int max = 0;
            string maxchar = "";
            string input = Console.ReadLine();
            input = input.ToLower();
            foreach (var item in input) {
                int index = item - 'a';
                if (index >= 0 && index <= 25) {
                    alpha[index] += 1;
                }
            }

            for (int i = 0; i < 26; i++) {
                if (alpha[i] > max) {
                    max = alpha[i];
                    maxchar = ((char) (i + 'a')).ToString();
                }
            }

            Console.WriteLine(maxchar + " " + max);
        }
    }
}