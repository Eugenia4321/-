Console.Clear();

double average = CalcAverageFromConsole();
Console.WriteLine(average);


double CalcAverageFromConsole(double sum = 0, int count = 0)
{
    Console.Write("Введите десятичное число: ");
    double number = double.Parse(Console.ReadLine()!);

    if (number == -1)
        return sum / count;
    else
        return CalcAverageFromConsole(sum + number, count + 1);
}