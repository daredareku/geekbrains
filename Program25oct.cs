// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

int[,] CreateArray1(int m, int n)
        {
            int[,] array = new int[m, n];

            Random random = new Random();

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = random.Next(1, 20);
                }
            }

            return array;
        }


//static 
int[,] Main59(int[,] arr)
        {
            //static 
            int[,] array = CreateArray1(5, 5);
            int
                min = 0;//,
                //count = 0;
            int
                minx = 0,
                miny = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    //arr[i, j] = array[i, j];
                    min = arr[i, j];
                    for (int k = 0; k < arr.GetLength(0); k++)
                    {
                        for (int l = 0; l < arr.GetLength(1); l++)
                        {
                            if (arr[k, l] < min)
                            {
                                min = arr[k, l];
                                minx = k;
                                miny = l;
                            }
                        }
                    }
                    System.Console.WriteLine (min);
                }
            }
            int[,] newArray = CreateArray1(5, 5);//{//(5 - 1, 5 - 1);
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (i != minx && j != miny)
                    {
                        newArray[i, j] = arr[i, j];
                    }
                }
            }

            return newArray;
        }

            double[,] arr = new double[5, 5];
            int[,] arr1 = new int[5, 5];
//            Main57 (arr1);

Main59(arr1);