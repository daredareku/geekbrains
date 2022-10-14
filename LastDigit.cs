// программу которая принимает на вход трехзначное число и и на выходе показывает последнюю цифру этого числа.
    /// </summary>
    /// <returns>
using System;

string str=Console.ReadLine();
int i=int.Parse(str); // 
if(i>=100 && i<=999)
{
    int last=i%10;
    Console.WriteLine(last);
}
else
{
    Console.WriteLine("Error");
}
//int j=i % 10 * 10;

Console.WriteLine();