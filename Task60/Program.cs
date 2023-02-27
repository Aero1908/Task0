// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, 
// добавляя индексы каждого элемента.
// Например, задан массив размером 2 x 2 x 2.
// Результат:
// 66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
// 34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1)

void PrintMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                if (k < matrix.GetLength(2) - 1) Console.Write($"{matrix[i, j, k],4}({i},{j},{k}) ");
                else Console.Write($"{matrix[i, j, k],4}({i},{j},{k}) ");
            }
            
        }
        Console.WriteLine("|");
    }


}


int[,,] CreateMatrixRndInt(int rows, int columns, int hieght, int min, int max)
{
    int[,,] matrix = new int[rows, columns, hieght]; 
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                matrix[i, j, k] = rnd.Next(min, max + 1);
            }
        }
    }
    return matrix;
}

Console.WriteLine();
int[,,] matrix = CreateMatrixRndInt(2, 2, 2, 10, 100);
Console.WriteLine("Заданный массив:");
Console.WriteLine();
PrintMatrix(matrix);
Console.WriteLine();
