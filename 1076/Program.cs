using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1076 {
    class Program {
        static void Main(string[] args) {
            string input = Console.ReadLine();
            int n = int.Parse(input);

            Dictionary<string, string> Pwd = new Dictionary<string, string>
            {
                {"A", "1"},
                {"C", "3"},
                {"B", "2"},
                {"D", "4"}
            };

            string PW = "";
            for (int i = 0; i < n; i++) {
                input = Console.ReadLine();
                string[] inputarray = input.Split(' '); //每行用空格分开


                for (int j = 0; j < 4; j++) {
                    string[] ansarray = inputarray[j].Split('-');//将题号和答案分开
                    if (ansarray.Contains("T")) {
                        PW += ansarray[0];
                    }
                }
            }
            //22-35行是一个求PW的多少的过程
            string password = "";
            foreach (var item in PW) {
                password += Pwd[item.ToString()];
            }

            Console.WriteLine(password);
        }
    }
}