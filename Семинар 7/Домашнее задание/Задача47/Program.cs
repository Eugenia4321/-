//Задача 47.Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9

Console.Write("Введите число строк: ");
int row = int.Parse(Console.ReadLine()!);

Console.Write("Введите число столбцов: ");
int coloumn = int.Parse(Console.ReadLine()!);
double[,] doubleArray = CreateDoubleArray(row, coloumn);
FillDoubleArray(doubleArray);
PrintArray(doubleArray);


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
            collection[i, j] = Math.Round(doubleRandomGenerator.Next(0, 10) + doubleRandomGenerator.NextDouble(),2);
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