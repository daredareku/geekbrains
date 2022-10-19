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

        // которая принимает  число, а на выходе показывает третью цифру этого числа, или сообщает что третьей цифры нет, для чутезнычного числа и больше.
        static void Main222(int a)
        {
            //Console.WriteLine("First Dreibitnoe number: ");
            //int aa = int.Parse(Console.ReadLine());
            //int b = aa / 100;
            //b = b % 10;
            //int c = b % 10;
            //Console.WriteLine(b);
            //returns b;
        }

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
            while(a > 0)
            {
                int b = a % 10;
                a = a / 10;
                Console.WriteLine(b);
            }
            //int b = aa / 100;
            //b = b % 10;
            //int c = b % 10;
            Console.WriteLine(b);
        }

        // которая задает массив из 8 элементов и выводит его на экран.
        static void Main444(int[] a)
        {
            for (int i = 0; i < a.length; i++)
            {
                Console.WriteLine(a[i]);
                
            }

        }




        // которая массив из восьми элементов, и заполнит его нулями и единицами.
        static void Fillbinaryarray(int[] a){
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = new Random().Next(0, 2);
                Console.WriteLine("Fill binaryarray success "+(a[i]));
            }
            //string aa=int.Parse(a);
            

        }

        
        
        static int Main3333(int a)
        {// которая считает факториал числа.
           
            int aa=1;

            for (int i = 1; i <= a; i++)
            {
                aa = aa * i;
                
            }
            Console.WriteLine(aa);
            return aa;
        }

        // которая принимает число и выдает количество цифр
        static int Main333(int a)
        { 
            //int aa;
            int i=0;
            Console.WriteLine("First  number: ");
            int aa = int.Parse(Console.ReadLine());
            while (aa > 0){
                //Console.WriteLine(aa);
                aa=aa / 10;
                //aa = aa % 10;
                //aa--;
                i++;
            }
            Console.WriteLine(i);
            return i;
        }


        // которая принимает  число, а на выходе показывает третью цифру этого числа, или сообщает что третьей цифры нет.
        static void Main21(string[] args)
        {
            Console.WriteLine("Enter  number: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int b, c, d, e;
            c = 0;
            b=0;
            d=a%10;
            e=0;
            while (a >= 10)
            {
                a = a / 10;
                b = a % 10;
                e=b%10;
                c++;
            }
            if(c==2)
                Console.WriteLine(d);
            else if(c==3)
                Console.WriteLine(e); 
            if (c > 3)
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
            if(a>=1 && a<=5)
                Console.WriteLine("Work day");
            else if(a==6 || a==7)
                Console.WriteLine("Weekend");
            else
                Console.WriteLine("Error");
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
            Fillbinaryarray(new int[8]);
            Main3333(4);
            Main333(1);
            Main1(0);
            Main21(args);
            Main3(args);
        }
    }
}




