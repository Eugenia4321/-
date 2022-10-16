//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7

//Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка(нумерация строк начинается с 1)


Console.Write("Введите число строк: ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Введите число столбцов: ");
int coloumn = int.Parse(Console.ReadLine()!);

int[,] intArray = CreateIntArray(row, coloumn);
FillIntArray(intArray);

Console.WriteLine();
int[] minSumPowArray = MinSummPowArray(intArray);
int minPowIndex = MinPow(minSumPowArray)+1;
PrintArray(intArray, minSumPowArray);
Console.Write($"Hомер строки с наименьшей суммой элементов: {minPowIndex}");

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

void PrintArray(int[,] arr, int[] minSumPowArray)
{
    for (int rows = 0; rows < arr.GetLength(0); rows++)
    {
        for (int coloumns = 0; coloumns < arr.GetLength(1); coloumns++)
        {
            Console.Write($"| {arr[rows, coloumns]} |");
        }
        Console.Write($" sum({rows+1}) = {minSumPowArray[rows]}");
        Console.WriteLine();
    }
}

int[] MinSummPowArray(int[,] anArray)
{
    int minSummIndex = int.MinValue;
    int[] arraySumPow = new int[anArray.GetLength(0)];
    for (int k = 0; k < anArray.GetLength(0); k++)
    {
        for (int i = 0; i < anArray.GetLength(1); i++)
        {
            arraySumPow[k] = arraySumPow[k] + anArray[k, i];

        }
        
    }
    return arraySumPow;
}

int MinPow (int[] anArray)
{
      int minIndex = 0;
      int min = anArray[0];
    for (int i = 0; i < anArray.Length; i++)
    {
        if (anArray[i] <min)
        {
            min=anArray[i];
            minIndex = i ;
        }
    }
    return minIndex;

}