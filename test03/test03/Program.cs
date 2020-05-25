using System;
using System.Collections.Generic;
using System.Linq;

namespace test03
{
    class Program
    {
        static void Main(string[] args)
        {
            //----------------------------------------------------------------
            //첫째 줄에 카드의 개수 N(3 ≤ N ≤ 100)과 
            //M(10 ≤ M ≤ 300,000)이 주어진다. 
            //둘째 줄에는 카드에 쓰여 있는 수가 주어지며, 이 값은 100,000을 넘지 않는다.
            //합이 M을 넘지 않는 카드 3장을 찾을 수 있는 경우만 입력으로 주어진다.
            //----------------------------------------------------------------
            // 입력 5 21
            //      5 6 7 8 9
            // 출력 21
            //----------------------------------------------------------------
            // 입력 10 500
            //      93 181 245 214 315 36 185 138 216 295
            // 출력 497
            //----------------------------------------------------------------
            
            int cardCnt = int.Parse(Console.ReadLine());//카드 개수
            int valuee = int.Parse(Console.ReadLine());//넘어가지 마시오! 

            //뽑을 카드
            var valueLst = new List<int>();
       
            for (int i = 0; i < cardCnt; i++)
            {
                valueLst.Add(int.Parse(Console.ReadLine()));
            }

            //3개씩 더한거 모두 구하기
            var sum = new List<int>();//임시값 저장

            for(int i = 0; i < cardCnt; i++)
            {
                for (int j = (i + 1); j < cardCnt; j++)
                {
                    for (int k = (j + 1); k < cardCnt; k++)
                    {
                        sum.Add(valuee - (valueLst[i] + valueLst[j] + valueLst[k]));
                    }
                }
            }

            //결과
            int tmp = sum.First();
            int result = 0;
            for (int i = 1; i < sum.Count; i++)
            {
                if (sum[i] < 0 || tmp < 0)//마이너스면 패쓰
                {
                    tmp = tmp < 0 ? sum[i] : tmp;
                }
                else if (sum[i] == 0)//0 이면 바로 출력
                {
                    result = valuee;
                    break;
                }
                else
                {
                    tmp = tmp >= sum[i] ? sum[i] : tmp;
                }

                if ((sum.Count - 1) == i) result = (valuee - tmp);
            }
            Console.Write(result);
        }
    }
}
