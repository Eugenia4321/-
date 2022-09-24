// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.Clear();
Console.Write("Введите день недели = ");
int number = int.Parse(Console.ReadLine());
if (number<1 || number>7)
{
    Console.WriteLine("Ошибка! Такого дня недели нет");
}
else if (number==6 || number==7)
{
    Console.WriteLine("Это выходной день!");
}
else
{
    Console.WriteLine("Это не выходной день");
}