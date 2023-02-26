// Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент
// входных данных.





using System.Collections;

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

int[] AllNumbersArray(int[,] array2D)
{
    int arraySize = array2D.GetLength(0) * array2D.GetLength(1);
    int[] array = new int[arraySize];
    int count = 0;
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            array[count] = array2D[i, j];
            count++;
        }
    }
    return array;
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

// void SortNumbers(int[] array)
// {
//     int count = 1;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (i < array.Length - 1)

//             if (array[i] == array[i + 1])
//                 if (i + 1 == array.Length - 1)
//                 {
//                     count++;
//                     Console.WriteLine($"{array[i]} встречается {count} раз");
//                 }
//                 else
//                 {
//                     count++;
//                 }

//             else
//             {

//                 Console.WriteLine($"{array[i]} встречается {count} раз");
//                 count = 1;
//             }

//         else
//         {
//             if (array[i] != array[i - 1])
//                 Console.WriteLine($"{array[i]} встречается {count} раз");
//         }


//     }
// }

void FrequencyDictionary(int[] array)
{
    int count = 1;
    int num = array[0];

    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] == num)
            count++;
        else
        {
            Console.WriteLine($"{num} встречается {count} раз");
            num = array[i];
            count = 1;
        }
    }
    Console.WriteLine($"{num} встречается {count} раз");
}



Console.WriteLine();
int[,] matrix = CreateMatrixRndInt(5, 4, 0, 10);
Console.WriteLine("Заданный мфссив:");
PrintMatrix(matrix);
Console.WriteLine();
int[] allNumberArray = AllNumbersArray(matrix);
Console.WriteLine("Все числа:");
Array.Sort(allNumberArray);
PrintArray(allNumberArray);
Console.WriteLine();
// SortNumbers(allNumberArray);
FrequencyDictionary(allNumberArray);

