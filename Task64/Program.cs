// Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа 
// в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"


Console.WriteLine("Введите натуральное число N: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.Write($"N = {number} -> ");
Console.Write("\"");
NaturalNumber(number);
Console.Write("\"");
void NaturalNumber(int num)

{
if (num == 0) return;
Console.Write($"{num} ");
NaturalNumber(num - 1);
}