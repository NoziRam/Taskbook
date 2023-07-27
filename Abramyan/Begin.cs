using System;
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



            // Begin-12 Даны катеты прямоугольного треугольника a и b. Найти его гипотенузу c и периметр P: c =√a2 + b2, P = a + b + c.
            Console.WriteLine("Begin-12 Даны катеты прямоугольного треугольника a и b. Найти его гипотенузу c и периметр P: c =√a2 + b2, P = a + b + c.");
            Console.WriteLine("please enter the number");
            double a12 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("please enter the number");
            double b12 = Convert.ToDouble(Console.ReadLine());
            double c12 = Math.Sqrt(Math.Sqrt(a12) + Math.Sqrt(b12));
            double p12 = a12 + c12 + b12;

            Console.WriteLine(p12);



            /* Begin-13  Даны два круга с общим центром и радиусами R1 и R2 (R1 > R2).
Найти площади этих кругов S1 и S2, а также площадь S3 кольца, внешний радиус которого равен R1, а внутренний радиус равен R2:
S1 = π·(R1)2, S2 = π·(R2)2, S3 = S1 − S2.В качестве значения π использовать 3.14.*/
            Console.WriteLine("Даны два круга с общим центром и радиусами R1 и R2 (R1 > R2). Найти площади этих кругов S1 и S2, а также площадь S3 кольца, внешний радиус которого равен R1, а внутренний радиус равен R2:S1 = π·(R1)2, S2 = π·(R2)2, S3 = S1 − S2.В качестве значения π использовать 3.14.");
           
            Console.Write("r1=");
            double r131 = Convert.ToDouble(Console.ReadLine());
            Console.Write("r2=");
            double r132 = Convert.ToDouble(Console.ReadLine());

            double s131 = 3.14 * Math.Pow(r131, 2);
            Console.WriteLine("s1=" + s131);
            double s132 = 3.14 * Math.Pow(r132, 2);
            Console.WriteLine("s2=" + s132);
            double s133 = s131 - s132;
            Console.WriteLine("s3=" + s133);

            // Begin-15
            /*
. Дана площадь S круга. Найти его диаметр D и длину L окружности, ограничивающей этот круг, учитывая, что L = 2·π·R, S = π·R
2. В качестве значения π использовать 3.14.*/

            Console.Write("please enter the number s=");
            double s15 = Convert.ToDouble(Console.ReadLine());

            double d15 = Math.Sqrt(s15 * 4 / Math.PI);
            double l15 = Math.PI * d15;
            Console.WriteLine(l15);

            // Begin-16
            /*Найти расстояние между двумя точками с заданными координатами x1 и x2 на числовой оси: |x2 − x1|.*/

            Console.Write("please enter the number x1=");
            double x161 = Convert.ToDouble(Console.ReadLine());
            Console.Write("please enter the number x2=");
            double x162 = Convert.ToDouble(Console.ReadLine());

            double l16 = Math.Abs(x162 - x161);

            Console.WriteLine(l16);

        }


    }
}
