using System;
using System.Collections.Generic;

namespace test20
{
    class Program
    {
        static void Main(string[] args)
        {
            //문제
            //어떤 양의 정수 X의 각 자리가 등차수열을 이룬다면, 그 수를 한수라고 한다. 
            //등차수열은 연속된 두 개의 수의 차이가 일정한 수열을 말한다.
            //한수의 개수를 출력하는 프로그램을 작성하시오. 

            //입력 : 자연수 N이 주어진다.
            //출력 : 첫째 줄에 1보다 크거나 같고, N보다 작거나 같은 한수의 개수를 출력한다.

            Program pg = new Program();

            //값을 입력받는다.
            int num = int.Parse(Console.ReadLine());

            if (num < 100) //99이하의 수는 모두 한수이다.
            {
                Console.WriteLine(num);
            }
            else //99이상인 것 중에서 한수의 개수를 구해온다.
            {
                int cnt = 99; // 한수 개수 count
                for (int i = 100; i < num + 1; i++)
                {
                    cnt = pg.CheckNum(i) ? cnt + 1 : cnt;
                }
                Console.WriteLine(cnt);
                Console.ReadLine();
            }

        }

        /// <summary>
        /// 한수 Check 함수
        /// </summary>
        /// <param name="i_num"></param>
        /// <returns></returns>
        private bool CheckNum(int i_num)
        {
            //각 자리수의 차수 구하기
            var subLst = new List<int>();
            for (int i = 1; i < i_num.ToString().Length; i++)
            {
                int num1 = int.Parse(i_num.ToString().Substring(i - 1, 1));
                int num2 = int.Parse(i_num.ToString().Substring(i, 1));
                subLst.Add(num2 - num1);
            }

            //각 자리수의 차수가 다른 경우 Check
            bool check = true;
            for (int i = 1; i < subLst.Count; i++)
            {
                if (subLst[i - 1] != subLst[i]) check = false;
            }
            return check;
        }
    }
}
