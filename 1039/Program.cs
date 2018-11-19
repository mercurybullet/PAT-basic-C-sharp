using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1039 {
    class Program {
        static void Main(string[] args) {
            Dictionary<char,int> line=new Dictionary<char,int>();
            Dictionary<char,int> MYline=new Dictionary<char,int>();
            int more = 0;
            int less = 0;
            //一共有多少种珠子，每种珠子有多少个
            string input = Console.ReadLine();
            foreach (char c in input) {
                if (line.ContainsKey(c)) {
                    line[c] += 1;
                }
                else {
                    line.Add(c, 1);
                }
            }
            //需要多少种珠子、每种珠子需要多少个
            input = Console.ReadLine();
            foreach (var d in input) {
                if (MYline.ContainsKey(d)) {
                    MYline[d] += 1;
                }
                else {
                    MYline.Add(d,1);
                }
            }

            bool ok = true;

            foreach (char key in MYline.Keys) {
                if (line.ContainsKey(key)) {
                    if (MYline[key] > line[key]) {
                        ok = false;
                        less += (MYline[key] - line[key]);
                    }
                }
                else {
                    ok = false;
                    less += MYline[key];
                }
            }

            if (ok) {
                more = line.Values.Sum() - MYline.Values.Sum();//sum是求line中value的和
                Console.WriteLine("Yes " + more);
            }
            else {
                Console.WriteLine("No "+less);
            }
        }
    }
}
