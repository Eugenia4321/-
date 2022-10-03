// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
// Ограничения:
// - Должна быть отдельная функция, которая возвразает результат суммы цифр
// - Внутри функций НЕЛЬЗЯ использовать класс Console. Только в основном блоке кода

Console.Clear();

Console.Write("Число = ");
int number = int.Parse(Console.ReadLine()!);
int summNumbers=SummNumbers(number);
Console.WriteLine($"Сумма цифр в числе {number} равно {summNumbers}");

int SummNumbers(int number)
{
    int summa = 0;
    while (Math.Abs(number)>0)
    {
        summa=summa+Math.Abs(number%10);
        number=number/10;
    }
      
    return summa;
}