using System;
using System.Collections.Generic;

namespace test25
{
    class Program
    {
        static void Main(string[] args)
        {
            Program pg = new Program();
            var num = int.Parse(Console.ReadLine());

            List<int> up = new List<int>(); //분자
            List<int> dn = new List<int>(); //분모

            for (int i = 1; i < num; i++)
            {
                if (i % 2 == 1) //홀수인 경우(분자)
                {
                    pg.AddList(i, up);
                }
                else //짝수인 경우(분모)
                {
                    pg.AddList(i, dn);
                }
                if (num < up.Count && num < dn.Count)
                {
                    break;
                }
            }
            //결과 출력
            Console.WriteLine(up[num -1] + "/" + dn[num - 1]);
        }

        private void AddList(int i, List<int> lst)
        {
            int tmp = 1;

            for (int j = 1; j < (i * 2); j++)
            {
                if (i > j)
                {
                    lst.Add(tmp++);
                }
                else if (i == j)
                {
                    lst.Add(tmp);
                    tmp--;
                }
                else if (i < j)
                {
                    lst.Add(tmp--);
                }
            }
        }
    }
}
