using System;

namespace ConsolleApp
{
     class Program
     {
        static void Main(string[] args)
        {//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами, округлёнными до одного знака
            void Zadacha52()
            {
            Random random=new Random() ; 
            int rows=random.Next(2,4);
            int columns=random.Next(2,6);
            int[,] array=new int[rows,columns];
             FillArray(array);
             PrintArray(array);
             int sum=0;

             Console.WriteLine("среднее арифметическое по столбцам ");

             for(int j = 0;j < columns; j++)
             {
                 for (int i = 0;i < rows; i++)
                 {
                    sum += array[i, j];
                 }
                 Console.Write(sum/ rows + "\t");
             }
             Console.WriteLine();
            }
             Zadacha52();

            static void FillArray(int[,] array)
            {
                Random random=new Random();
                int rows=array.GetLength(0);
                int columns=array.GetLength(1);

                for (int i = 0;i < rows; i++)
                {for(int j = 0;j < columns; j++)
                {
                    array[i,j]=random.Next(-9,9) ;
                }
                }
            }

            static void PrintArray(int[,] array)
            {
            Console.WriteLine();
            Console.WriteLine(" массив ");

                int rows= array.GetLength(0);
                int columns= array.GetLength(1);

                for (int i = 0;i < rows ; i++)
                {
                    for(int j = 0;j < columns; j++)
                {
                   Console.Write(array[i,j] + " \t ");
                }
                }
                Console.WriteLine();
            }
           
                
        
        }
        
     }
    
}