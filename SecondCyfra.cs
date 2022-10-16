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
            Console.WriteLine("Enter  number: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int b, c, d;
            c = 0;
            b=0;
            d=a%10;
            while (a >= 10)
            {
                a = a / 10;
                b = a % 10;
                c++;
            }
            if(c==2)
                Console.WriteLine(d);
            else
                //Console.WriteLine("No third cyfra");
            if (c >= 3)
            {
                Console.WriteLine(b);
            }
            else
            {
                Console.WriteLine("No third number");
            }   
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




