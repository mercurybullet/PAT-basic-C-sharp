using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1018 {
    class Program {
        static void Main(string[] args) {
            string input = Console.ReadLine();
            int n = int.Parse(input);
            int count1 = 0; //甲赢乙输
            int count2 = 0; //甲输乙赢
            int count3 = 0; //平局
            int[] hand1 = new int[3];
            int[] hand2 = new int[3];
            for (int i = 0; i < n; i++) {
                input = Console.ReadLine();
                string[] numarray = input.Split(' ');
                //J=0，C=1,B=2
                if (numarray[0] == "J") {
                    if (numarray[1] == "J") {//用if而不是while，因为if只执行一次
                        count3++;
                    }

                    if (numarray[1] == "C") {
                        count2++;
                        hand2[1]+=1;
                    }

                    if (numarray[1] == "B") {
                        count1++;
                        hand1[0]+=1;
                    }
                }

                if (numarray[0] == "C") {
                   if (numarray[1] == "J") {
                        count1++;
                        hand1[1]+=1;
                    }

                    if (numarray[1] == "C") {
                        count3++;
                    }

                  if (numarray[1] == "B") {
                        count2++;
                        hand2[2]+=1;
                    }
                }

                if (numarray[0] == "B") {
                    if (numarray[1] == "J") {
                        count2++;
                        hand2[0]+=1;
                    }

                   if (numarray[1] == "C") {
                        count1++;
                        hand1[2]+=1;
                    }

                   if (numarray[1] == "B") {
                        count3++;
                    }
                }
            }
    
            string maxchar1 = "";
            string maxchar2 = "";
            Dictionary<int, char> han1 = new Dictionary<int, char> {{0, 'J'}, {1, 'C'}, {2, 'B'}};
            Dictionary<int, char> han2 = new Dictionary<int, char> {{0, 'J'}, {1, 'C'}, {2, 'B'}};
            int max1 = 0;
            for (int i = 0; i < 3; i++) {
               
                if (hand1[i] > max1) {
                    max1 = hand1[i];
                }

                maxchar1 = han1[max1].ToString();
            }

            int max2 = 0;

            for (int j = 0; j < 3; j++) {
              
                if (hand2[j] > max2) {
                    max2 = hand2[j];
                }
                maxchar2=han2[max2].ToString();
            }


            Console.WriteLine(count1 + " " + count3 + " " + count2);
            Console.WriteLine(count2 + " " + count3 + " " + count1);
            Console.WriteLine(maxchar1+" "+maxchar2);
        }
    }
}