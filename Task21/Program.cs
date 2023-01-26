// Напишите программу, 
// которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Write("Введите координаты точки xA -> ");
int xA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты точки yA -> ");
int yA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты точки zA -> ");
int zA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты точки xB -> ");
int xB = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты точки yB -> ");
int yB = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты точки zB -> ");
int zB = Convert.ToInt32(Console.ReadLine());
double distance = Distance(xA, yA, zA, xB, yB, zB);
double Distance(int xa, int ya, int za, int xb, int yb, int zb)
{
    int kat1 = xa - xb;
    int kat2 = ya - yb;
    int kat3 = za - zb;
    double result = Math.Sqrt(kat1 * kat1 + kat2 * kat2 + kat3 * kat3);
    return result;
}

double distanceRound = Math.Round(distance, 2, MidpointRounding.ToZero);
Console.WriteLine($"Расстояние = {distanceRound}");
