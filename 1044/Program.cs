using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1044 {
    class Program {
        static void Main(string[] args) {
            string input = Console.ReadLine();
            int n = int.Parse(input);

            while (n-- > 0) {
                input = Console.ReadLine();

                int earth;
                bool success = int.TryParse(input, out earth); // 判断earth是string还是int，通过ref 或者out标记传送的参数，在函数体内进行修改，会反映到真实的参数上
                if (success) {
                    // translate to Mars

                    int remained = earth % 13;
                    int shang = earth / 13;
                    string output = "";
                    Dictionary<int, string> EtoM1 = new Dictionary<int, string>
                    {
                        {0, "tret"},
                        {1, "jan"},
                        {2, "feb"},
                        {3, "mar"},
                        {4, "apr"},
                        {5, "may"},
                        {6, "jun"},
                        {7, "jul"},
                        {8, "aug"},
                        {9, "sep"},
                        {10, "oct"},
                        {11, "nov"},
                        {12, "dec"}
                    };
                    Dictionary<int, string> EtoM2 = new Dictionary<int, string>
                    {
                        {1, "tam"},
                        {2, "hel"},
                        {3, "maa"},
                        {4, "huh"},
                        {5, "tou"},
                        {6, "kes"},
                        {7, "hei"},
                        {8, "elo"},
                        {9, "syy"},
                        {10, "lok"},
                        {11, "mer"},
                        {12, "jou"}
                    };
                    if (shang == 0) {
                        output = EtoM1[remained];
                    }
                    else {
                        if (remained == 0) {
                            output = EtoM2[shang];
                        }
                        else {
                            output = EtoM2[shang] + " " + EtoM1[remained];
                        }
                    }

                    Console.WriteLine(output);
                }
                else {
                    // input is Mars, translate to Earth

                    Dictionary<string, int> MtoE1 = new Dictionary<string, int>
                    {
                        {"tret", 0},
                        {"jan", 1},
                        {"feb", 2},
                        {"mar", 3},
                        {"apr", 4},
                        {"may", 5},
                        {"jun", 6},
                        {"jul", 7},
                        {"aug", 8},
                        {"sep", 9},
                        {"oct", 10},
                        {"nov", 11},
                        {"dec", 12},
                        {"tam", 13 * 1},
                        {"hel", 13 * 2},
                        {"maa", 13 * 3},
                        {"huh", 13 * 4},
                        {"tou", 13 * 5},
                        {"kes", 13 * 6},
                        {"hei", 13 * 7},
                        {"elo", 13 * 8},
                        {"syy", 13 * 9},
                        {"lok", 13 * 10},
                        {"mer", 13 * 11},
                        {"jou", 13 * 12}
                    };


                    string[] strArray = input.Split(' ').ToArray();
                    int num;
                    if (strArray.Length < 2) {
                        num = MtoE1[strArray[0]];
                    }
                    else {
                        num = MtoE1[strArray[0]] + MtoE1[strArray[1]];
                    }

                    Console.WriteLine(num);
                }
            }
        }
    }
}