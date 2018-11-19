using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace _1004 {
    class Program {
        static void Main(string[] args) { Rank(); }

        //存储学生信息
        struct stu {
            public string no;
            public string name;
            public int score;
        }

        static void Rank() {
            string input = Console.ReadLine();
            int n = int.Parse(input);
            stu[] array = new stu[n];

            for (int i = 0; i < n; i++) {
                input = Console.ReadLine();
                string[] inputarray = input.Split(' ');

                stu stu = new stu();
                stu.name = inputarray[0];
                stu.no = inputarray[1];
                stu.score = int.Parse(inputarray[2]);
                array[i] = stu;
            }

            stu max = array[0];
            stu min = array[0];
            //遍历数组中的每个成员，取其成绩比较，将大的成绩赋给max,将最小的成绩赋值给min

            foreach (var item in array) {
                if (item.score > max.score) {
                    max = item;
                }
            }

            foreach (var item in array) {
                if (item.score < min.score) {
                    min = item;
                }
            }

            Console.WriteLine(max.name + " " + max.no);
            Console.WriteLine(min.name + " " + min.no);
        }
    }
}