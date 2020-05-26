using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test11
{
    class Program
    {
        static void Main(string[] args)
        {
            // 26부터 시작한다. 
            //2 + 6 = 8이다.새로운 수는 68이다. 
            //6 + 8 = 14이다.새로운 수는 84이다. 
            //8 + 4 = 12이다.새로운 수는 42이다. 
            //4 + 2 = 6이다.새로운 수는 26이다.

            // 위의 예는 4번만에 원래 수로 돌아올 수 있다. 따라서 26의 사이클의 길이는 4이다.
            // N이 주어졌을 때, N의 사이클의 길이를 구하는 프로그램을 작성하시오.
            string num = Console.ReadLine();
            string checkNum = "";
            int cnt = 0;
            while (num != checkNum)
            {
                if (cnt == 0 && num.Length > 1)
                {
                    checkNum = num;
                }
                else if (cnt == 0 && num.Length == 1)
                {
                    checkNum = "0" + num;
                    num = "0" + num;
                }
                string str1 = num.Substring(0, 1);
                string str2 = num.Substring(1, 1);
                int sum = int.Parse(str1) + int.Parse(str2);

                num = sum.ToString().Length > 1 ? int.Parse(str2) + sum.ToString().Substring(1, 1) : int.Parse(str2) + sum.ToString();

                cnt++;

                if (num == checkNum) break;
            }
            Console.WriteLine(cnt.ToString());
            Console.ReadLine();
        }
    }
}
