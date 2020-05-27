using System;
using System.Collections.Generic;

namespace test13
{
    class Program
    {
        static void Main(string[] args)
        {
            //세 정수 A, B, C가 주어진다. 이때, 두 번째로 큰 정수를 출력하는 프로그램
            //걍 푼거
            //var numLst = new int[3];
            //for (int i = 0; i < 3; i++)
            //{
            //    numLst[i] = int.Parse(Console.ReadLine());
            //    for (int j = 0; j < (i + 1); j++)
            //    {
            //        if (numLst[j] < numLst[i])
            //        {
            //            int temp = numLst[i];
            //            numLst[i] = numLst[j];
            //            numLst[j] = temp;
            //        }
            //    }
            //}
            //Console.WriteLine(numLst[1]);
            
            //Sort이용
            string[] s = Console.ReadLine().Split();
            List<int> list = new List<int>();

            foreach (var item in s)
            {
                list.Add(int.Parse(item));
            }

            list.Sort(delegate (int x, int y) {
                return (x > y) ? 1 : (x < y) ? -1 : 0;
            });

            Console.WriteLine(list[1]);
            Console.ReadLine();
        }
    }
}
