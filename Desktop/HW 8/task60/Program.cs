// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

void PrintArray3D(int[,,] array3D)
{
    for (int k = 0; k < array3D.GetLength(2); k++)
    {
        for (int i = 0; i < array3D.GetLength(0); i++)
        {
            for (int j = 0; j < array3D.GetLength(1); j++)
            {
                Console.Write($"{array3D[i, j, k]}({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
    }
}

int[,,] GenerateRandomArray3D(int rowSize, int colSize, int zSize)
{
    int[] randomArray1D = new int[rowSize * colSize * zSize];
    int num;
    for (int n = 0; n < randomArray1D.Length; n++)
    {
        num = new Random().Next(10, 100);
        if (randomArray1D.Contains(num))
        {
            n--;
        }
        else
        {
            randomArray1D[n] = num;
        }
    }
    int[,,] randomArray3D = new int[rowSize, colSize, zSize];
    int index = 0;
    for (int i = 0; i < rowSize; i++)
    {
        for (int j = 0; j < colSize; j++)
        {
            for (int k = 0; k < zSize; k++)
            {
                randomArray3D[i, j, k] = randomArray1D[index];
                index++;
            }
        }
    }
    return randomArray3D;
}

int GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("Введите размеры трехмерного массива.");
int y = GetInput("Количество строк массива: ");
int x = GetInput("Количество столбцов массива: ");
int z = GetInput("Глубина массива: ");
int[,,] mas3D = GenerateRandomArray3D(y, x, z);
PrintArray3D(mas3D);