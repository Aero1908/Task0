// Напишите программу, 
// которая принимает на вход число 
// и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12





// int count = number % 10;
// int number = number / 10;
// int i = 0;
// i = i + count;

using System.Diagnostics.CodeAnalysis;

Console.Write("Введите число -> ");

int number = Convert.ToInt32(Console.ReadLine());

int NumbersSum(int num)
{
    int sum = 0;
    int count = 0;
    while((int)Math.Abs(num) / 10 > 0)
    {
        count = num % 10;
        sum = sum + count;
        num = num / 10;
    }
        sum = (sum + num % 10) * -1;
    
    return sum;
}

if(number < 0)
{
    Console.WriteLine($"сумма чисел равна -> {NumbersSum(number)}");
}
else
{
    Console.WriteLine($"сумма чисел равна -> {NumbersSum(number) * -1}");
}

