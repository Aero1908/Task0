// Задайте значения M и N. Напишите программу, которая
// выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"

Console.Write("Введите первое натуральное число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе натуральное число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());



// int minNum = 0;
// int maxNum = 0;
// if(firstNumber < secondNumber) 
// {
//     minNum = firstNumber;
//     maxNum = secondNumber;
// }
// else if(firstNumber > secondNumber)
// {
//     minNum = secondNumber;
//     maxNum = firstNumber;
// }
// else Console.WriteLine("Ошибка! Введены одинаковые числа.");



void NaturalNumbers(int numM, int numN)
{
    if (numM < numN)
    {        Console.Write($"{numM} ");
        NaturalNumbers(numM + 1, numN);
    }
    else if (numM > numN)
    {
        NaturalNumbers(numM - 1, numN);
        Console.Write($"{numM} ");
        
    }
    else
        Console.WriteLine(numM);
}

Console.WriteLine();
NaturalNumbers(firstNumber, secondNumber);
