using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test10
{
    class Program
    {
        static void Main(string[] args)
        {
            ////두 정수 A와 B를 입력받은 다음, A+B를 출력하는 프로그램을 작성하시오.
            //string[] a = Console.ReadLine().Split(' ');
            //StringBuilder builder = new StringBuilder();
            //builder.Append((int.Parse(a[0]) + int.Parse(a[1])) + "\n");

            //while (a[0] != "0" || a[1] != "0")
            //{

            //    a = Console.ReadLine().Split(' ');
            //    if(a[0] == "0" || a[1] == "0")
            //    {
            //        break;
            //    }
            //    else
            //    {
            //        builder.Append((int.Parse(a[0]) + int.Parse(a[1])) + "\n");
            //    }
            //}
            //Console.WriteLine(builder.ToString());
            //Console.ReadLine();

            //두 정수 A와 B를 입력받은 다음, A+B를 출력하는 프로그램을 작성하시오.
            //int num = 0;
            var str = Console.ReadLine().Split(' ').Select(s => int.Parse(s)).ToList();
            StringBuilder builder = new StringBuilder();
            while (str.First() < 5)
            {
                //string[] a = Console.ReadLine().Split(' ');
                builder.Append((str[0] + str[1]) + "\n");
                str[0]++;
            }
            Console.WriteLine(builder.ToString());
        }
    }
}
