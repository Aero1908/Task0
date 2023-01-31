// Задача 44: Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8


Console.WriteLine("Введите число -> ");

int number = Convert.ToInt32(Console.ReadLine());

int[] Fibanaci(int num)
{
    int[] arr = new int[num];
    arr[1] = 1;
    for (int i = 2; i < arr.Length; i++)
    {
       arr[i] = arr[i - 1] + arr[i - 2];
    }
    return arr;
}

void PrintArray(int[] array)
{
    
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]} ");
        else Console.Write($"{array[i]}");
    }
    
}
int[] array = Fibanaci(number);

int[] fibanaci = Fibanaci(number);

PrintArray(array);