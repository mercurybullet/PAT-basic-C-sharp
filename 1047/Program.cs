using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//字典的用法
namespace _1047 {
    class Program {
        static void Main(string[] args) {
            string input = Console.ReadLine();
            int n = int.Parse(input);

            var dict = new Dictionary<int,int>();

            int maxTeam = -1;
            int maxScore = -1;

            for(int i = 0; i < n;i++) {
                input = Console.ReadLine();

                string[] inputarray1 = input.Split(' '); //成绩与编号分开
                string[] inputarray2 = inputarray1[0].Split('-'); //将队伍编号与队员编号分开

                int score = int.Parse(inputarray1[1]);
                int team = int.Parse(inputarray2[0]);

                if (dict.ContainsKey(team)) {
                    dict[team] += score;
                }
                else {
                    dict.Add(team,score);
                }

                if (dict[team] > maxScore) {
                    maxTeam = team;
                    maxScore = dict[team];
                }
            }


            Console.WriteLine(maxTeam+" "+maxScore);


        }
    }
}
