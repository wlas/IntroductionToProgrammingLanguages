using System;

namespace IntroductionToProgrammingLanguages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task64:");
            Task64(5);
            Console.WriteLine("\nTask66:");
            Console.Write(Task66(4, 8));
            Console.WriteLine("\nTask68:");
            Console.Write(Task68(3,2));
            Console.ReadKey();
        }

        /* 
            Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
            Выполнить с помощью рекурсии.
            N = 5 -> "5, 4, 3, 2, 1"
            N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
        */

        static void Task64(int numb)
        {
            if (numb == 0)
            {
                return;
            }
            else
            {
                Console.Write($"{numb} ");
                Task64(--numb);
            }
        }

        /* 
            Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
            M = 1; N = 15 -> 120
            M = 4; N = 8. -> 30
        */

        static int Task66(int m, int n)
        {
            if (m == 0) return (n * (n + 1)) / 2;            // Если M равно нулю
            else if (n == 0) return (m * (m + 1)) / 2;       // Если N равно нулю
            else if (m == n) return m;                       // Если M=N
            else if (m < n) return n + Task66(m, n - 1);     // Если M<N
            else return n + Task66(m, n + 1);
        }

        /* 
           Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
           m = 2, n = 3 -> A(m,n) = 9
           m = 3, n = 2 -> A(m,n) = 29
       */

        static int Task68(int m, int n)
        {
            if (m == 0) return n + 1;
            else if (n == 0) return Task68(m - 1, 1);
            else return Task68(m - 1, Task68(m, n - 1));
        }
    }
}
