using System;
using System.Text;

namespace test22
{
    class Program
    {
        static void Main(string[] args)
        {
            //첫째 줄에 단어 S가 주어진다. 단어의 길이는 100을 넘지 않으며, 알파벳 소문자로만 이루어져 있다.
            string input = Console.ReadLine();
            string output = FindAlphabets(input);
            Console.WriteLine(output);
        }

        static string FindAlphabets(string someWord)
        {
            StringBuilder output = new StringBuilder();

            for (int i = 97; i < 123; i++)
            {
                char alphabet = Convert.ToChar(i);
                bool hasResult = false;
                bool isFirstAlphabet = false;

                for (int j = 0; j < someWord.Length; j++)
                {
                    if (someWord[j] == alphabet && !isFirstAlphabet)
                    {
                        isFirstAlphabet = true;
                        hasResult = true;
                        output.Append(j).Append(" ");
                    }
                }

                if (!hasResult)
                {
                    output.Append("-1").Append(" ");
                }
            }

            output.Remove(output.Length - 1, 1);

            return output.ToString();
        }
    }
}
