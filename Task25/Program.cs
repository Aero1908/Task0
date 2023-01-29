//  Напишите цикл, который принимает на вход два числа (A и B) 
//  и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16


Console.Write("Введите число -> ");

int number = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите степень -> ");

int numPower = Convert.ToInt32(Console.ReadLine());

int Exponentiate(int num)
{
    int count = num;
    for (int i = 1; i < numPower; i++)
    {
        count = count * num + (i * 0);
    }
    return count;
}

if(numPower > 0)
{
    Console.WriteLine($"{Exponentiate(number)}");
}

else
{
    Console.WriteLine("Введите натуральное число степени.");
}

