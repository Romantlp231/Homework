using System;

namespace Home_6
{
    class Program
    {
        static void Main(string[] args)

        {



            int[,] myarr;
            myarr = ArrInput();
            RandomArr(myarr);
            Console.WriteLine();
            PrintArr(myarr);
            Console.WriteLine();
            int inMaxRow = 0;
            int inMaxColum = 0;
            Max(myarr, out inMaxRow, out inMaxColum);
            int inMinRow = 0;
            int inMinColum = 0;
            Min(myarr, out inMinRow, out inMinColum);




        }
    


        private static void PrintArr(int[,] arr)
        {
            int imaxX = arr.GetLength(0);
            int imaxY = arr.GetLength(1);
            for (int x = 0; x < imaxX; x++)
            {
                for (int y = 0; y < imaxY; y++)
                {
                    Console.Write($"{arr[x, y]}   ");
                }
                Console.WriteLine();
            }

        }


        private static void RandomArr(int[,] arr1)
        {
            int imaxX = arr1.GetLength(0);
            int imaxY = arr1.GetLength(1);
            var rnd = new Random();

            for (int x = 0; x < imaxX; x++)
            {
                for (int y = 0; y < imaxY; y++)
                {
                   arr1[x, y] = rnd.Next(10, 30);
                }
            }
        }

       

        private static void Max(int[,] myarr, out int inMaxRow, out int inMaxColum)
        {
            inMaxRow = 0;
            inMaxColum = 0;

            int Max = myarr[0, 0];
            for (int i = 0; i < myarr.GetLength(0); i++)
            {
                for (int j = 0; j < myarr.GetLength(1); j++)
                {
                    if (myarr[i, j] > Max)
                    {
                        Max = myarr[i, j];
                        inMaxRow = i;
                        inMaxColum = j;
                    }
                }
            }
            
            Console.WriteLine($"Max значение = {Max}");
            Console.WriteLine($" Индекс Max значение = {inMaxRow},{inMaxColum}");

        }
        private static void Min(int[,] myarr,out int inMinRow, out int inMinColum)
        {
             inMinRow = 0;
             inMinColum = 0;
            int Min = myarr[0, 0];
            for (int i = 0; i < myarr.GetLength(0); i++)
            {
                for (int j = 0; j < myarr.GetLength(1); j++)
                {
                    if (myarr[i, j] < Min)
                    {
                        Min = myarr[i, j];
                        inMinRow = i;
                        inMinColum = j;
                    }
                }
            }
            Console.WriteLine($"Min значение = {Min}");
            Console.WriteLine($" Индекс Min значение = {inMinRow},{inMinColum}");

        }

        private static int[,] ArrInput()
        {
            Console.WriteLine("Введите число строк - ");
            int row = TrustOk2();
            Console.WriteLine("Введите число столбцов - ");
            int column = TrustOk2();
            int[,] myarr = new int[row, column];
            return  myarr;
        }

        private static int TrustOk2()
        {
            bool flag;

            while (true)
            {
                string input = Console.ReadLine();
                int num;
                flag = Int32.TryParse(input, out num);
                if (flag == true)
                {
                    if (num > 0)
                    {
                        return num;
                    }
                    else
                    {
                        Console.WriteLine("Ввели число не натуральное");
                    }

                }
                else
                {
                    Console.WriteLine("Вы ввели не число");
                }
            }

        }

        

       
    }

    
}
