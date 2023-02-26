// Задайте двумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец, на
// пересечении которых расположен наименьший элемент
// массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим
// следующий массив:
// 9 4 2
// 2 2 6
// 3 4 7


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

int[] MinElemIndex(int[,] array2D)
{
    int[] result = new int[2];
    int min = array2D[0, 0];
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            if(array2D[i, j] < min) 
            {
                min = array2D[i, j];
                result[0] = i;
                result[1] = j;
            }
        }
    }
    return result;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1)
            Console.Write($"{array[i]}; ");
        else Console.WriteLine($"{array[i]}. ");
    }

}

int[,] DeletedMinCross(int[,] array2D, int[] array)
{
    int rowCount = array2D.GetLength(0) - 1;
    int columnCount = array2D.GetLength(1) - 1;
    int[,] resultMatrix = new int[rowCount, columnCount];
    int m = 0;
    
    for (int i = 0; i < rowCount; i++)
    {
        if(m == array[0]) m++;
        int n = 0;
        for (int j = 0; j < columnCount; j++)

        {
            if(n == array[1]) n++;
            resultMatrix[i, j] = array2D[m, n];
            n++;
        }
        m++;
        
    }
    return resultMatrix;

}


Console.WriteLine();
int[,] matrix = CreateMatrixRndInt(5, 4, 0, 10);
Console.WriteLine("Заданный мфссив:");
PrintMatrix(matrix);
Console.WriteLine();

int[] indexArray = MinElemIndex(matrix);
PrintArray(indexArray);
Console.WriteLine();
int[,] correctMatrix = DeletedMinCross(matrix, indexArray);
PrintMatrix(correctMatrix);