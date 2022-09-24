// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.Clear();
Console.Write("First number = ");
int numberFirst = int.Parse(Console.ReadLine());
Console.Write("Second number = ");
int numberSecond = int.Parse(Console.ReadLine());
Console.Write("Third number = ");
int numberThird = int.Parse(Console.ReadLine());
int max = numberFirst;
if (numberSecond>max) max=numberSecond;
if(numberThird>max) max=numberThird;

Console.WriteLine($"max = {max}");
