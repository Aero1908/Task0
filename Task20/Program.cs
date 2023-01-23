//  Напишите программу, которая
// принимает на вход координаты двух точек и
// находит расстояние между ними в 2D
// пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21






Console.Write("Введите координаты точки x1 -> ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты точки y1 -> ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты точки x2 -> ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты точки y2 -> ");
int y2 = Convert.ToInt32(Console.ReadLine());
double distance = Distance(x1, y1, x2, y2);
double Distance(int xa, int ya, int xb, int yb)
{
    int kat1 = xa - xb;
    int kat2 = ya - yb;
    double result = Math.Sqrt(kat1 * kat1 + kat2 * kat2);
    return result;
}

double distanceRound = Math.Round(distance, 2, MidpointRounding.ToZero);
Console.WriteLine($"Расстояние = { distanceRound}");
