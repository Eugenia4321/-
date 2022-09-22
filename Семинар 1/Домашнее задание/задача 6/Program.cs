// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Console.Clear();
Console.Write("Number= ");
int number = int.Parse(Console.ReadLine());
if (number%2==0) Console.WriteLine($"The number={number} is even");
else   Console.WriteLine($"The number={number} is odd");

