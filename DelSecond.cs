// которая на входе принимает трехзначное число, и выдает это  число удалив вторую цифру.
using System;
//Console.WriteLine("Введите первое число");
//int aa = Convert.ToInt32(Console.ReadLine());
int a = new Random().Next(100,999);
Console.WriteLine(a.ToString());
int first=(a/100)*10;
int second=a%10;
int third=a%100;
Console.WriteLine(first+second);