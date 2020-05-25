using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test09
{
    class Program
    {
        static void Main(string[] args)
        {
            // X보다 작은 수를 입력받은 순서대로 공백으로 구분해 출력한다. 
            // X보다 작은 수는 적어도 하나 존재한다.
            string num = Console.ReadLine();
            string[] n = num.Split(' ');

            string numLst = Console.ReadLine();
            string[] lst = numLst.Split(' ');

            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < lst.Count(); i++)
            {
                if(int.Parse(lst[i]) < int.Parse(n[1]))
                {
                    builder.Append(lst[i] + " ");
                }
            }
            Console.WriteLine(builder.ToString());
            Console.ReadLine();
        }
    }
}
