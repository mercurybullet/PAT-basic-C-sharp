using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1012 {
    class Program {
        static void Main(string[] args) {
            string input = Console.ReadLine();
            string[] inputarray = input.Split(' ');
            int[] numarray = inputarray.Select(int.Parse).ToArray();
            int A1 = 0;
            int A2 = 0;
            int A3 = 0;
            string A4 = "";
            string A5 = "";
            int count = 0;
            List<int> num = new List<int>();
            List<int> num2 = new List<int>();
            int sum3 = 0;
            float aver = 0;
            string output = "";


            bool flag2 = false;
            bool flag5 = false;
            // numarray[0]是N
            for (int i = 1; i < numarray.Length; i++) {
                //求A1
                if (numarray[i] % 10 == 0) {
                    A1 += numarray[i];
                }

                //求A2
                if (numarray[i] % 5 == 1) {
                    flag2 = true;
                    num.Add(numarray[i]);
                }

                //求A3
                if (numarray[i] % 5 == 2) {
                    A3++;
                }

                //求A4
                if (numarray[i] % 5 == 3) {
                    sum3 += numarray[i];
                    count++;
                }

                //求A5
                if (numarray[i] % 5 == 4) {
                    flag5 = true;
                    num2.Add(numarray[i]);
                }
            }

            for (int i = 0; i < num.Count; i++) {
                if (i % 2 == 0) {
                    A2 += num[i];
                }
                else {
                    A2 -= num[i];
                }
            }


            int max = 0;
            for (int j = 0; j < num2.Count; j++) {
                if (num2[j] > max) {
                    max = num2[j];
                }
            }

            if (count != 0) aver = (float) sum3 / count;

            string s1 = A1 == 0 ? "N" : A1.ToString();
            string s2 = flag2 ? A2.ToString() : "N";
            string s3 = A3 == 0 ? "N" : A3.ToString();
            string s4 = aver == 0 ? "N" : aver.ToString("F1");
            string s5 = flag5 ? max.ToString() : "N";


            output = s1 + " " + s2 + " " + s3 + " " + s4 + " " + s5;
            Console.WriteLine(output.Trim());
        }
    }
}