using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _1021 {
    class Program {
        static void Main(string[] args) {
            string input = Console.ReadLine();
            int[] stat = new int[10];//一个包含了0-9数字的数组,初始每个元素都为0
            foreach (char c in input) {
                int num = c - '0';//将字符转化为整数，方便加入数组中
                stat[num]++;//假如num是9，那么stat[9]=stat[9]+1，第九个元素0+1=1，表示9这个数出现了1次
            }

            for (int i = 0; i < 10; i++) {
                if (stat[i] != 0) {//数组不为0
                    Console.WriteLine(i + ":" + stat[i]);
                }
            }

        }
        }
    }

