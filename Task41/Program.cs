// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// -1, -7, 567, 89, 223-> 3



Console.Write("Введите величину массива: ");

int masSize = Convert.ToInt32(Console.ReadLine());

int createArray = CreateArray(masSize);

int CreateArray(int masSize)
{
    int res = 0;
   
    for (int i = 1; i <= masSize; i++)
    {
        Console.Write($"Введите {i}-ое число массива -> ");
        int masNum = Convert.ToInt32(Console.ReadLine());
        
        if(masNum > 0)
        {
            res++;
        }
        
    }
    Console.WriteLine();
    Console.WriteLine($"Чиссел больше нуля = {res}");
    return res;
    
}

// int[] Massive(int masSize, int masNum)
// {
//     int[] array = new int[masSize];
    
//     for (int i = 0; i < masSize; i++)
//     {
//         array[i] = masNum;
//     }
//     return array;
// }

// int massive = Massive(masSize);