//
using System;

namespace Application
{
    public class Numbers
    {
        static bool debug = false;

        static void PrintArray(double[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        // Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
        //M = 1; N = 15 -> 120
        //M = 4; N = 8. -> 30
        static void Main66(int n = 15, int m = 1)
        {
            int sum = 0;
            for (int i = m; i <= n; i++)
            {
                sum += i;
            }
            Console.WriteLine("sum = " + sum);
        }

        static void Main66b(int n = 15, int m = 1)
        {
            int M = 1;
            int N = 15;
            int sum = 0;
            for (int i = M; i <= N; i++)
            {
                sum += i;
            }
            Console.WriteLine (sum);
        }

        // Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
        //m = 2, n = 3 -> A(m,n) = 9
        //m = 3, n = 2 -> A(m,n) = 29
        static void Main68(int m = 2, int n = 3)
        {
            int sum = 0;
            for (int i = m; i <= n; i++)
            {
            }
        }

        static int A(int n, int m)
        {
            if (n < 0 || m < 0) throw new ArgumentOutOfRangeException();
            if (n == 0) return m + 1;
            if (m == 0) return A(n - 1, m);
            return A(n - 1, A(n, m - 1));
        }

        static string GetNatural63(int i, string result = null)
        {
            if (i == 0)
            {
                return "0 ";
            }
            else
            {
                if (result != null)
                {
                    result += i.ToString() + " ";
                }
                else
                    result = i.ToString() + " ";
                if (result.Length < (i + 2) * 28 || result.Length < 135 + 1 + 1)
                    return GetNatural63(i - 1, result);

                return (result);
            }
        }

        static int GetSumNumbers67(int i)
        {
            // берет число и возвращать сумму его цифр.
            if (
                i / 10 == 0 // i < 10
            )
            {
                return i;
            }
            else
            {
                return (i % 10 + GetSumNumbers67(i / 10));
            }
        }

        static int GetSumNumbers(int i, int j)
        {
            // берет числа А и Б и возвращать целую степень его цифр.
            if (j == 1)
            {
                return i;
            }
            else
            {
                return (i * GetSumNumbers(i, j - 1));
            }
        }

        static int factorial(int i)
        {
            //
            if (i == 1)
            {
                return 1;
            }
            else
            {
                return (i * factorial(i - 1));
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine(GetNatural63(50));
            Main66();
            Console.WriteLine("A=" + A(2, 5));
            Console.WriteLine("A=" + A(1, 2));
            Console.WriteLine("A=" + A(2, 3));
            Console.WriteLine("A=" + A(3, 2));

            if (debug)
            {
                Console.WriteLine("Factorial=" + factorial(5));
                Console.WriteLine(GetSumNumbers(2, 3));
                Console.WriteLine(GetSumNumbers67(123));
            }
        }
    }

    namespace System.Runtime.CompilerServices
    {
        public class IsExternalInit { }
    }
}
