using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace test07
{
    class Program
    {
        static void Main(string[] args)
        {
            //두 정수 A와 B를 입력받은 다음, A+B를 출력하는 프로그램을 작성하시오.
            int num = int.Parse(Console.ReadLine());

            var lst = new List<string>();
            for (int i = 0; i < num; i++)
            {
                lst.Add(Console.ReadLine());
            }

            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < num; i++)
            {
                string aa = "Case #" + (i + 1) + ": ";

                string[] str = lst[i].Split(' ');
                builder.Append(aa + (int.Parse(str[0]) + int.Parse(str[1])).ToString() + "\n");
            }
            Console.WriteLine(builder.ToString());

            builder = new StringBuilder();
            for (int i = 0; i < num; i++)
            {
                string[] str = lst[i].Split(' ');
                string aa = "Case #" + (i + 1) + ": " + str[0] + " + " + str[1] + " = ";
                builder.Append(aa + (int.Parse(str[0]) + int.Parse(str[1])).ToString() + "\n");
            }
            Console.WriteLine(builder.ToString());

        }
    }
}
