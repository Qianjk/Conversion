using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("现在的调：");
            string before = Console.ReadLine();
            //Console.WriteLine(now);
            Console.Write("需要转换成：");
            string after = Console.ReadLine();
            //Console.WriteLine(after);
            string[] a = { "g", "#g", "a", "#a", "b", "c", "#c", "d", "#d", "e", "f", "#f" };
            double[] a1 = { -1.5, -1, -0.5, 0, 0.5, 1, 1.5, 2, 2.5, 3, 3.5, 4 };

            int i = 0;
            for (i = 0; i < 12; i++)
            {
                if (a[i] == before) break;
            }
            double number_before = a1[i];
            //Console.WriteLine(number_a);

            for (i = 0; i < 12; i++)
            {
                if (a[i] == after) break;
            }
            double number_after = a1[i];
            //Console.WriteLine(number_after);
            double minus = number_after - number_before;//相差多少

            string[] b = { "(1)", "(#1)", "(2)", "(#2)", "(3)", "(4)", "(#4)", "(5)", "(#5)", "(6)", "(#6)", "(7)", "1", "#1", "2", "#2", "3", "4", "#4", "5", "#5", "6", "#6", "7", "[1]", "[#1]", "[2]", "[#2]", "[3]", "[4]", "[#4]", "[5]", "[#5]", "[6]", "[#6]", "[7]", "[#7]" };
            double[] b1 = { -5, -4.5, -4, -3.5, -3, -2.5, -2, -1.5, -1, -0.5, 0, 0.5, 1, 1.5, 2, 2.5, 3, 3.5, 4, 4.5, 5, 5.5, 6, 6.5, 7, 7.5, 8, 8.5, 9, 9.5, 10, 10.5, 11, 11.5, 12, 12.5, 13 };
            //Console.WriteLine(b.Length);
            //Console.WriteLine(b1.Length);
            while (true)
            {
                Console.WriteLine("数字表示，低八度用(),高八度用[]。例如(5) 5 [5]。\n输入你要转换的音符，相邻两个以空格隔开：");
                string str = Console.ReadLine();   //str字符串存放待转换的旋律
                string[] array = str.Split(' ');   //array数组存放每一个音符
                Console.WriteLine("转换后的结果为：");

                for (i = 0; i < array.Length; i++)
                {
                    if (array[i] == Convert.ToString(0)) Console.Write("0"+" ");
                    else
                    {
                        int j;
                        for (j = 0; j < b.Length; j++)
                        {
                            if (b[j] == array[i]) break;
                        }
                        double x = b1[j] + minus;
                        for (j = 0; j < b1.Length; j++)
                        {
                            if (b1[j] == x) break;
                        }
                        Console.Write(b[j] + " ");
                    }
                }
                Console.WriteLine("\n");
            }
            Console.WriteLine();

        }
    }
}
