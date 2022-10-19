//
using System;

namespace Application
{

    public class Numbers
    {




//Массивы и функции в программировании
//Задача 19

//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да
        static void Main19(){
            Console.WriteLine("Enter a 5 digit number");
            int n = int.Parse(Console.ReadLine());
            int i=0;
            int j=0;
            int k=0;
            int b=0;
            bool flag=false;
            while (n>0)
            {
                b = n%10;
                n=n/10;
                i++;
                if(i==1) j=b; //++;
                if(i==2)k=b; //++;
                if(i==4 && k==b)flag=true; //++;
                if(i==5 && j==b)flag=true; else flag=false; //++;
                if(i==6){
                    Console.WriteLine("Hello, such a number does not exist for this task");
                    break;
                } //&& k==b)flag=true; //++;
            }
            
            if(flag)
            {
                Console.WriteLine("Hello, such a number exists for this task. This number is a palindrome"  );
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }}
//Задача 21

//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53
        static void Main21(){
            Console.WriteLine("Enter 3+3 numbers: ");
            int x1 = int.Parse(Console.ReadLine());
            int y1 = int.Parse(Console.ReadLine());
            int z1 = int.Parse(Console.ReadLine());
            int x2 = int.Parse(Console.ReadLine());
            int y2 = int.Parse(Console.ReadLine());
            int z2 = int.Parse(Console.ReadLine());
            double d = Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2)+Math.Pow(z2-z1,2));
            Console.WriteLine(d);
        }

//Задача 23

//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125
    static void Main23(){
        Console.WriteLine("Enter a number");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Hello, such a numbers cubes exist for this task");
        for (int i = 1; i <= n; i++){
            Console.WriteLine(Math.Pow(i, 3));
        }   
        //
   }

   static void Main(){
        //int n = int.Parse(Console.ReadLine());
        Main19();
        Main21();
        Main23();
    }

    }
}