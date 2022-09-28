// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
Console.Clear();

Console.Write("Enter XA: ");
int x0 = int.Parse(Console.ReadLine());
Console.Write("Enter YA: ");
int y0 = int.Parse(Console.ReadLine());
Console.Write("Enter ZA: ");
int z0 = int.Parse(Console.ReadLine());

Console.Write("Enter XB: ");
int x1 = int.Parse(Console.ReadLine());
Console.Write("Enter YB: ");
int y1 = int.Parse(Console.ReadLine());
Console.Write("Enter ZB: ");
int z1 = int.Parse(Console.ReadLine());

double s = Math.Sqrt((x1-x0)*(x1-x0)+(y1-y0)*(y1-y0)+(z1-z0)*(z1-z0));

Console.WriteLine($"A({x0},{y0},{z0}); B({x1},{y1},{z1}) -> {Math.Round(s,2)}");