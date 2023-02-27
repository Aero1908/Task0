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

int[,] MatrixElemSum(int[,] firstMat, int[,] secondMat)
{
    int[,] sumMatrix = new int[firstMat.GetLength(0), secondMat.GetLength(1)];
    for (int m = 0; m < sumMatrix.GetLength(0); m++)
    {


        for (int i = 0; i < sumMatrix.GetLength(1); i++)
        {

            int count = 0;

            for (int j = 0; j < secondMat.GetLength(0); j++)
            {
                //  i, j             j, i
                count = count + firstMat[m, j] * secondMat[j, i];


            }
            sumMatrix[m, i] = count;
        }
        
        
    }
    return sumMatrix;
}


Console.WriteLine();
int[,] firstMatrix = CreateMatrixRndInt(3, 3, 0, 10);
Console.WriteLine("Первая заданная матрица:");
Console.WriteLine();
PrintMatrix(firstMatrix);
Console.WriteLine();
int[,] secondMatrix = CreateMatrixRndInt(2, 4, 0, 10);
Console.WriteLine("Вторая заданная матрица:");
Console.WriteLine();
PrintMatrix(secondMatrix);
Console.WriteLine();

// int[,] sumMatrixElem = MatrixElemSum(firstMatrix, secondMatrix);

if (firstMatrix.GetLength(1) == secondMatrix.GetLength(0))
{
    int[,] sumMatrixElem = MatrixElemSum(firstMatrix, secondMatrix);
    Console.WriteLine("Результат произведения двух заданных матриц: ");
    Console.WriteLine();
    PrintMatrix(sumMatrixElem);
    Console.WriteLine();
}
else
Console.WriteLine("Количество столбцов 1-й матрицы должно быть равно количеству строк 2-й матрицы");

