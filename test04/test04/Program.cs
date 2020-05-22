using System;

namespace test04
{
    class Program
    {
        static void Main(string[] args)
        {
            //-----강아지 print-----
            //Console.WriteLine("|\\_/|");
            //Console.WriteLine("|q p|   /}");
            //Console.WriteLine("( 0 )"""\\");
            //Console.WriteLine("|"^"`    |");
            //Console.WriteLine("||_/=\\\\__|");

            //-----(+, -, *, /, %)-----
            //int a = int.Parse(Console.ReadLine());
            //int b = int.Parse(Console.ReadLine());
            //
            //Console.WriteLine(a+b);
            //Console.WriteLine(a-b);
            //Console.WriteLine(a*b);
            //Console.WriteLine(a/b);
            //Console.WriteLine(a%b);

            //-----출력문제-----

            //입력 5 8 4
            //첫째 줄에 (A+B)%C
            //둘째 줄에 ((A%C) + (B%C))%C
            //셋째 줄에 (A×B)%C
            //넷째 줄에 ((A%C) × (B%C))%C를 출력한다.
            //int A = int.Parse(Console.ReadLine());
            //int B = int.Parse(Console.ReadLine());
            //int C = int.Parse(Console.ReadLine());
            //Console.WriteLine((A+B)%C);
            //Console.WriteLine(((A%C) + (B%C))%C); 
            //Console.WriteLine((A*B)%C);
            //Console.WriteLine(((A%C) * (B%C))%C);

            //------문제--------
            //입력 472 385
            //출력 : 472 * 5
            //출력 : 472 * 8
            //출력 : 472 * 3
            //출력 : 472 * 385
            //int val = int.Parse(Console.ReadLine());
            //int val2 = int.Parse(Console.ReadLine());
            //    
            //int num = val2;
            //while (num != 0)
            //{
            //    int sum = num % 10;
            //    num /=  10;
            //    Console.WriteLine(val * sum);
            //}
            //Console.WriteLine(val * val2);

            //------두수 비교하기---------
            //int val = int.Parse(Console.ReadLine());
            //int val2 = int.Parse(Console.ReadLine());
            //
            //if(val > val2) Console.WriteLine(">");
            //else if(val < val2) Console.WriteLine("<");
            //else if(val == val2) Console.WriteLine("==");

            //------시험점수--------
            // 시험점수를 입력받아온다
            // 90 ~ 100점은 A
            // 80 ~ 89점은 B
            // 70 ~ 79점은 C
            // 60 ~ 69점은 D
            // 나머지 점수는 F를 출력
            //--------------------
            //int val = int.Parse(Console.ReadLine());
            //
            //if(90 <= val && val <= 100) Console.WriteLine("A");
            //else if(80 <= val && val < 90) Console.WriteLine("B");
            //else if(70 <= val && val < 80) Console.WriteLine("C");
            //else if(60 <= val && val < 70) Console.WriteLine("D");
            //else Console.WriteLine("F");


            //------윤년구하기--------
            //연도가 주어졌을 때, 윤년이면 1, 아니면 0을 출력
            //윤년은 연도가 4의 배수이면서
            //100의 배수가 아닐 때 또는 400의 배수일 때이다.
            //--------------------
            //int val = int.Parse(Console.ReadLine());
            //
            //int result = 0;
            //
            //if((val % 4) == 0)
            //{
            //	if((val%100) != 0 || (val%400) != 0) result = 1;
            //
            //}
            //Console.WriteLine(result);



            //------알람 45분 빨리 설정하기--------
            // H,M값을 입력받아온다
            // 출력 입력시간보다 45분 빠른 알람 시간을 출력한다
            //--------------------
            //int h = int.Parse(Console.ReadLine());
            //int m = int.Parse(Console.ReadLine());
            //
            //int numM = 45 - m;
            //if (0 < numM)
            //{
            //	if(h != 0)
            //	{
            //		h -= 1;
            //	}
            //	else
            //	{
            //		h = 23;
            //	}
            //    m = 60 - numM;
            //}
            //else if (numM <= 0)
            //{
            //    m -= 45;
            //}
            //Console.WriteLine(h.ToString() + " " + m.ToString());

            //------구구단--------
            // 입력 N값
            // 출력 N*1부터 N*9
            //--------------------
            //int num = int.Parse(Console.ReadLine());
            //
            //for(int i = 1; i < 10; i++)
            //{
            //	Console.WriteLine(num +" * "+ i + " = " + (num * i));
            //}

            //------A+B 출력--------
            // 입력 두 정수 A와 B (첫째 줄에 테스트 케이스의 개수 T가 주어진다.)
            // 출력  A+B를 출력
            //--------------------
            //int t = sc.nextInt();
            //
            //int[][] num = new int[t][2]; //int 타입 배열 선언
            //for(int i = 0; i < t; i++)
            //{
            //	for(int j = 0; j < 2; j++)
            //	{
            //		num[i][j] = int.Parse(Console.ReadLine());
            //	}
            //	Console.WriteLine(num[i][0] + num[i][1]);
            //}

            //------주어진 n의 1~n까지의 합 구하기--------
            // n이 주어졌을 때, 1부터 n까지 합을 구하는 프로그램을 작성하시오.
            //--------------------------------------
            int num = int.Parse(Console.ReadLine());
            int result = 0;
            for(int i = 0; i < num; i++)
            {
                result += (i+1);
            }
            Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}
