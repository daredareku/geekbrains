// которая принимает трехзначное число, а на выходе показывает вторую цифру этого числа.
using System;

// ReSharper disable once CheckNamespace
namespace Application
{

    public class SecondCyfra
    {
        static void Main1(int a)
        { // которая принимает трехзначное число, а на выходе показывает вторую цифру этого числа.
            Console.WriteLine("First Dreibitnoe number: ");
            int aa = int.Parse(Console.ReadLine());
            int b = aa / 10;
            b = b % 10;
            int c = b % 10;
            Console.WriteLine(b);
        }

        // которая принимает  число, а на выходе показывает третью цифру этого числа, или сообщает что третьей цифры нет.
        static void Main21(string[] args)
        {
            int[] aa = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Console.WriteLine("Enter  number for 3th digit: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int b, c;
            c = 9;
            b=0;
            while (a > 0)
            {
                b = a % 10;
                a = a / 10;
                c--;
                aa[c] = b;
            }
            if(c>=7)
                Console.WriteLine("No third cyfra. Нет третьей цифры");
            else
                Console.WriteLine("Third cyfra is: " + aa[c+2]);    //]);    
            
        }

        static void Main3(string[] args)
        { // которая принимает на вход цифру, обозначающую день недели, а на выходе проверяет, является ли этот день выходным.
            Console.WriteLine("Enter number of day: ");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a == 6 || a == 7)
            {
                Console.WriteLine("This day is weekend");
            }
            else
            {
                Console.WriteLine("This day is not weekend");
            }
        }

        static void Main(string[] args)
        { // которая 
            Console.WriteLine("Hello World 2022!");
            Main1(0);
            Main21(args);
            Main3(args);
        }
    }
}




