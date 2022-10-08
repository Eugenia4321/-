// Написать программу, которая рекурсивным методом переводит числа из десятичной системы счисления в двоичную
using System.Diagnostics.Metrics;

Console.Write($"Введите число: ");

int num = int.Parse(Console.ReadLine()!);
double N = Ffff(num);
Console.WriteLine($"Число {num} в двоичной системе счисления будет {N}");


double Ffff(int number, int counter = 0,double sum = 0)
{
    if (number < 2)
    {
        //Console.WriteLine(number % 2);
        sum = sum + +number % 2 * Math.Pow(10, counter);
        //Console.WriteLine($" выход из рекурсии тут  sum {sum} number % 2 {number % 2} Math.Pow(10, counter); {Math.Pow(10, counter)} ");
        return sum;

    }
    else
    {
        sum = sum + number % 2 * Math.Pow(10, counter);
        //Console.WriteLine(sum);
        //Console.WriteLine($"  sum {sum} number % 2 {number % 2} Math.Pow(10, counter); {Math.Pow(10, counter)} ");

        return Ffff(number / 2,counter+1, sum);

    }

   
}