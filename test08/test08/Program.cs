using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test08
{
    class Program
    {
        static void Main(string[] args)
        {
            //입력 : 5
            //출력
            //*
            //**
            //***
            //****
            //*****
            int num = int.Parse(Console.ReadLine());

            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < num; i++)
            {
                for (int j = 0; j < (i + 1); j++)
                {
                    builder.Append("*");
                }
                builder.Append("\n");
            }
            Console.WriteLine(builder.ToString());

            //    *
            //   **
            //  ***
            // ****
            //*****
            //builder = new StringBuilder();
            //for (int i = 0; i < num; i++)
            //{
            //    for (int j = i; j < num - i; j++)
            //    {
            //        builder.Append(" ");
            //    }

            //    for (int j = 0; j < (i + 1); j++)
            //    {
            //        builder.Append("*");
            //    }
            //    builder.Append("\n");
            //}
            //Console.WriteLine(builder.ToString());
            //Console.ReadLine();
        }
    }
}
