//
using System;

namespace Application
{

    public class Program
    {
        abstract public class Base
        {
            public abstract void Print();
        }

        class Derived : Base
        {
            public override void Print()
            {
                Console.WriteLine("Derived");
            }
        }

        abstract public class KV : Base
        {
            
            public override void Print()
            {
                Console.WriteLine("KV ");
            }

            // public abstract void Print(); // override is not required

        }




        static void MainTV(string[] args)
        {
        }

        static void MainKV(string[] args)
        {
            // KV - К Встреча KV - � �������
            double[,] arr = new double[3, 3];
            arr[0, 0] = 1;
            arr[0, 1] = 2;
            arr[0, 2] = 3;
            arr[1, 0] = 4;
            arr[1, 1] = 5;
            arr[1, 2] = 6;
            arr[2, 0] = 7;
            arr[2, 1] = 8;
            arr[2, 2] = 9;

            double[,] arr2 = new double[3, 3];
            arr2[0, 0] = 1;
            arr2[0, 1] = 2;
            arr2[0, 2] = 3;
            arr2[1, 0] = 4;
            arr2[1, 1] = 5;
            arr2[1, 2] = 6;
            arr2[2, 0] = 7;
            arr2[2, 1] = 8;
            arr2[2, 2] = 9;

            double[,] arr3 = new double[3, 3];
            arr3[0, 0] = 1;
            arr3[0, 1] = 2;
            arr3[0, 2] = 3;
            arr3[1, 0] = 4;
            arr3[1, 1] = 5;
            arr3[1, 2] = 6;
            arr3[2, 0] = 7;
            arr3[2, 1] = 8;
            arr3[2, 2] = 9;

            double[,] arr4 = new double[3, 3];
            arr4[0, 0] = 1;
            arr4[0, 1] = 2;
            arr4[0, 2] = 3;
            arr4[1, 0] = 4;
            arr4[1, 1] = 5;
            arr4[1, 2] = 6;
            arr4[2, 0] = 7;
            //arr4[2, 1] =
        }
 
        static void Main(string[] args)
        {
            System.Console.WriteLine("Hello World 2022!");

        }
 
    }

}