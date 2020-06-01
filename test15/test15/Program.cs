using System;
using System.Collections.Generic;
using System.Linq;

namespace test15
{
    class Program
    {
        static void Main(string[] args)
        {
            ////입력 : 150 266 427
            ////출력 : 0이 몇개인지 + 1~9가 몇개인지 순서대로 카운트값
            //
            ////값 입력
            //var num = new List<int>();
            //
            //for (int i = 0; i < 3; i++)
            //{
            //    num.Add(int.Parse(Console.ReadLine()));
            //}
            ////곱한값
            //int mul = 0;
            //for (int i = 0; i < num.Count; i++)
            //{
            //    mul = i == 0 ? num[i] : num[i] * mul;
            //}
            //
            ////0이 몇개인지 + 1~9가 몇개인지 순서대로 카운트값
            //
            ////0의 개수
            //int[] numCnt = new int[10];
            //for (int i = 0; i < mul.ToString().Length; i++)
            //{
            //    //0이 몇개인지 카운트
            //    numCnt[int.Parse(mul.ToString().Substring(i, 1))] += 1; 
            //}
            //
            ////출력
            //for (int i = 0; i < numCnt.Length; i++)
            //{
            //    Console.WriteLine(numCnt[i]);
            //}
            //Console.ReadLine();


            //두 자연수 A와 B가 있을 때, 
            //A% B는 A를 B로 나눈 나머지 이다.
            //예를 들어, 7, 14, 27, 38을 3으로 나눈 나머지는 1, 2, 0, 2이다.
            //수 10개를 입력받은 뒤, 
            //이를 42로 나눈 나머지를 구한다. 그 다음 서로 다른 값이 몇 개 있는지 출력하는 프로그램을 작성하시오.

            //입력 10개 입력
            //출력 42로 나눈 나머지에 서로 다른 나머지의 개수

            var num = new List<int>();

            for (int i = 0; i < 10; i++)
            {
                num.Add(int.Parse(Console.ReadLine()) % 42);
            }

            int result = 0;
            for (int i = 0; i < num.Count; i++)
            {
                bool check = false;
                for (int j = 0; j < i; j++)
                {
                    if (num[i] == num[j])
                    {
                        check = true;
                        break;
                    }
                }
                result = check ? result : result + 1;
            }
            Console.WriteLine(result);
        }
    }
}
