using System;
using System.Collections.Generic;
using System.Linq;

namespace test18
{
    class Program
    {
        static void Main(string[] args)
        {
            //대학생 새내기들의 90 % 는 자신이 반에서 평균은 넘는다고 생각한다.
            //당신은 그들에게 슬픈 진실을 알려줘야 한다.

            //입력 : 첫째 줄에는 테스트 케이스의 개수 C, 
            //       둘째 줄부터 각 테스트 케이스마다 학생의 수 
            //       이어서 N명의 점수가 주어진다.

            //출력 : 각 케이스마다 한 줄씩 평균을 넘는 학생들의 비율을 반올림하여 소수점 셋째 자리까지 출력한다.

            int cnt = int.Parse(Console.ReadLine());
            var goalLst = new List<List<int>>();
            for (int i = 0; i < cnt; i++)
            {
                var goal = Console.ReadLine().ToString().Split(" ").Select(s => int.Parse(s)).ToList();
                goal.RemoveAt(0);
                goalLst.Add(goal);
            }

            for (int i = 0; i < cnt; i++)
            {
                double avg = 0;
                for (int j = 0; j < goalLst[i].Count; j++)
                {
                    if(goalLst[i][j] > goalLst[i].Average())
                    {
                        avg += 1;
                    }
                }
                Console.WriteLine(string.Format("{0:f3}", (avg / goalLst[i].Count) * 100) + "%");
            }
        }
    }
}
