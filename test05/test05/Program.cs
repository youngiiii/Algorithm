using System;
using System.Text;

namespace test05
{
    class Program
    {
        static void Main(string[] args)
        {
            //StreamReader로 읽고, StringBuilder로 출력을 모아 놓았다가 그 String을 Console.WriteLine하는 방법이 있습니다. 
            //BufferedStream과 StringWriter로 조금 더 향상시킬 수 있는 것 같으나 자세한 것은 다른 분의 답변을 기다리겠습니다.

            int cnt = int.Parse(Console.ReadLine());

            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < cnt; i++)
            {
                string[] str = Console.ReadLine().Split(' ');
                builder.Append((int.Parse(str[0]) + int.Parse(str[1])).ToString() + "\n");
            }
            Console.WriteLine(builder.ToString());
            Console.ReadLine();
        }
    }
}
