using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1023 {
    class Program {
        static void Main(string[] args) {
            string input = Console.ReadLine();
            string[] inputarray = input.Split(' ');
            int[] num = new int[10];
            string output = "";

            for (int i = 0; i < inputarray.Length; i++) {
                num[i] = int.Parse(inputarray[i]);
            } //将表示数字个数的字符串转为数字

            for (int i = 0; i < 10; i++) {
                int x = num[i];
                for (int j = 0; j < x; j++) {
                    output += i.ToString();
                }
            }

            if (output[0] != '0') {
                Console.WriteLine(output);
                return;
            }
            else {
                int i = 0;
                while (output[i] == '0') i++;

                char[] chararray = output.ToCharArray();

                char temp;
                temp = chararray[0];
                chararray[0] = chararray[i];
                chararray[i] = temp;

                Console.WriteLine(new string(chararray));
            }
        }
    }
}