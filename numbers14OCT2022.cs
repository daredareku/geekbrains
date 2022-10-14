// которая на входе принимает два числа, и выдает какое число больше, а какое меньше.
// Если числа равны, то выдает сообщение "Числа равны".

namespace Application
{
    public class numbers
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
        // которая на входе принимает три числа, и выдает максимальное из них.

        static void Main2(string[] args)
        {
            Console.WriteLine("Введите первое число");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число;");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите третье число");
            int c = Convert.ToInt32(Console.ReadLine());
            int max = a > b ? a : b;
            if (c > max)
            {
                max = c;
            }
            Console.WriteLine(max);
        }

        // которая на входе принимает число, и выдает является ли оно четным или нечетным. (делится на 2 без остатка или с остатком)
        //

        static void Main3(string[] args)
        {
            Console.WriteLine("Введите первое число");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a % 2 == 0)
            {
                Console.WriteLine("Число четное");
            }
            else
            {
                Console.WriteLine("Число нечетное");
            }
        }

        // которая на входе принимает число, и выдает все чётные числа от 1 до этого числа.
        static void Main4(string[] args)
        {
            Console.WriteLine("Введите первое число");
            int a = Convert.ToInt32(Console.ReadLine());
            int length = a;
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine(" " + (i + 1));
            }
        }
        public class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Hello World 2022!");
                numbers.Main1(null);
                numbers.Main2(null);
                numbers.Main3(null);
                numbers.Main4(null);
            }
        }
    }
}
