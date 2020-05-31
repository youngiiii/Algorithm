using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace test14
{
    class Program
    {
        static void Main(string[] args)
        {
            //첫째 줄에 주어진 정수 N개의 최솟값과 최댓값을 공백으로 구분해 출력한다.

            //int cnt = int.Parse(Console.ReadLine());
            //var num = Console.ReadLine().Split(" ").Select(s => int.Parse(s)).ToList();

            //Console.WriteLine(num.Min() + " " + num.Max());

            //9개 정수를 입력받아 최솟값과 최댓값을 출력한다.
            var lst = new List<int>();
            for (int i = 0; i < 9; i++)
            {
                lst.Add(int.Parse(Console.ReadLine()));
            }

            int cnt = 0;
            for (int i = 0; i < lst.Count; i++)
            {
                if (lst[i] == lst.Max())
                {
                    cnt = i + 1;
                }
            }
            Console.WriteLine(lst.Max() + "\n" + cnt);
            Console.ReadLine();
        }
    }
}
