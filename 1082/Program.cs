using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1082 {
    class Program {
        static void Main(string[] args) {
            string input = Console.ReadLine();
            int n = int.Parse(input);

            Dictionary<string, double> points = new Dictionary<string, double>();
            double point = 0;


            for (int i = 0; i < n; i++) {
                input = Console.ReadLine();
                string[] inputarray = input.Split(' ');
                string ID = inputarray[0];

                double[] numarray = inputarray.Select(double.Parse).ToArray();
                point = Math.Sqrt(Math.Pow(numarray[1], 2) + Math.Pow(numarray[2], 2));
                points.Add(ID, point);
            }

            double max = 0;
            string max_id = "";
            foreach (var item in points) {
                if (item.Value > max) {
                    max = item.Value;
                    max_id = item.Key;
                }
            }

            double min = 10000;
            string min_id = "";
            foreach (var item in points) {
                if (item.Value < min) {
                    min = item.Value;
                    min_id = item.Key;
                }
            }

            Console.WriteLine(min_id + " " + max_id);
        }
    }
}