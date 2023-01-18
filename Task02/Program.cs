// Напишите программу, 
// которая на вход принимает два числа и выдаёт,
//  какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3



Console.Write("Введите первое число: ");

int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");

int num2 = Convert.ToInt32(Console.ReadLine());
int max = num1;
int min = num2;

if (num1 > num2) 
{
    max = num1;
    min = num2;
}

else 
{
    max = num2;
    min= num1;
}
Console.Write("max = ");
Console.WriteLine(max);
Console.Write("min = ");
Console.WriteLine(min);