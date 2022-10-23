//
using System;

namespace Application
{
    public class Numbers
    {
        static bool debug = true;

        static void Main41(int[] args)
        //Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
        //0, 7, 8, -2, -2 -> 2
        //1, -7, 567, 89, 223-> 3
        {
            int[] arr = new int[14];
            int mycount = 0;
            System.Console.WriteLine("41. Entering array size M");
            for (int i = 0; i < 14; i++)
            {
                arr[i] = 0;
            }
            for (int i = 0; i < args.Length; i++)
            {
                if (args[i] > 0)
                {
                    mycount++;
                }
            }

            System.Console.WriteLine("41. Counting numbers > 0: " + mycount);
        }

        static void Main43(int[] args)
        {
            //Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
            //b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
            System.Console.WriteLine("43. Entering b1, k1, b2, k2: ");
            int n = args[0];
            int k1 = args[1]; //
            int b1 = args[2]; //
            int k2 = args[3]; //
            int b2 = args[4]; //

            if (debug)
            {
                Console.WriteLine("n=" + n);
                Console.WriteLine("k=" + k1);
                Console.WriteLine("b1=" + b1);
                Console.WriteLine("k2=" + k2);
                Console.WriteLine("b2=" + b2);
            }
            if (k1 == k2)
            {
                Console.WriteLine("No, straight forward lines. ");
            }
            else
            {
                double x = (b2 - b1) / (k1 - k2);
                double y = k1 * x + b1;
                Console.WriteLine("x=" + x);
                Console.WriteLine("y=" + y);
            }
        }

        static void ReverseArray(int[] args)
        {// 39. которая перевернет одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
            int[] arr = new int[args.Length];
            for (int i = 0; i < args.Length; i++)
            {
                arr[i] = args[args.Length - i - 1];
            }
            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }

        }

        static int[] ReverseArray1(int[] args)
        {// 39. которая перевернет одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
            int[] arr = new int[args.Length];
            for (int i = 0; i < args.Length; i++)
            {
                arr[i] = args[args.Length - i - 1];
            }
            return arr;

        }

        static string ArrayToGetString(int[] args)
        {//string
            string s = "";

            for (int i = 0; i < args.Length; i++)
            {
                s += args[i];
            }
            return s;
        }

        int[] TransporateArray1(int[] args)
        {// 40. которая транспонирует матрицу (первая строка станет первым столбцом, вторая - вторым и т.д.)

            int[] arr = new int[args.Length];
            for (int i = 0; i < args.Length; i++)
            {
                arr[i] = args[args.Length - i - 1];
            }
            return arr;
        }

        static void Transporate1(int[] originalArray, int a)
        { // 41. // 40

        }

        static string ArrayToString(int[] array)
        {
            string result = string.Empty;

            for (int i = 0; i < array.Length; i++)
            {
                result += $"{array[i]}, ";
            }

            return result;
        }

        static int[] TransporateArray(int[] originArray)
        {
            int[] newArray = new int[originArray.Length];

            for (int i = 0; i < originArray.Length; i++)
            {
                newArray[i] = originArray[originArray.Length - 1 - i];
            }

            return newArray;
        }

        static void Transporate(int[] originArray)
        {
            for (int i = 0; i < originArray.Length / 2; i++)
            {
                int buffer = originArray[i];
                originArray[i] = originArray[originArray.Length - 1 - i];
                originArray[originArray.Length - 1 - i] = buffer;
            }
        }

        static void Fibo(int N)
        { // 44. Напишите программу, которая выведет на экран первые N чисел Фибоначчи, не используя рекурсию.
            double[] fibo = new double[N];
            fibo[0] = 0; //(0)
            fibo[1] = 1; //(1)

            for (int i = 2; i < N; i++)
            {
                fibo[i] = fibo[i - 1] + fibo[i - 2];
            }
            PrintArray(fibo);
        }

        static int[] CreateArray(int size)
        {
            int[] array = new int[size];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i;
            }

            return array;
        }

        static int[] CopyArray(int[] originArray)
        {
            int[] newArray = new int[originArray.Length];

            for (int i = 0; i < newArray.Length; i++)
            {
                newArray[i] = originArray[i];
            }

            return newArray;
        }
        int[] array = CreateArray(10);

        static void PrintArray(double[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                System.Console.Write(arr[i] + " ");
            }
            System.Console.WriteLine();
        }

        static void Main(string[] args)
        {
            int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Console.WriteLine("Hello World 2022!");
            if (debug)
            {
                System.Console.WriteLine("ArrayToString(array): " + ArrayToString(array));
                System.Console.WriteLine("ReverseArray: ");
                Console.WriteLine(ArrayToString(ReverseArray1(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }) ));

                Console.WriteLine(ArrayToString(array));

                int[] newArray = TransporateArray(array);
                System.Console.WriteLine("TransporateArray:" + ArrayToString(newArray));
                Console.WriteLine(ArrayToString(newArray));

                Transporate(array);
                System.Console.WriteLine("Transporate: "); // 
                Console.WriteLine(ArrayToString(array));
                System.Console.WriteLine("Fibo: "); // 
                Fibo(70); //
            }
            Main41(new int[] { 0, 7, 8, -2, -2 });
            Main43(new int[] { 0, 7, 8, -2, -2 });
        }
    }
}