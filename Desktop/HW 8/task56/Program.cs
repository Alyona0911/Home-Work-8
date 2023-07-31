// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

void SumOfRow(int [,] matr)
{
    int minSum = 0;
    int rowMinSum = 0;
    for( int i= 0; i < matr.GetLength(0) ; i++)
    {
        int sum = 0;
        for(int j = 0 ; j < matr.GetLength(1) ; j++)
        {
            sum += matr[i,j]; 
        }
        if (i == 0) minSum = sum;
        if (sum < minSum)
        {
            minSum = sum;
            rowMinSum = i;
        }
    }
    Console.Write($"{rowMinSum +1 } строка содержит минимальную сумму элементов");
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

int [,] matrix = new int [5,4] ;
FillArray (matrix);
PrintArray(matrix) ;
Console.WriteLine();
SumOfRow(matrix);


