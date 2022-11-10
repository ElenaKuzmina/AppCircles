using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCircles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //вычислить произведение целых чисел, введенных с клавиатуры.
            //количество чисел указывает пользователь

            //входные: N - количество чисел
            //a - целое число
            //выходные: P - произведение

            //Console.WriteLine("Задача 1");
            //Console.Write("введите количество чисел N=");
            //int N = Convert.ToInt32(Console.ReadLine());
            //int a;
            //int P = 1;
            //for(int i = 0; i < N; i++)
            //{
            //    a = Convert.ToInt32(Console.ReadLine());
            //    P *= a; // накопление произведения P=P*a
            //}
            //Console.WriteLine($"Произведение чисел P={P}");
            //Console.ReadKey();
            ////Задача 2
            //вычислить сумму целых чисел
            //числа вводить до тех пор пока сумма не превысит 100
            //Console.WriteLine("Задача 2");
            //int summa = 0;
            //int a;
            //Console.WriteLine("Вводите числа пока сумма меньше 100");
            //do
            //{
            //     a = Convert.ToInt32(Console.ReadLine());
            //    summa += a;
            //}
            //while(summa < 100);
            //Console.WriteLine($"Сумма чисел = {summa - a}");
            //Console.ReadKey();

            //Задача 3
            //ввод чисел пока не будет введен 0
            //найти количество отрицательных чисел последовательности
            //Console.WriteLine("Задача 3");
            //int count = 0;
            //double x;
            //do
            //{
            //    Console.WriteLine("Введите число");
            //    x = Convert.ToDouble(Console.ReadLine());
            //    if (x < 0)
            //        count++;
            //}
            //while (x != 0);
            //Console.WriteLine($"Количество отрицательных count={count}");
            //Console.ReadKey();
            //Задача 4
            //Дано целое число
            //Есть ли в нем цифра 5?
            //789543 - "да"
            //4871236 - "нет"
            Console.WriteLine("Задача 4. Есть ли цифра 5?");
            Console.WriteLine("Введите число N= ");
            long N = Convert.ToInt64(Console.ReadLine());
            while (N > 0)
            {
               if (N % 10 == 5)
                {
                    Console.WriteLine("да");
                    break;
                }
               N /= 10;
                
            }
            if (N == 0) Console.WriteLine("нет");
            Console.ReadKey();
        }
    }
}
