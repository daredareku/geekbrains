//
using System;

namespace Application
{
    public class Numbers
    {
        static bool debug = false;

        static double[,]
        Main47(double[,] arr) /*
        Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.

0,5 7 -2 -0,2

1 -3,3 8 -9,9

8 7,8 -7,1 9    */
        {
            Random rnd = new Random();

            int count = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = rnd.Next(10, 99);
                }
            }
            return arr;
        }

        static int
        Main50(double[,] array, int x, int y) /*
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

17 -> такого числа в массиве нет
*/
        {
            if (x >= array.GetLength(0) || y >= array.GetLength(1))
            {
                Console.WriteLine("No such element");
                return -1;
            }
            else
            {
                Console.WriteLine(array[x, y]);
            }
            return (int)(array[x, y]); //
        }

        static int[]
        Main52(int[,] array) /*
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */
        {
            int[] result = new int[array.GetLength(1)];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                int sum = 0;
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    sum += array[i, j];
                }
                result[i] = sum / array.GetLength(0);
            }
            return result;

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    Console.WriteLine(array[i, j]);
                }
            }
        }

        int[,] array = new int[4, 5];

        static string ArrayToString(double[,] array)
        {
            string result = string.Empty;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    result += $"{array[i, j]} ";
                }

                result += Environment.NewLine;
            }

            return result;
        }

        static int[,] Main48(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = i + j;
                }
            }
            return array;
        }

        static void PrintArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write($"{array[i, j]} ");
                }

                Console.WriteLine();
            }
        }

        static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine();
        }

        static int[,] Main49(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (i % 2 == 0 && j % 2 == 0)
                    {
                        array[i, j] = array[i, j] * array[i, j];
                    }
                }
            }
            return array;
        }

        static int[,] RandomArray(int[,] array)
        {
            Random rnd = new Random();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = rnd.Next(10, 15);
                }
            }
            return array;
        }

        static double[,] RandomArray(double[,] array)
        {
            Random rnd = new Random();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = rnd.Next(10, 15);
                }
            }
            return array;
        }

        static int Main51(int[,] array, int x, int y)
        {
            int summ = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        summ += array[i, j];
                    }
                }
            }
            return summ;
        }

        static void Main(string[] args)
        {
            int[,] array = new int[4, 5];
            PrintArray(Main48(array));
            int[,] arr =
                RandomArray(new int[array.GetLength(0), array.GetLength(1)]);
            PrintArray (arr);
            System.Console.WriteLine("ArrayQuad");
            PrintArray(Main49(arr));
            int[,] arr1 =
                RandomArray(new int[array.GetLength(0), array.GetLength(1)]);
            System.Console.WriteLine("sum51=" + Main51(arr1, 0, 0));

            System.Console.WriteLine("Our Array");
            PrintArray (arr1);
            System.Console.WriteLine("");
            System.Console.WriteLine("ArrayToString47");

            double[,] arr2 =
                RandomArray(new double[array.GetLength(0), array.GetLength(1)]);
            Console.WriteLine(ArrayToString(Main47(arr2)));

            System.Console.WriteLine("ArrayToString50, Enter coordinates:");
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Element=" + Main50(arr2, x, y));

            System.Console.WriteLine("ArrayToString52 coordinates:");

            PrintArray(Main52(new int[,] {
                { 1, 4, 7, 2 },
                { 5, 9, 2, 3 },
                { 8, 4, 2, 4 }
            }));
        }
    }
}
