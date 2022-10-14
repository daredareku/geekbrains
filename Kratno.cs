// ������� ������ ��� ����� � ������� ������ ��, ���� ����� 2 �� ������ ����� 1, �� ��������� ������� ������� �� �������.
// которая считывает два числа и определяет кратно ли первое второму. если число 2 не кратно числу 1, то выводит остаток от деления.
    /// </summary>
    /// <param name="value">The value.</param>
    /// <returns>System.Int32.</returns>
    using System;
Console.WriteLine("ВВедите два числа");
string input1=Console.ReadLine();
string input2=Console.ReadLine();
int n1=int.Parse(input1);
int n2=int.Parse(input2);
if(n1%n2==0)
{
    Console.WriteLine("Число 2 кратно числу 1");
}
else
{
    Console.WriteLine("Число 2 не кратно числу 1");
    Console.WriteLine("Остаток от деления: "+n1%n2);
}
