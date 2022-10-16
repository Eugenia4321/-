//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//В итоге получается вот такой массив:
//7 4 2 1
//9 5 3 2
//8 4 4 2

Console.Write("Введите число строк: ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Введите число столбцов: ");
int coloumn = int.Parse(Console.ReadLine()!);

int[,] intArray = CreateIntArray(row, coloumn);
FillIntArray(intArray);
PrintArray(intArray);
Console.WriteLine();
BubbleSort(intArray);
PrintArray(intArray);

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

void BubbleSort(int[,] anArray)
{
    for (int k = 0; k < anArray.GetLength(0); k++)
    {
        for (int i = 0; i < anArray.GetLength(1); i++)
        {
           
            for (int j = 0; j < anArray.GetLength(1) - 1 - i; j++)
            {
               
                if (anArray[k,j] < anArray[k ,j + 1])
                {
                   
                    int temp = anArray[k,j];
                    anArray[k,j] = anArray[k ,j + 1];
                    anArray[k ,j + 1] = temp;

                }
            }
        }
    }
}
