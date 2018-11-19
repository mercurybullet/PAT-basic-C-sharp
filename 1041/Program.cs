using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1041 {
    class Program {
        static void Main(string[] args) {
            string input = Console.ReadLine();
            int n = int.Parse(input);
            var dict1 = new Dictionary<int, string>();//comnum、stunum
            var dict2 = new Dictionary<int, int>();//comnum、seatnum

            for (int i = 0; i < n; i++) {
                input = Console.ReadLine();
                string[] inputarray = input.Split(' ');

                string stunum = inputarray[0];
                int comnum = int.Parse(inputarray[1]);
                int seatnum = int.Parse(inputarray[2]);
                dict1.Add(comnum,stunum);
                dict2.Add(comnum,seatnum);
            }

            string input2 = Console.ReadLine();
            int m = int.Parse(input2);
            input2 = Console.ReadLine();
            string[] inputarry2 = input2.Split(' ');
            foreach (string s in inputarry2) {
                int num = int.Parse(s);//num是试机号
                Console.WriteLine(dict1[num]+" "+dict2[num]);
            }
        }
    }
}

