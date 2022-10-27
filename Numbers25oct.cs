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

        static void PrintString(double[] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                Console.Write(array[i] + " ");
            }
        }

        static void AddRowToArray(
            double[,] array,
            int columnNumber,
            double value
        )
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                array[i, columnNumber] = value;
            }
        }

        static int[,] UpdateArray(int[,] array, int columnNumber, int value)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                array[i, columnNumber] = value;
            }
            return array;
        }

        static double[,]
        Main54SortLine(double[,] arr) /*
Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/
        {
            for (int i = 0; i < arr.GetLength(1); i++)
            {
                double[] arr1 = CopyRow(arr, i);
                double[] arr2 = CopyColumn(arr, i);
                Array.Sort(arr1, (x, y) => y.CompareTo(x));
                PrintString (arr1);
                System.Console.WriteLine();
                Array.Sort(arr2, (x, y) => y.CompareTo(x));
                for (int j = 0; j < arr2.GetLength(0); j++)
                {
                    arr[j, i] = arr2[j]; // копирование column
                }
            }
            System
                .Console
                .WriteLine("Done, Array.Sort() finished. Now Columns Sort: ");
            return arr;
        }

        static int Main56(double[,] arr)
        {
            /*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/
            int n = arr.GetLength(0);
            int count = 0;
            int countmax = 0;
            double min = 1.2e11;
            double max = 0;
            double prev = 0;
            double sum = 0;

            double[] arr1 = new double[arr.GetLength(0)];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                sum = 0;
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    sum += arr[i, j];
                    arr1[i] = sum;
                }
                if (max < sum)
                {
                    max = sum; 
                    countmax = i;
                }
                if (sum < min)
                {
                    min = sum;
                    count = i;
                }
            }
            System
                .Console
                .WriteLine("max = " +
                max +
                " min = " +
                min +
                " count = " +
                count);

            System.Console.WriteLine("min Line number: ");
            System.Console.WriteLine (min);
            return count;
        }

        static double[,] Main58(double[,] arr1, double[,] arr2)
        {
            /*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/
            double[,] arr3 = new double[arr1.GetLength(0), arr2.GetLength(1)];
            double sum = 0;

            for (int i = 0; i < arr1.GetLength(0); i++)
            {
                for (int j = 0; j < arr2.GetLength(1); j++)
                {
                    // произведение двух матриц.
                    sum = 0;
                    for (int k = 0; k < arr1.GetLength(1); k++)
                    {
                        sum += arr2[k, j] * arr1[i, k];
                    }
                    arr3[i, j] = sum;
                }
            }
            return arr3;
        }

        static void Main60()
        {
            double[,,] arr1 = new double[2, 2, 2];

            /*    
Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/
            Random rnd = new Random();
            int n = arr1.GetLength(0);
            int count = 0;
            double prev = 9; // двузначных чисел
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < arr1.GetLength(1); j++)
                {
                    for (int k = 0; k < arr1.GetLength(2); k++)
                    {
                        arr1[i, j, k] = rnd.Next(1, 11) + prev;
                        prev = arr1[i, j, k];
                        System
                            .Console
                            .Write($"{arr1[i, j, k]}({i}, {j}, {k}) ");
                    }
                }
            }
            System.Console.WriteLine();
        }

        public static int[,] Spiral(int n)
        {
            int[,] result = new int[n, n];

            int pos = 1;
            int count = n;
            int value = -n;
            int sum = -1;

            do
            {
                value = -1 * value / n;
                for (int i = 0; i < count; i++)
                {
                    sum += value;
                    result[sum / n, sum % n] = pos++;
                }
                value *= n;
                count--;
                for (int i = 0; i < count; i++)
                {
                    sum += value;
                    result[sum / n, sum % n] = pos++;
                }
            }
            while (count > 0);

            return result;
        }

        // Method to print arrays, pads numbers so they line up in columns
        public static void PrintArray(int[,] array)
        {
            int n =
                (array.GetLength(0) * array.GetLength(1) - 1)
                    .ToString()
                    .Length +
                1;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j].ToString().PadLeft(n, ' '));
                }
                Console.WriteLine();
            }
        }

        static int[,] Main62(int n)
        {
            /*
Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*
*/
            return Spiral(n);
        }

        static int[,] PasTriangle(int n)
        {
            int[][] result = new int[n][];
            int[,] array = new int[n, n];
            result[0] = new int[] { 1 };
            array[0, 0] = 1;
            for (int i = 1; i < n; i++)
            {
                result[i] = new int[i + 1];
                int left = 0;
                for (int j = 0; j < i; j++)
                {
                    result[i][j] = result[i - 1][j] + left;
                    left = result[i - 1][j];
                    array[i, j] = result[i][j];
                }
                result[i][i] = left;
                array[i, i] = result[i][i];
            }
            return array;
        }

        static double[,] Main53(double[,] arr)
        {
            /* которая поменяет местами первую и последнюю строки двумерного массива.
            */
            double temp = 0;

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                temp = arr[i, 0];
                arr[i, 0] = arr[i, arr.GetLength(1)];
                arr[i, arr.GetLength(1)] = temp;
            }
            return arr;
        }

        static double[,] Main55(double[,] arr)
        {
            /* которая поменяет местами строки и столбцы в двумерном массиве.
            */
            double temp = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    temp = arr[i, j];
                    arr[i, j] = arr[j, i];
                    arr[j, i] = temp;
                }
            }
            return arr;
        }

        static int[,] UpdateArray(int[,] array)
        {
            int[,] newArray = new int[array.GetLength(1), array.GetLength(0)];

            if (array.GetLength(1) != array.GetLength(0))
            {
                throw new ArgumentException("Thiw array can't be reversed");
            }

            for (int i = 0; i < array.GetLength(1); i++)
            {
                int[] column = CopyColumn(array, i);

                AddRowToArray (array, newArray, column, i);
            }
            return newArray;
        }

        static double[] CopyColumn(double[,] array, int columnNumber)
        {
            double[] coulumn = new double[array.GetLength(0)];

            for (int i = 0; i < coulumn.Length; i++)
            {
                coulumn[i] = array[columnNumber, i];
            }
            return coulumn;
        }

        static double[] CopyRow(double[,] array, int columnNumber)
        {
            double[] coulumn = new double[array.GetLength(0)];

            for (int i = 0; i < coulumn.Length; i++)
            {
                coulumn[i] = array[i, columnNumber];
            }
            return coulumn;
        }

        static double[,]
        CopyColumnTo(double[] array, int columnNumber, int nrows)
        {
            double[,] macoulumn = new double[array.GetLength(0), nrows];

            for (int i = 0; i < macoulumn.GetLength(1); i++)
            {
                macoulumn[i, columnNumber] = array[i];
            }
            return macoulumn;
        }

        static int[] CopyColumn(int[,] array, int columnNumber)
        {
            int[] coulumn = new int[array.GetLength(0)];

            for (int i = 0; i < coulumn.Length; i++)
            {
                coulumn[i] = array[columnNumber, i];
            }
            return coulumn;
        }

        static int[,] GetDictionary(int[] array)
        {
            int[] uniqueArray = GetUniqueValuesCount(array);
            int[,] dictionary = new int[uniqueArray.Length, 2];

            for (int i = 0; i < uniqueArray.Length; i++)
            {
                dictionary[i, 0] = uniqueArray[i];
            }

            for (int i = 0; i < array.Length; i++)
            {
                dictionary[IndexOf(dictionary, array[i]), 1]++;
            }

            return dictionary;
        }

        // 1 1 2 3 2 1 4 5 5 6 7
        static int[] GetUniqueValuesCount(int[] array)
        {
            List<int> uniqueValues = new List<int>();

            for (int i = 0; i < array.Length; i++)
            {
                if (!uniqueValues.Contains(array[i]))
                {
                    uniqueValues.Add(array[i]);
                }
            }
            return uniqueValues.ToArray();
        }

        static int IndexOf(int[,] array, int number)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                if (array[i, 0] == number)
                {
                    return i;
                }
            }
            return -1;
        }

        static int[] CreateArray(int length)
        {
            int[] array = new int[length];
            Random random = new Random();

            for (int i = 0; i < length; i++)
            {
                array[i] = random.Next(1, 11);
            }

            return array;
        }

        static void PrintArray1(int[,] array)
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

        static void PrintOneDimensionArray(int[] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }

        static void FreqPrint()
        {
            int[] array = CreateArray(10);
            PrintOneDimensionArray (array);
            PrintArray(GetDictionary(array));
        }

        static void AddRowToArray(
            int[,] originArray,
            int[,] copiedArray,
            int[] row,
            int rowNumber
        )
        {
            for (int i = 0; i < originArray.GetLength(0); i++)
            {
                copiedArray[i, rowNumber] = row[i];
            }
        }

        static double[,] CreateArray2(int m, int n)
        {
            double[,] array = new double[m, n];

            Random random = new Random();

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = random.Next(1, 20);
                }
            }
            return array;
        }

        static int[,] CreateArray1(int m, int n)
        {
            int[,] array = new int[m, n];

            Random random = new Random();

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = random.Next(1, 20);
                }
            }

            return array;
        }

        static void PrintArray2(int[,] array)
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

        static void PrintArray2(int[][] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i][j] + " ");
                }
                Console.WriteLine();
            }
        }

        static int[]
        GetUniqueValues(int[] array) //,
        {
            List<int> uniqueValues = new List<int>();

            for (int i = 0; i < array.Length; i++)
            {
                if (!uniqueValues.Contains(array[i]))
                {
                    uniqueValues.Add(array[i]);
                }
            }
            return uniqueValues.ToArray();
        }

        static void Main57(int[,] arr)
        {
            int[,] array = CreateArray1(3, 3);
            int
                el = 0,
                count = 0;
            for (int k = 0; k < arr.GetLength(0); k++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    el = arr[k, j];
                    for (int i = 0; i < arr.GetLength(0); i++)
                    {
                        for (int l = 0; l < arr.GetLength(1); l++)
                        {
                            if (arr[i, l] == el)
                            {
                                count++;
                            }
                        }
                    }
                    System.Console.WriteLine (count);
                }
            }

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] == el)
                    {
                        count++;
                    }
                }
            }
        }

        static int[,] Main59(int[,] arr)
        {
            int[,] array = CreateArray1(5, 5);
            int
                min = 0,
                count = 0;
            int
                minx = 0,
                miny = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    min = arr[i, j];
                    for (int k = 0; k < arr.GetLength(0); k++)
                    {
                        for (int l = 0; l < arr.GetLength(1); l++)
                        {
                            if (arr[k, l] < min)
                            {
                                min = arr[k, l];
                                minx = k;
                                miny = l;
                            }
                        }
                    }
                    System.Console.WriteLine (min);
                }
            }
            int[,] newArray = CreateArray1(5 - 1, 5 - 1);
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (i != minx && j != miny)
                    {
                        newArray[i, j] = arr[i, j];
                    }
                }
            }
            return newArray;
        }

        static string GetNatural63(int i, string result=null)
        {
            if (i == 1)
                        {
                            return "1 ";
                        }
                        else
                        {
                            if (result != null){ result += i.ToString()+" "; //System.Console.WriteLine(result);
                            }
                            else result = i.ToString()+" ";
                            if(result.Length < i*15) return GetNatural63(i-1, result);
                                //result += GetNatural63(i-1, result);
                            //System.Console.WriteLine(result);
                            //System.Console.WriteLine("end");
                            return (result);
                        }
        }

        static int  GetSumNumbers67(int i){// берет число и возвращать сумму его цифр.
            if (i/10 == 0)// i < 10
                {
                    return i;
                }else {
                    return (i%10 + GetSumNumbers67(i/10));
                }
        }

        static int  GetSumNumbers(int i, int j){// берет числа А и Б и возвращать целую степень его цифр.
            if (j == 1)
                {
                    return i;
                }else {
                    return (i* GetSumNumbers(i, j-1));
                }
        }

        static int factorial(int i){//
        if (i == 1)
                {
                    return 1;
                }
                else
                {
                    return (i*factorial(i-1));
                }
        }

        static void Main(string[] args)
        {
            System.Console.WriteLine(//int[,] array = CreateArray1(3, 3);
                //PrintArray2(array);
                //Main57(array);
                //PrintArray2(Main59(array));
                //GetNatural63(5);
                //GetSumNumbers67(123);
                //GetSumNumbers(2, 3);
                factorial(5)
            );
            System.Console.WriteLine(GetSumNumbers(2, 3));
            System.Console.WriteLine(GetSumNumbers67(123));
            Console.WriteLine(GetNatural63(50));
            Console.ReadKey();
            double[,] arr = new double[5, 5];
            int[,] arr1 = new int[5, 5];
            arr = CreateArray2(5, 5);
            PrintArray (arr);
            System.Console.WriteLine("Array 54: ");
            PrintArray(Main54SortLine(arr));
            System.Console.WriteLine("Array 56: ");
            arr = CreateArray2(5, 5);
            PrintArray (arr);
            System.Console.WriteLine(Main56(arr));
            if (debug)
            {
                System.Console.WriteLine("The array 57:");
                Main57 (arr1);
            }
            System.Console.WriteLine("The matrix multiplication 58:");
            PrintArray(Main58(CreateArray2(5, 5), CreateArray2(5, 5)));
            System.Console.WriteLine("The 3D array 60: ");
            Main60();
            System.Console.WriteLine("Array Spiral 62:");
            PrintArray(Main62(5 - 1));
            Console.WriteLine("Array Pas Triangle: ");
            PrintArray2(PasTriangle(5));
        }
    }
}
