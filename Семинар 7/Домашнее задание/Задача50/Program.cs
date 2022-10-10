//Задача 50.Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//1
//7->такого числа в массиве нет


Console.Write("Введите число строк: ");
int row = int.Parse(Console.ReadLine()!);

Console.Write("Введите число столбцов: ");
int coloumn = int.Parse(Console.ReadLine()!);
double[,] doubleArray = CreateDoubleArray(row, coloumn);
FillDoubleArray(doubleArray);
PrintArray(doubleArray);

Console.Write("Введите номер строки: ");
int searchingRow = int.Parse(Console.ReadLine()!);
Console.Write("Введите номер столбца: ");
int searchingColoumn = int.Parse(Console.ReadLine()!);
SearchingItem(doubleArray, searchingRow, searchingColoumn);


double[,] CreateDoubleArray(int row, int coloumn)
{
    double[,] array = new double[row, coloumn];
    return array;
}

void SearchingItem(double[,] collection, int row, int coloumn )
{
    if ((row > collection.GetLength(0)-1) || (coloumn-1 > collection.GetLength(1)-1))
            {
        Console.WriteLine("такого числа в массиве нет");
        }
    else
    {
        Console.WriteLine($"Значение элемента [{row},{coloumn}] равно {collection[row,coloumn]}");

    }
}
void FillDoubleArray(double[,] collection)
{
    Random doubleRandomGenerator = new Random();
    for (int i = 0; i < collection.GetLength(0); i++)
    {
        for (int j = 0; j < collection.GetLength(1); j++)
        {
            collection[i, j] = Math.Round(doubleRandomGenerator.Next(0, 10) + doubleRandomGenerator.NextDouble(), 2);
        }
    }
}
void PrintArray(double[,] arr)
{
    for (int rows = 0; rows < arr.GetLength(0); rows++)
    {
        for (int coloumns = 0; coloumns < arr.GetLength(1); coloumns++)
        {
            Console.Write($"| {arr[rows, coloumns]} |");
        }
        Console.WriteLine();
    }
}