// которая на входе принимает два числа, и выдает какое число больше, а какое меньше.
// Если числа равны, то выдает сообщение "Числа равны".

namespace Application
{
    

public class numbers14OCT2022
{
    static void Main1(string[] args)
    {
        Console.WriteLine("Введите первое число");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите второе число");
        int b = Convert.ToInt32(Console.ReadLine());
        if (a > b)
        {
            Console.WriteLine("Первое число больше второго");
        }
        else if (a < b)
        {
            Console.WriteLine("Второе число больше первого");
        }
        else
        {
            Console.WriteLine("Числа равны");
        }
    }
//}
//{
    
//}

// которая на входе принимает три числа, и выдает максимальное из них.

//class numbers14OCT2022
//{
    static void Main2(string[] args)
    {
        Console.WriteLine("Введите п");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите в)");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите с");
        int c = Convert.ToInt32(Console.ReadLine());
        int max = a > b ? a : b;
        if (c > max)
        {
            max = c;
        }
        /*
        { 


        }
        else if (c < b)
        {
        }
        else if (a < c)
        {

        }

        else
        {
        }
        */
        Console.WriteLine(max);
    }
//}

// которая на входе принимает число, и выдает является ли оно четным или нечетным. (делится на 2 без остатка или с остатком)
//

//class numbers14OCT2022
//{
    static void Main3(string[] args)
    {
        Console.WriteLine("Введите п");
        int a = Convert.ToInt32(Console.ReadLine());
        if (a % 2 == 0)
        {
            Console.WriteLine("Число четное");
        }
        else
        {
            Console.WriteLine("Число нечетное");
        }
        {
            //  
        }
    }
//}

// которая на входе принимает число, и выдает все чётные числа от 1 до этого числа.

//class numbers14OCT2022
//{
    static void Main4(string[] args)
    {
        Console.WriteLine("Введите п);");
        int a = Convert.ToInt32(Console.ReadLine());
        int length = a;
        for (int i = 0; i < length; i++)
        {
            Console.WriteLine(" "+ (i+1));
        }
    }
}

//program.Run();
class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
    
    
//{    
    numbers14OCT2022.Main1();
    Main2();
    Main3();
    Main4();

        }
        }
}
