//Задача 52.Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Write("Введите число строк: ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Введите число столбцов: ");
int coloumn = int.Parse(Console.ReadLine()!);

int[,] intArray = CreateIntArray(row, coloumn);
FillIntArray(intArray);
PrintArray(intArray);
// ArithmeticMeanOfTheColumn(intArray);
double[] arithmeticMeanOfTheColumn = ArithmeticMeanOfTheColumn(intArray);
PrintArrayDouble(arithmeticMeanOfTheColumn);

double[] ArithmeticMeanOfTheColumn(int[,] arr)
{
    double[] arithmeticMeanOfTheColumn = new double[arr.GetLength(1)];
    for (int coloumns = 0; coloumns < arr.GetLength(1); coloumns++)
    {
        double sum = 0;
        for (int rows = 0; rows < arr.GetLength(0); rows++)
        {
            sum = sum + arr[rows, coloumns];
        }
        arithmeticMeanOfTheColumn[coloumns] = sum / arr.GetLength(0);
        //Console.WriteLine($"Среднее арифметическое {coloumns} столбца равно {arithmeticMeanOfTheColumn} ");
    }
    return arithmeticMeanOfTheColumn;
}

int[,] CreateIntArray(int row, int coloumn)
{
    int[,] array = new int[row, coloumn];
    return array;
}

void FillIntArray(int[,] collection)
{
    Random intRandomGenerator = new Random();
    for (int i = 0; i < collection.GetLength(0); i++)
    {
        for (int j = 0; j < collection.GetLength(1); j++)
        {
            collection[i, j] = intRandomGenerator.Next(0, 10);
        }
    }
}
void PrintArray(int[,] arr)
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
void PrintArrayDouble(double[] arr)
{
    for (int rows = 0; rows < arr.GetLength(0); rows++)
    {
        
            Console.Write($"| {arr[rows]} |");
       
    }
}