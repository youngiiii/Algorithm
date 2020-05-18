using System;

namespace test01
{
    class Program
    {
        //문제
        //상근이는 요즘 설탕공장에서 설탕을 배달하고 있다.상근이는 지금 사탕가게에 설탕을 정확하게 N킬로그램을 배달해야 한다.
        //설탕공장에서 만드는 설탕은 봉지에 담겨져 있다. 봉지는 3킬로그램 봉지와 5킬로그램 /봉/지가 있다.
        //
        //상근이는 귀찮기 때문에, 최대한 적은 봉지를 들고 가려고 한다. 예를 들어, 18킬로그램 설탕을 배달해야 할 때, 
        //3킬로그램 봉지 6개를 가져가도 되지만, 5킬로그램 3개와 3킬로그램 1개를 배달하면, 더 적은 개/수/의 봉지를 배달할 수 있다.
        //상근이가 설탕을 정확하게 N킬로그램 배달해야 할 때, 봉지 몇 개를 가져가면 되는지 그 수를 구하는 프로그램을 작성하시오.

        //입력
        //첫째 줄에 N이 주어진다. (3 ≤ N ≤ 5000)

        //출력
        //상근이가 배달하는 봉지의 최소 개수를 출력한다. 만약, 정확하게 N킬로그램을 만들 수 없다면 -1을 출력한다.

        // 후기 
        // 출력은 맞게 나오는데 왜 틀렸다고 하는지 이해가 되지 않는다 ※ 다시 확인해보기 ※

        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double result = 0;
            if (3 <= a && a <= 5000)
            {
                if (a > 5)
                {
                    double b = System.Math.Truncate(a / 5);
                    double bb = a - (b * 5);
                    if (bb % 3 == 0)
                    {
                        result = b + System.Math.Truncate(bb / 3);
                    }
                    else
                    {
                        bb = (a - ((b - 1) * 5)) % 3;
                        if (bb == 0)
                        {
                            result = System.Math.Truncate((a - ((b - 1) * 5)) / 3) + (b - 1);
                        }
                        else
                        {
                            result = -1;
                        }
                    }
                }
                else
                {
                    double b = System.Math.Truncate(a / 3);
                    double bb = a - (b * 3);
                    if (bb % 5 == 0)
                    {
                        result = b + bb;
                    }
                    else
                    {
                        bb = (a - ((b - 1) * 3)) % 5;
                        if (bb == 0)
                        {
                            result = System.Math.Truncate((a - ((b - 1) * 3)) / 5) + (b - 1);
                        }
                        else
                        {
                            result = -1;
                        }
                    }
                }
                Console.WriteLine(result.ToString());
                Console.ReadLine();
            }
        }
    }
}
