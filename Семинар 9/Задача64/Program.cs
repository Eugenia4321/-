//Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

//N = 5 -> "5, 4, 3, 2, 1"
//N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Write("Задайте значение N: ");
int n = int.Parse(Console.ReadLine()!);
Console.Write($"{n} -> ");
PrintNRec(n);

int PrintNRec(int n)
{
    if (n == 1)
    {
        Console.WriteLine(n);
        return 1;
    }
    else
    {
        Console.Write($"{n}, ");
        return PrintNRec(n - 1);
    }
    
}