// Напишите программу, 
// которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента 
// или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 1, 7 -> такого элемента в массиве нет

// string[] aDot = Console.ReadLine().Split(new Char[] {' '});


Console.WriteLine("Введите позиции элементов двумерного массива:");

int rowNum = Convert.ToInt32(Console.ReadLine());

int columnNum = Convert.ToInt32(Console.ReadLine());

int[,] array2D = CreateMatrixRndInt(5, 7, -100, 100);

PrintMatrix(array2D);

Console.WriteLine();

PrintElement(array2D);


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
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4} | ");
            else Console.Write($"{matrix[i, j],4} ");
        }
        Console.WriteLine("|");
    }
}


void PrintElement(int[,] matrix)
{
    if (rowNum < 0 || columnNum < 0)
    {
        Console.WriteLine($"{rowNum}, {columnNum} -> Значение не может принимать отрицательные числа");
    }

    else
    {
        if (rowNum <= matrix.GetLength(0) && columnNum <= matrix.GetLength(1))
        {
            Console.WriteLine($"{rowNum}, {columnNum} -> {array2D[rowNum, columnNum]}");
        }
        else
        {
            Console.WriteLine($"{rowNum}, {columnNum} -> такого элемента в массиве нет");
        }
    }
}
