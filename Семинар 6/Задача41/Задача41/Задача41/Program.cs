// Задача 41: Пользователь вводит с клавиатуры число M, потом вводит M чисел ЧЕРЕЗ ENTER. Посчитайте, сколько чисел больше 0 ввёл пользователь.
using System;

Console.Clear();
Console.Write("Введите количество чисел: ");
int num = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите числа:");
int[] array = ReadNumbers(num);
Console.WriteLine($" Количество числе больше нуля равно {PositivNumbers(num, array)}");

int[] ReadNumbers(int num)
{
    int[] array = new int[num];
    for (int i = 0; i < num; i++)
    {
        array[i] = int.Parse(Console.ReadLine()!);

    }
    return array;
}

int PositivNumbers(int num, int[] array)
{
    int count = 0;
    for (int i = 0; i<num; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    return count;
}
