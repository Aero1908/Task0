// Напишите программу, 
// которая принимает на вход пятизначное число и 
// проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да



Console.WriteLine("Введите число");

int number = Convert.ToInt32(Console.ReadLine());
int count;
int reverse = 0;
int num = number;

while (num > 0 || num < 0)
{

    count = num % 10;

    reverse = (reverse * 10) + count;

    num = num / 10;
}


if (number == reverse)
{
    Console.WriteLine($"{number} -> ДА");
}
else
{
    Console.WriteLine($"{number} -> НЕТ");
}


