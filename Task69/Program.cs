// Напишите программу, которая на вход принимает два числа A и B, и
// возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8



Console.WriteLine("Введите число А ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.WriteLine("Введите число В ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int power = PowerNumbers(num1, num2);
Console.WriteLine();
Console.WriteLine($"{num1} в степени {num2} равно {power}");


int PowerNumbers(int number1, int number2)
{
    if (number2 == 0) return 1;
    else return number1 * PowerNumbers(number1, number2 - 1);
}