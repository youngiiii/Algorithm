using System;

namespace test32
{
    class Program
    {
        static void Main(string[] args)
        {
            //위의 그림과 같이 육각형으로 이루어진 벌집이 있다.
            //그림에서 보는 바와 같이 중앙의 방 1부터 시작해서 이웃하는 방에 돌아가면서 
            //1씩 증가하는 번호를 주소로 매길 수 있다.
            //숫자 N이 주어졌을 때, 벌집의 중앙 1에서 N번 방까지 최소 개수의 방을 지나서 갈 때 
            //몇 개의 방을 지나가는지(시작과 끝을 포함하여)를 계산하는 프로그램을 작성하시오. 
            //예를 들면, 13까지는 3개, 58까지는 5개를 지난다.
            {
                // 입력 수
                int input = int.Parse(Console.ReadLine());

                // 계산에 필요한 변수
                int cnt = 1; // 몇겹인지 = 최소 칸수
                long range = 1; // 숫자의 범위 ex) 2~7, 8~19
                long temp = 1; // 6의 배수를 더하기 위해서 사용

                while (true)
                {
                    if (range >= input) // 범위가 커지면 정지
                    {
                        break;
                    }
                    temp = 6 * cnt++; // 6씩 증가되는 벌집 크기를 위해 temp에 저장
                    range += temp; // 그 temp 값을 범위에 넣어서 input 값과 비교함
                }
                Console.WriteLine(cnt);
            }
        }
    }
}
