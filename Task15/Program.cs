// Напишите программу, 
// которая принимает на вход цифру, 
// обозначающую день недели, 
// и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите число: ");

int number = Convert.ToInt32(Console.ReadLine());

int weekDay = WeekDay(number);

int WeekDay(int num)
{
    if(num > 0 && num < 8)
    {

        if(num < 6 && num > 0)
        {
            Console.Write("Нет");
        }
        else
        {
            Console.Write("Да");
        }
    }
    else
    {
        Console.WriteLine("Некорректные данные");
    }
return num;
}