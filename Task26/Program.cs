// Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5



// Console.WriteLine("Введите целое число: ");
// int number;
// if(int.TryParse(Console.ReadLine(), out number))
//     Console.WriteLine($"Количество цифр в числе -> {number} = {CountNumber(num)}");
// else Console.WriteLine("Введены некорректные данные");

// int count = 1;
// int countNumber = CountNumber(number);

// int CountNumber(int num)
// {

//     while (number > 0 || number < 0)
//     {
//         number = number / 10;
//         count++;
//     }
//     return count;
// }

int DigitsNumber(int num)
{
    int count = 0;
    while ((int)Math.Abs(num) > 0)
    {
        num = num / 10;
        count++;
    }
    return (count);
}

Console.Write("Введите целое число: ");
int number;
if (int.TryParse(Console.ReadLine(), out number))
    Console.WriteLine($"Количество цифр в числе {number} = {DigitsNumber(number)}");
else
    Console.WriteLine("Введено некорректное значение. Введите целое число");