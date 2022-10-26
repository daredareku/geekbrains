//
using System;

namespace Application
{
    public class Numbers
    {
        static bool debug = false;

        static double[] SortArray1(double[] arr)
        {
            return arr;
        }

        static double[] SortArray2(double[] arr)
        {
            return arr;
        }

        static double[] AddRowToArray(double[] arr)
        {
            return arr;
        }

        static double[] CopyString(double[] arr)
        {
            return arr;
        }

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
            //return arr;
        }

        static int[,]
        CreateArray(int m, int n) 
        {
            int[,] a = new int[m, n];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                }
            }
            return a;
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
            double[] arr1 = new double[arr.GetLength(0)];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                //double[] arr2=CopyString(arr[i]);
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    //SortArray(arr[i, j]); //, i); //,[i, 0]);
                }
            }

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
            double[] arr2 = new double[n];
            double[] arr1 = new double[arr.GetLength(0)];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                //double[] arr2=CopyString(arr[i]);
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr1[i] += arr[i, j];
                }
            }
            System.Console.WriteLine("min Line number: ");
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
                //double[] arr2=CopyString(arr[i]);
                for (int j = 0; j < arr2.GetLength(1); j++)
                {
                    // произведение двух матриц.
                    sum=0;
                    for (int k = 0; k < arr2.GetLength(0); k++)
                    {
                        sum += arr2[j, i]*arr1[i, j];
                        
                    }
                    arr3[i, j] = sum; // arr1[i, j] * arr2[j, i];
                }
            }

            return arr3;
        }

        static void Main60(double[,,] arr1)
        {
            arr1 = new double[2, 2, 2];
            /*    

    int n = arr1.GetLength(0);
            int count = 0;


            return arr3;
        }

        static double[,] Main60(double[,] arr)
        {
            /*
Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/

            //return arr;
        }

        static double[,] Main62(double[,] arr)
        {
            /*
Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/
            int n = arr.GetLength(0);
            int count = 0;
            double[,] arr2 = new double[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    arr2[i, j] = 0;
                }
            }

            return arr;
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

        /*
int[] array = CreateArray(10);
PrintOneDimensionArray(array);

PrintArray(GetDictionary(array));

*/
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

        static void PrintArray(int[,] array)
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
                    //arr[i, j] = array[i, j];
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

            //int el=arr[0, 0];
            //int count = 1;
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

            //System.Console.WriteLine (count);
            //Array.Sort (arr); //sort the array only one dimensional
            //System.Sort(arr, Int32, Int32)
            /*;
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length; j++)
                {
                }
            }
            */
            PrintArray (arr);

            /* PrintArray(array);

            Console.WriteLine();

            int[,] newArray = UpdateArray(array);

            PrintArray(newArray);

            Console.ReadKey();
            */
        }

        /*
int[,] array = CreateArray(5, 5);
PrintArray(array);

Console.WriteLine();

int[,] newArray = UpdateArray(array);
PrintArray(newArray);
*/
        static int[,] Main59(int[,] arr)
        {
            //static
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
                    //arr[i, j] = array[i, j];
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

        static void Main(string[] args)
        {
            double[,] arr = new double[5, 5];
            int[,] arr1 = new int[5, 5];
            System.Console.WriteLine("The array 57:");
            Main57 (arr1);
            System.Console.WriteLine("Array 62:");
            PrintArray(Main62(CreateArray2(5-1, 5-1)));
            System.Console.WriteLine("Array 61:");
        }
    }

    class Program
    {
        static void MainTV(string[] args)
        {
        }

        static void MainKV(string[] args)
        {
            // KV - К Встреча
            double[,] arr = new double[3, 3];
            arr[0, 0] = 1;
            arr[0, 1] = 2;
            arr[0, 2] = 3;
            arr[1, 0] = 4;
            arr[1, 1] = 5;
            arr[1, 2] = 6;
            arr[2, 0] = 7;
            arr[2, 1] = 8;
            arr[2, 2] = 9;

            double[,] arr2 = new double[3, 3];
            arr2[0, 0] = 1;
            arr2[0, 1] = 2;
            arr2[0, 2] = 3;
            arr2[1, 0] = 4;
            arr2[1, 1] = 5;
            arr2[1, 2] = 6;
            arr2[2, 0] = 7;
            arr2[2, 1] = 8;
            arr2[2, 2] = 9;

            double[,] arr3 = new double[3, 3];
            arr3[0, 0] = 1;
            arr3[0, 1] = 2;
            arr3[0, 2] = 3;
            arr3[1, 0] = 4;
            arr3[1, 1] = 5;
            arr3[1, 2] = 6;
            arr3[2, 0] = 7;
            arr3[2, 1] = 8;
            arr3[2, 2] = 9;

            double[,] arr4 = new double[3, 3];
            arr4[0, 0] = 1;
            arr4[0, 1] = 2;
            arr4[0, 2] = 3;
            arr4[1, 0] = 4;
            arr4[1, 1] = 5;
            arr4[1, 2] = 6;
            arr4[2, 0] = 7;
            //arr4[2, 1] =
        }
        /*
        static void Main(string[] args)
        {

        }
        */
    }
}
