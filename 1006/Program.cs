using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _1006 {
    class Program {
        static void Main(string[] args) {
            output();  
        }
 
        static void output() {
            string outputB = "";
            string outputS = "";
            string outputN = "";
            //用abc表示百十个位的数字
            int a;
            int b;
            int c;
            string input = Console.ReadLine();
            int n = int.Parse(input);
            a = n / 100;
            b = (n / 10) % 10;
            c = n % 10;
            for (int i = 0; i < a; i++) {
                outputB += "B";
            }

            for (int i = 0; i < b; i++) {
                outputS += "S";
            }

            for (int i = 1; i <= c; i++) {
                    outputN += i.ToString();
                
            }

            Console.WriteLine(outputB+outputS+outputN);
        }
    }
}