using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1016 {
    class Program {
        static void Main(string[] args) {
            int A;
            char DA;
            int PA;
            int B;
            char DB;
            int PB;
            int sum;
            string input = Console.ReadLine();
            string[] inputarray = input.Split(' ');
            A = int.Parse(inputarray[0]); 
            DA = char.Parse(inputarray[1]);
            B = int.Parse(inputarray[2]);
            DB = char.Parse(inputarray[3]);
            string outputA = "0";//假如在数中找不到DA、DB，就让值为0
            string outputB = "0";
            foreach (var item1 in A.ToString()) {
                if (item1 == DA) {                    
                    outputA += item1;
                }              
            }
            foreach (var item2 in B.ToString()) {
                if (item2 == DB) {
                    outputB += item2;
                }
            }

            PA = int.Parse(outputA);
            PB = int.Parse(outputB);
            sum = PA + PB;
            Console.WriteLine(sum);
        }
    }
}
