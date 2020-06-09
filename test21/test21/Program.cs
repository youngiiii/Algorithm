using System;
using System.Diagnostics.CodeAnalysis;

namespace test21
{
    class Program
    {
        static void Main(string[] args)
        {
            //아스키 코드 출력
            //var b = Convert.ToChar(Console.ReadLine()); // char
            //int ascii = Convert.ToInt32(b); // Ascii 
            //Console.WriteLine(ascii);

            //A + B 출력
            int cnt = int.Parse(Console.ReadLine());
            var b = Console.ReadLine();

            int sum = 0;
            for (int i = 0; i < cnt; i++)
            {
                sum += int.Parse(b[i].ToString());
            }
            Console.WriteLine(sum);
        }
    }
}
