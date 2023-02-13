// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным 
// и минимальным элементами массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2


double[] CreateArrayRndDouble (int size, int min, int max)
{
    double[] arr = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        double num = rnd.NextDouble() * (max - min) + min;
        arr[i] = Math.Round(num, 1);
    }
    return arr;
}

double MaxNumber (double[] arr) 
{
    double maxNum = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        
        if (maxNum < arr[i])
        {
            maxNum = arr[i];
        }
        
    }
    return maxNum;
}

double MinNumber (double[] arr) 
{
    double minNum = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        
        if (minNum > arr[i])
        {
            minNum = arr[i];
        }
        
    }
    return minNum;
}


void PrintArrayDouble (double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if(i < arr.Length - 1) Console.Write($"{arr[i]}; ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}

double[] array = CreateArrayRndDouble(4, -99, 99);
double maxNumber = MaxNumber(array);
double minNumber = MinNumber(array);
PrintArrayDouble(array);
Console.WriteLine();
Console.WriteLine($"Разница чисел равна -> {Math.Round(maxNumber - minNumber, 1)}");