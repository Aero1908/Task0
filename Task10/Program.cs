// Напишите программу, 
// которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа. 
// Выполнить с помощью числовых операций 
// (целочисленное деление, остаток от деления).

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Введите трёхзначное число: ");

int number = Convert.ToInt32(Console.ReadLine());

bool threeDigit = ThreeDigit(number);

int secondDigit = number / 10 % 10;

bool ThreeDigit(int num)
{
   return num > 99 && num < 1000;
}
Console.WriteLine(threeDigit ? $"{secondDigit}": "Введено некорректное число");





