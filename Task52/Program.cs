// Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.



int[,] array2D = CreateMatrixRndInt(3, 4, 1, 10);

PrintMatrix(array2D);

Console.WriteLine();

Console.Write("Среднее арифметическое каждого столбца: ");

double columnsAverage = ColumnsAverage(array2D);

Console.WriteLine();



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

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4} | ");
            else Console.Write($"{matrix[i, j],4} ");
        }
        Console.WriteLine();
    }
}

double ColumnsAverage(int[,] matrix)
{

    double num = 0;

    double averageNum = 0;

    for (int j = 0; j < matrix.GetLength(1); j++)
    {

        for (int i = 0; i < matrix.GetLength(0); i++)
        {

            num = num + matrix[i, j];
        }
        averageNum = num / matrix.GetLength(0);

        averageNum = Math.Round(averageNum, 1);

        if (j == matrix.GetLength(1) - 1)
        {
            Console.Write($"{averageNum}.  ");
        }

        else
        {
            Console.Write($"{averageNum};  ");
        }
        num = 0;
    }

    return averageNum;
}