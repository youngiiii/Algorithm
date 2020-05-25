using System;
using System.Text;

namespace test06
{
    class Program
    {
        static void Main(string[] args)
        {
            //자연수 N이 주어졌을 때, 1부터 N까지 한 줄에 하나씩 출력하는 프로그램을 작성하시오.
            int num = int.Parse(Console.ReadLine());

            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < num; i++)
            {
                builder.Append((i + 1) + "\n");
            }
            Console.WriteLine(builder.ToString());

            //위 출력 역으로 찍기
            builder = new StringBuilder();
            for (int i = 0; i < num; i++)
            {
                builder.Append((num - i) + "\n");
            }
            Console.WriteLine(builder.ToString());
        }
    }
}
