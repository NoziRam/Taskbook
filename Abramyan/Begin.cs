﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abramyan
{
     public static class Begin
    {

        public static void Get()
        {
            // Begin-1 Дана сторона квадрата a. Найти его периметр P = 4·a.
            Console.WriteLine("Дана сторона квадрата a. Найти его периметр P = 4·a.");
            Console.WriteLine("please enter the number");
            double a = Convert.ToInt32(Console.ReadLine());
            double s = 2;
            double d = Math.Pow(a, s);
            //double d = a * a;
            Console.WriteLine(d);


            // Begin-3 Даны стороны прямоугольника a и b. Найти его площадь S = a·b и периметр P = 2·(a + b).
            Console.WriteLine("Даны стороны прямоугольника a и b. Найти его площадь S = a·b и периметр P = 2·(a + b).");
                        Console.WriteLine("please enter the number");

            // Begin-3

            Console.WriteLine("please enter the number");

            double a3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("please enter the number");
            double b3 = Convert.ToDouble(Console.ReadLine());

            double s3 = a3 * b3;
            double p3 = 2 * (a3 + b3);
            Console.WriteLine("S=" + s3 + "\t P=" + p3);


            // Begin-7 Найти длину окружности L и площадь круга S заданного радиуса R:

            const double PI = Math.PI;
            Console.WriteLine("Найти длину окружности L и площадь круга S заданного радиуса R:");
            Console.WriteLine("please enter the number");
            double r7 = Convert.ToDouble(Console.ReadLine());
            double l7 = 2 * PI * r7;
            double s7 = PI * r7 * r7;
            Console.WriteLine("l=" + l7 + "\ns=" + s7);
            // Begin-8 Даны два числа a и b. Найти их среднее арифметическое: (a + b)/2.
            Console.WriteLine("Даны два числа a и b. Найти их среднее арифметическое: (a + b)/2.");
            Console.WriteLine("please enter the number");
            double a8 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("please enter the number");
            double b8 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine((a8 + b8) / 2);

            // Begin-9 Даны два неотрицательных числа a и b. Найти их среднее геометрическое, то есть квадратный корень из их произведения: √a·b.

            Console.WriteLine("Даны два неотрицательных числа a и b. Найти их среднее геометрическое, то есть квадратный корень из их произведения: √a·b.");
            Console.WriteLine("please enter the number");
            double a9 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("please enter the number");
            double b9 = Convert.ToDouble(Console.ReadLine());


            double s9 = Math.Sqrt(a9 * b9);
            Console.WriteLine(s9);
<<<<<<< .mine


=======
<<<<<<< HEAD
=======
>>>>>>> .theirs


            // Begin-10 Даны два ненулевых числа. Найти сумму, разность, произведение и частное их квадратов.
            Console.WriteLine("Даны два ненулевых числа. Найти сумму, разность, произведение и частное их квадратов.");
            Console.WriteLine("please enter the number");
            double a10 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("please enter the number");
            double b10 = Convert.ToDouble(Console.ReadLine());
            double s10 = Math.Sqrt(a10) + Math.Sqrt(b10);
            double s101 = Math.Sqrt(a10) - Math.Sqrt(b10);
            double s102 = Math.Sqrt(a10) * Math.Sqrt(b10);
            double s103 = Math.Sqrt(a10) / Math.Sqrt(b10);

            Console.WriteLine($"s= {s101}, s1= {s101},s2= {s102}, s3= {s103}");
<<<<<<< .mine

=======
>>>>>>> 3678aa96f24750935a405f507670d1fe76ba1688
>>>>>>> .theirs


            

            // Begin-11 Даны два ненулевых числа. Найти сумму, разность, произведение и частное их модулей.
            Console.WriteLine("please enter the number");
            double a11 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("please enter the number");
            double b11 = Convert.ToDouble(Console.ReadLine());
            double s11 = Math.Abs(a11) + Math.Abs(b11);
            double s111 = Math.Abs(a11) - Math.Abs(b11);
            double s112 = Math.Abs(a11) * Math.Abs(b11);
            double s113 = Math.Abs(a11) / Math.Abs(b11);

            Console.WriteLine($"s= {s111}, s1= {s111},s2= {s112}, s3= {s113}");

        }


    }
}
