// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


void SortingArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1) - 1; j++)
        {
            int colMax = j;
            for (int k = j + 1; k < array.GetLength(1); k++) 
            {
                if (array[i, k] > array[i, colMax])
                {
                    colMax = k;
                }
            }
            int buff = array[i, j];
            array[i, j] = array[i, colMax];
            array[i, colMax] = buff;
        }
    }
} 

void PrintArray(int [,] matr)
{
    for( int i= 0; i < matr.GetLength(0) ; i++)
    {
        for(int j = 0 ; j < matr.GetLength(1) ; j++)
        {
            Console.Write($"{matr[i,j]} ") ;
        }   
        Console.WriteLine();
    }
}

void FillArray(int [,] matr)
{
    for( int i= 0; i < matr.GetLength(0) ; i++)
    {
        for(int j = 0 ; j < matr.GetLength(1) ; j++)
        {
            matr [i,j] = new Random().Next(1,10) ;
        }   
        Console.WriteLine();
    }
}

int [,] matrix = new int [3,4] ;
FillArray (matrix);
PrintArray(matrix) ;
SortingArray(matrix) ;
Console.WriteLine();
PrintArray(matrix) ;
