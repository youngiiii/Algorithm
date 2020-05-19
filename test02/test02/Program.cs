using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test02
{
    class Program
    {
        static void Main(string[] args)
        {
            // #2. 1 ~ 10,000의 숫자 중 8이 등장하는 횟수 구하기 (Google)
            // 1부터 10,000까지 8이라는 숫자가 총 몇번 나오는가? 이를 구하는 함수를 완성하라.

            // 단, 8이 포함되어 있는 숫자의 갯수를 카운팅 하는 것이 아니라 8이라는 숫자를 모두 카운팅 해야 한다. 예를 들어 8808은 3, 8888은 4로 카운팅 해야 한다.
            var str = new List<char>();
            for (int i = 1; i <= 10000; i++)
            {
                for (int j = 0; j < i.ToString().Length; j++)
                {
                    if(i.ToString()[j].Equals('8'))
                    {
                        str.Add(i.ToString()[j]);
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            Console.WriteLine(str.Count());
        }
    }
}
