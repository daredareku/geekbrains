//
using System;

namespace Application
{
    public class Numbers
    {
            static void Main34(string[] args)
            { // Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
                int[] a = new int[10];
                int b = 0;
                for (int i = 0; i < a.Length; i++)
                {
                    a[i] = new Random().Next(100, 999);
                    if (a[i] % 2 == 0)
                    {
                        b++;
                    }
                }
                Console.WriteLine(b);
                
            }
    
            static void Main36(string[] args)
            {
                //Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
                //[3, 7, 23, 12] -> 19
                //[-4, -6, 89, 6] -> 0
                int[] a = new int[10];
                int b = 0;
                for (int i = 0; i < a.Length; i++)
                {
                    a[i] = new Random().Next(0, 999);
                }
                for (int i = 0; i < a.Length; i++)
                {
                    if (i % 2 != 0)
                    {
                        b = b + a[i];
                    }
                }
                Console.WriteLine(b);
            }

            static void Main37(string[] args)
            {
                //Задача 37: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на чётных позициях.
                //[3, 7, 23, 12] -> 15
                //[-4, -6, 89, 6] -> 83
                int[] a = new int[10];
                int b = 0;
                for (int i = 0; i < a.Length; i++)
                {
                    a[i] = new Random().Next(0, 999);
                }
                for (int i = 0; i < a.Length; i++)
                {
                    if (i % 2 == 0)
                    {
                        b = b + a[i];
                    }
                }
                Console.WriteLine(b);
            }

        
//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

//[3, 7, 23, 12] -> 19

//[-4, -6, 89, 6] -> 0
//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76
//[-4 -6 89 6] -> 95        

            static void Main38(string[] args)
            {
                int[] a = new int[10];
                int b = 0;
                int c = 0;
                for (int i = 0; i < a.Length; i++)
                {
                    a[i] = new Random().Next(0, 999);
                }
                for (int i = 0; i < a.Length; i++)
                {
                    if (a[i] > b)
                    {
                        b = a[i];
                    }
                    if (a[i] < c)
                    {
                        c = a[i];
                    }
                }
                Console.WriteLine("max="+b);
                Console.WriteLine("min="+c);
                Console.WriteLine(b - c);
            }





            static void Main(string[] args)
            {
                Console.WriteLine("Hello World 2022!");
                Main34(args);
                Main36(args);
                Main38(args);
            }
        
    }
}