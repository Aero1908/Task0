// Задайте две матрицы. 
// Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


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

int [,] MatrixElemSum(int[,] firstMat, int[,] secondMat)
{
    int[,] sumMatrix = new int[firstMat.GetLength(0), firstMat.GetLength(1)];

    for (int i = 0; i < sumMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < sumMatrix.GetLength(1); j++)
        {
            sumMatrix[i, j] = firstMat[i, j] + secondMat[i, j];
        }
    }
    return sumMatrix;
}


Console.WriteLine();
int[,] firstMatrix = CreateMatrixRndInt(5, 4, 0, 10);
Console.WriteLine("Первый заданный массив:");
Console.WriteLine();
PrintMatrix(firstMatrix);
Console.WriteLine();
int[,] secondMatrix = CreateMatrixRndInt(5, 4, 0, 10);
Console.WriteLine("Второй заданный массив:");
Console.WriteLine();
PrintMatrix(secondMatrix);
Console.WriteLine();
int[,] sumMatrixElem = MatrixElemSum(firstMatrix, secondMatrix);
Console.WriteLine("Массив с суммой соответствующих элементов заданных массивов: ");
Console.WriteLine();
PrintMatrix(sumMatrixElem);
Console.WriteLine();