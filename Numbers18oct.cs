//
using System;

namespace Application
{

    public class Numbers
    {


// которая принимает два числа а показывает возводит первое число в натуральную степень второго числа.
        static void MyPower(int a, int b)
        {
            int c = 1;
            for (int i = 0; i < b; i++)
            {
                c = c * a;
            }
            Console.WriteLine(c);
        }

        // которая принимает на вход число, а на выходе показывает сумму цифр этого числа.
        static void Main333(int a)
        {
            //Console.WriteLine("First Dreibitnoe number: ");
            //int aa = int.Parse(Console.ReadLine());
            int b = 0;
            int i=0;
            int ou=0;
            while(a > 0)
            {
                b = a % 10;
                a = a / 10;
                i++;
                ou = ou + b;
                //Console.WriteLine(b);
            }
            Console.WriteLine(ou);
        }

        // которая задает массив из 8 элементов и выводит его на экран.
        static void Main444(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }
        }

        static void Main(string[] args)
        { // которая 

            int[] aa = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };
            Console.WriteLine("Hello World 2022!");
            Console.WriteLine("2^3 number: ");
            MyPower(2, 3);
            Console.WriteLine("Enter number for Sum: ");
            Main333(int.Parse(Console.ReadLine())); 
            Console.WriteLine("array 8 els number: ");
            for (int i = 0; i < 8; i++)
            {
                aa[i] = new
                 Random().Next(0, 10); //new int[i];
            }
            Main444(aa); 
        }

    }
}