// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Clear();

Console.Write("Enter N: ");
int n = int.Parse(Console.ReadLine());

if (n<1)
{
    Console.WriteLine("not correct");
}
else
{
    int i=1;
    Console.Write($"{n}-> ");
    while (i<n)
    {
      Console.Write($"{i*i*i}, ");
      i++;
    }
    Console.Write(n*n*n);
}