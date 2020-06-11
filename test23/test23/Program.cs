using System;

namespace test23
{
    class Program
    {
        static void Main(string[] args)
        {
            int cnt = int.Parse(Console.ReadLine());
            string result = "";
            for (int i = 0; i < cnt; i++)
            {
                var input = Console.ReadLine().Split(" ");

                for (int j = 0; j < input[1].Length; j++)
                {
                    for (int k = 0; k < int.Parse(input[0]); k++)
                    {
                        result += input[1].Substring(j, 1);
                    }
                }
                result += "\n";
            }
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
