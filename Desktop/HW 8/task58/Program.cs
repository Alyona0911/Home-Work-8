
// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int [,] ProductOfMatrices ( int [,] matrix1, int [,] matrix2)
{
    int [,] result = new int [matrix1.GetLength(0), matrix2.GetLength(1)];
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1) ; j++)
        {
           for (int k = 0; k < matrix1.GetLength(1) ; k++)
           {
            result[i,j] += matrix1[i,k] * matrix2 [k,j];
           }
        }
    }
    return result ;
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

int [,] FillArray (int row , int column , int start ,int finish)
{
    int [,] matr = new int [row , column];
    for( int i= 0; i < matr.GetLength(0) ; i++)
    {
        for(int j = 0 ; j < matr.GetLength(1) ; j++)
        {
            matr [i,j] = new Random().Next(start,finish) ;
        }   
    }
    return matr ;
}

int GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int row1 = GetInput("Введите  кол-во строк первой матрицы : ");
int column1 = GetInput("Введите кол-во столбцов первой матрицы : ");
int row2 = GetInput("Введите  кол-во строк второй матрицы : ");
int column2 = GetInput("Введите кол-во столбцов второй матрицы : ");
Console.WriteLine();
int [,] matrix1 = FillArray (row1,column1,1,10);
int [,] matrix2 = FillArray (row2,column2,1,10) ;
Console.WriteLine("первая матрица:");
PrintArray(matrix1) ;
Console.WriteLine("вторая матрица:");
PrintArray(matrix2) ;
int [,] result = ProductOfMatrices(matrix1,matrix2) ;
Console.WriteLine();
Console.WriteLine("Результирующая матрица");
PrintArray(result);
