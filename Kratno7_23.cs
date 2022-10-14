// которая принимает на вход число и проверяет кратно ли оно 7 и 23 одновременно.
using System;
Console.WriteLine("Введите число");
string str=Console.ReadLine();
int i=int.Parse(str);
if(i%7==0 && i%23==0)
{
    Console.WriteLine("Число кратно 7 и 23");
}
else
{
    Console.WriteLine("Число не кратно 7 и 23");
}