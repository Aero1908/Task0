//  Задайте прямоугольный двумерный массив. 
//  Напишите программу, которая будет находить строку 
//  с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке 
// и выдаёт номер строки с наименьшей суммой элементов: 1 строка





void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4} ");
            else Console.Write($"{matrix[i, j],4} ");
        }
        Console.WriteLine("|");
    }

}


int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns]; // 0, 1
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

int[] AverageMatrixRows(int[,] matrix)
{
    int[] result = new int[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            int num = matrix[i, j];
            sum = sum + num;
        }
        result[i] = sum;
    }
    return result;
}


int MinAverageRow(int[] massive)
{
    int row = 1;
    int min = massive[0];
    for (int i = 0; i < massive.Length; i++)
    {
        if(min > massive[i])
        {
            min = massive[i];
            row = i + 1;
        }
    }
    return row;
}

Console.WriteLine();
int[,] matrix = CreateMatrixRndInt(5, 4, 0, 10);
Console.WriteLine("Заданный массив:");
Console.WriteLine();
PrintMatrix(matrix);
Console.WriteLine();


int[] matrixAverage = AverageMatrixRows(matrix);
int minimalAvarege = MinAverageRow(matrixAverage);
Console.WriteLine($"{minimalAvarege}-ая строка с наименьшей суммой эллементов");
Console.WriteLine();

