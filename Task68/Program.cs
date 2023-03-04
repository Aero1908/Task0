// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


Console.WriteLine("Введите число А ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.WriteLine("Введите число В ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int ack = AckNum(num1, num2);
Console.WriteLine($"{ack}");


int AckNum(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if ((m > 0) && (n == 0))
    {
        return AckNum(m - 1, 1);
    }
    else if ((m > 0) && (n > 0))
    {
        return AckNum(m - 1, AckNum(m, n - 1));
    }
    else
        return n + 1;
}
