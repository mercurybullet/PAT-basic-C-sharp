using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1002 {
    class Program {
        static void Main(string[] args) {
            Dictionary<char, string> pinyin = new Dictionary<char, string>()
            {
                {'0', "ling"},
                {'1', "yi"},
                {'2', "er"},
                {'3', "san"},
                {'4', "si"},
                {'5', "wu"},
                {'6', "liu"},
                {'7', "qi"},
                {'8', "ba"},
                {'9', "jiu"}
            };
            string input = Console.ReadLine();
            int sum = 0;
            foreach (var item in input) {
                int num = int.Parse(item.ToString());
                sum += num;
            }

            string s = sum.ToString();
            string buffer = "";
            foreach (char item in s) {
                buffer+=pinyin[item] + " ";

            }

            buffer = buffer.Trim();
            Console.WriteLine(buffer);
        }
    }
}