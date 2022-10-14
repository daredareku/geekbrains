// которая принимает два числа и определяет, являются ли они квадратом другого числа.
using System;
Console.WriteLine("Введите первое число");
int aa = Convert.ToInt32(Console.ReadLine());
//int a = new Random().Next(100,999);
Console.WriteLine("Введите второе число");
int bb = Convert.ToInt32(Console.ReadLine());
if(aa != bb*bb){
    Console.WriteLine("Числа не являются квадратами друг друга");
}
else{
    Console.WriteLine("Числа являются квадратами друг друга");
}
//Console.WriteLine(a.ToString());