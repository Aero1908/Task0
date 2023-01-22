// Напишите программу, 
// которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет. 
// Выполнить с помощью числовых операций 
// (целочисленное деление, остаток от деления).

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

Console.Write("Введите число: ");

int number = Convert.ToInt32(Console.ReadLine());

int thirdNum = ThirdNum(number);

int ThirdNum(int num)
{
    if(num > 99)
    {
        while(num > 999)
        {
            num = num / 10;
        }
        if(num < 1000)
        {
            num = num % 10;
            
            Console.WriteLine($"{num}");
        }       
           
    }
    else if(num < -99)
    {
        while(num < -999)
        {
            num = num / 10;
        }
        if(num > -1000)
        {
            num = num % 10;
            
            Console.WriteLine($"{-num}");
        }       
           
    }
    else
    {
        Console.WriteLine("Третьей цифры нет");
    }
        return num;
    
}


