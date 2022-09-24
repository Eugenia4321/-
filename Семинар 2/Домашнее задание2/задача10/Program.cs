// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.Clear();
Console.Write("Введите число = ");
int number = int.Parse(Console.ReadLine());
int number2 = number%100/10;
Console.WriteLine($"Вторая цифра цисла {number} = {number2}");
