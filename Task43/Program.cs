//  Напишите программу, 
//  которая найдёт точку пересечения двух прямых, 
//  заданных уравнениями 
//  y = k1 * x + b1, y = k2 * x + b2; 
//  значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


using System.Globalization;
using System.Runtime.Intrinsics.X86;

Console.Write("Введите значение b1: ");

double number1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите значение k1: ");

double count1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите значение b2: ");

double number2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите значение k2: ");

double count2 = Convert.ToDouble(Console.ReadLine());

double spotX = SpotX(number1, count1, number2, count2);

double spotY = SpotY(number1, count1, number2, count2);

if(count1 == count2)
{
    Console.WriteLine($"b1 = {number1}, k1 = {count1}, b2 = {number2}, k2 = {count2} -> Прямые не пересекаются");
}
else
{
    Console.WriteLine($"b1 = {number1}, k1 = {count1}, b2 = {number2}, k2 = {count2} -> ({spotX}; {spotY})");
}

double SpotX(double b1, double k1, double b2, double k2)
{
    double numberX = (b2 - b1) / (k1 - k2);

    numberX = Math.Round(numberX, 2);

    return numberX;
}

double SpotY(double b1, double k1, double b2, double k2)
{
    double numberY = k1 * spotX + b1;

    numberY = Math.Round(numberY, 2);

    return numberY;
}



