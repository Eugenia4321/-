// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.Clear();
Console.Write("Введите число = ");
int number = int.Parse(Console.ReadLine());

if ((number<100)&&(number>-100))
{
    Console.WriteLine("третьей цифры нет");
}
else 
{
     int number3 = Math.Abs(number%1000/100);                                
    Console.WriteLine($"Третья цифра числа {number} = {number3}");
    
}