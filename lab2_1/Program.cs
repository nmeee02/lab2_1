using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //task1();
            //task2();
            //task3();
            //task4();
            task5();
        }
        static void task1()
        {
            int i = 10;
            while (i >= 1)
            {
                Console.WriteLine(i);
                i--;
            }
        }
        static void task2()
        {
            Console.WriteLine("Введите строку:");
            string str = Console.ReadLine();

            Console.WriteLine("Введите число N:");
            int number = Convert.ToInt32(Console.ReadLine());
            while (number > 0)
            {
                Console.WriteLine(str);
                number--;
            }
        }
       static void task3()
        {
            int a = 10;
            int b = 20;
            int row = 1;
            while (row <= a)
            {
                int column = 1;
                while (column<= b)
                {
                    Console.Write("R");
                    column++;
                }
                Console.WriteLine();
                row++;
            }
        }
        static void task4()
        {
            int w = 1;  
            while (w <= 10)
            {
                int v = 1;
                while (v <= 10)
                {
                    Console.Write((w * v) + " ");
                    v++;
                }
                Console.WriteLine();
                w++;
            }
        }
        static void task5()
        {
            for (int i = 100; i >= 1; i--)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}

