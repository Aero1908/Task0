// Задайте одномерный массив, 
// заполненный случайными числами. 
// Найдите сумму элементов, 
// стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0



int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}

void PrintArray(int[] massive)
{
    Console.Write("[");
    for (int i = 0; i < massive.Length; i++)
    {
        if (i < massive.Length - 1) Console.Write($"{massive[i]}, ");
        else Console.Write($"{massive[i]}");
    }
    Console.Write("]");
}

int ElementsCount(int[] massive)
{
    int result = 0;
    for (int i = 0; i < massive.Length; i++)
    {
        if (i % 2 != 0)
        result = result + massive[i];
    }
    return result;
}

int[] arr = CreateArrayRndInt(6, -50, 50);
PrintArray(arr);
int answer = ElementsCount(arr);
Console.WriteLine();
Console.WriteLine($"Сумма чисел с нечетным индексом -> {answer}");
