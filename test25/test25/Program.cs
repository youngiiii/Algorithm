using System;
using System.Collections.Generic;

namespace test25
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = 14;//int.Parse(Console.ReadLine());

            List<int> up = new List<int>();
            List<int> dn = new List<int>();

            for (int i = 1; i < num; i++)
            {
                int tmp = 1;
                if (i % 2 == 1) //홀수인 경우(분자)
                {
                    //1
                    //1,2,3,2,1
                    for (int j = 1; j < (i * 2); j++)
                    {
                        if (i > tmp)
                        {
                            up.Add(tmp++);
                        }
                        else if (i == tmp)
                        {
                            up.Add(tmp);
                            tmp--;
                        }
                        else if (i < tmp)
                        {
                            up.Add(tmp--);
                        }
                    }
                }
                else //짝수인 경우(분모)
                {
                    //1
                    //1,2,3,2,1
                    for (int j = 1; j < (i * 2); j++)
                    {
                        if (i > tmp)
                        {
                            dn.Add(tmp++);
                        }
                        else if(i == tmp)
                        {
                            dn.Add(tmp);
                            tmp--;
                        }
                        else if (i < tmp)
                        {
                            dn.Add(tmp--);
                        }   
                    }
                }
            }
        }
    }
}
