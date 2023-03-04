// Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов 
// в промежутке от M до N. Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


Console.WriteLine("Введите число M ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.WriteLine("Введите число N ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();


int minNum = 0;
int maxNum = 0;
if (num1 < num2)
{
    minNum = num1;
    maxNum = num2;
}
else if (num1 > num2)
{
    minNum = num2;
    maxNum = num1;
}
else Console.WriteLine($"{0}");

int sumNum = SumNumbers(minNum, maxNum);
Console.WriteLine();
Console.WriteLine($"Сумма чисел от {minNum} до {maxNum} = {sumNum}");


int SumNumbers(int number1, int number2)
{
    if (number1 == number2) return number2;
    else return number1 + SumNumbers(number1 + 1, number2);
}