using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1026 {
    class Program {
        static void Main(string[] args) {
            string input = Console.ReadLine();
            string[] inputarray = input.Split(' ');
            int C1 = int.Parse(inputarray[0]);
            int C2 = int.Parse(inputarray[1]);
            int time = (C2 - C1) / 100;
            int remain = (C2 - C1) % 100;
            int h = time / 3600;
            int f = time%3600 / 60;
            int s = time % 60;
            if (remain >= 50) {
                s += 1;
            }
            
            Console.WriteLine("{0:D2}:{1:D2}:{2:D2}", h, f, s);
        }
    }
}
