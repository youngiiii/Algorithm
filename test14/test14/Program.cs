using System;
using System.Linq;

namespace test14
{
    class Program
    {
        static void Main(string[] args)
        {
            //첫째 줄에 주어진 정수 N개의 최솟값과 최댓값을 공백으로 구분해 출력한다.

            int cnt = int.Parse(Console.ReadLine());
            var num = Console.ReadLine().Split(" ").Select(s => int.Parse(s)).ToList();

            Console.WriteLine(num.Min() + " " + num.Max());
        }
    }
}
