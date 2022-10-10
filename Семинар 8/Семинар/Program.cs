//Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

using System;
using System.Globalization;

Console.Write("Введите число строк: ");
int row = int.Parse(Console.ReadLine()!);

Console.Write("Введите число столбцов: ");
int coloumn = int.Parse(Console.ReadLine()!);
double[,] doubleArray = CreateDoubleArray(row, coloumn);
FillDoubleArray(doubleArray);
PrintArray(doubleArray);
Console.WriteLine();
//ChangeRows(doubleArray);
//PrintArray(doubleArray);
Console.WriteLine();

if (doubleArray.GetLength(0) == doubleArray.GetLength(1))
{
    double[,] newArray = ChangeRowsAndColumns(doubleArray);
    PrintArray(newArray);
}
else
{
    Console.WriteLine("nevozmozhmno");

}


double[,] CreateDoubleArray(int row, int coloumn)
{
    double[,] array = new double[row, coloumn];
    return array;
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

void ChangeRows (double[,] array)
{
    for (int j=0; j <array.GetLength(1);j++)
        {
        
            double m = array[0,j];
            array[0,j] = array[array.GetLength(0) - 1, j];
            array[array.GetLength(0) - 1, j] =m;
         }
}
//Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно, программа должна вывести сообщение для пользователя.
double[,] ChangeRowsAndColumns(double[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
        for (int j = i; j < array.GetLength(1); j++)
        { 
            double m = array[i, j];
            array[i, j] = array[j, i];
            array[j, i] = m;
        }
    }
    return array;
}