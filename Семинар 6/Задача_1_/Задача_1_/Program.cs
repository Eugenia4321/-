// Написать программу, которая рекурсивным методом переводит числа из десятичной системы счисления в двоичную

Console.Write($"Введите число: ");
int num = int.Parse(Console.ReadLine()!);
double N = Ffff(num);
Console.WriteLine($"Число {num} в двоичной системе счисления будет {N}");

double Ffff(int number, int counter = 0,double sum = 0)
{
    if (number < 2)
    {
        sum = sum + +number % 2 * Math.Pow(10, counter);
        return sum;
    }
    else
    {
        sum = sum + number % 2 * Math.Pow(10, counter);
        return Ffff(number / 2,counter+1, sum);
    }  
}
