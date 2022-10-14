// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
// которая на входе принимает число, и выдает из всех  чисел от 1 до этого 99, наибольшую цифру из этого числа.
Console.WriteLine("Введите первое число");
int a = Convert.ToInt32(Console.ReadLine());
first=a/10;
second=a%10;
if (first > second){
    Console.WriteLine(first);
}
else{
    Console.WriteLine(second);
}