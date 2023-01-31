
// Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник
// с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.
// 


Console.Write("Введите первое число -> ");

int aDot = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число -> ");

int bDot = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье число -> ");

int cDot = Convert.ToInt32(Console.ReadLine());

bool SideSum(int a,int b,int c)
{
    if(a + b > c && a + c > b && b + c > a)
    {
        return true;
    }
    else 
    {
        return false;
    }

}

bool sideSum = SideSum(aDot, bDot, cDot);

// int result = true ? false;

Console.Write(sideSum ? "да" : "нет");
