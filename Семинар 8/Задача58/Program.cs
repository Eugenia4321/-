//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
//Например, даны 2 матрицы:

//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7
//и
//1 5 8 5
//4 9 4 2
//7 2 2 6
//2 3 4 7
//Их произведение будет равно следующему массиву:
//1 20 56 10
//20 81 8 6
//56 8 4 24
//10 6 24 49


Console.Write("Введите число строк первой матрицы: ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Введите число столбцов первой матрицы: ");
int coloumn = int.Parse(Console.ReadLine()!);
int[,] intArrayOne = CreateIntArray(row, coloumn);
FillIntArray(intArrayOne);
Console.WriteLine();
PrintArray(intArrayOne);
Console.WriteLine();
Console.Write("Введите число строк второй матрицы: ");
int row1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите число столбцов второй матрицы: ");
int coloumn1 = int.Parse(Console.ReadLine()!);
Console.WriteLine();
int[,] intArrayTwo = CreateIntArray(row1, coloumn1);
FillIntArray(intArrayTwo);
PrintArray(intArrayTwo);
Console.WriteLine();

int[,] intArrayTest1 = {{ 1, 4, 7, 2 },
                     { 5, 9, 2, 3},
                     { 8, 4, 2, 4},
                     { 5 ,2, 6, 7 } };
int[,] intArrayTest2 = {{ 1, 5, 8, 5 },
                     { 4, 9, 4, 2},
                     { 7, 2, 2, 6},
                     { 2 ,3, 4, 7 } };

if (coloumn != row1)
{
    Console.WriteLine("Матрицы не совместимы");
}
else
{
    Console.WriteLine();
    Console.WriteLine("Произведение матриц(математическое) :");
    int[,] matrixMultiplication = MatrixMultiplication(intArrayOne, intArrayTwo);
        PrintArray(matrixMultiplication);
    Console.WriteLine();
    
    int[,] matrixMultiplication1 = NewArrayKakVPrimere(intArrayOne, intArrayTwo);
    Console.WriteLine("Произведение матриц(как в примере в задании) :");
    PrintArray(matrixMultiplication1);
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


int[,] MatrixMultiplication(int[,] arrayOne, int[,] arrayTwo)
{
    int[,] newArray = new int[arrayOne.GetLength(0), arrayTwo.GetLength(1)];
    for (int i = 0; i < newArray.GetLength(0); i++)
    {
        for (int j = 0; j < newArray.GetLength(1); j++)
        {
            newArray[i, j] = MatrixMultiplicationItem(arrayOne, arrayTwo, i, j);
           
        }
    }
    return newArray;
}
int[,] NewArrayKakVPrimere(int[,] arrayOne, int[,] arrayTwo)
{
    int minPow = arrayTwo.GetLength(0);
    int minColumn= arrayTwo.GetLength(1);
    if (arrayOne.GetLength(0) < arrayTwo.GetLength(0))
    {
        minPow = arrayOne.GetLength(0);
    }
    if (arrayOne.GetLength(1) < arrayTwo.GetLength(1))
    {
        minColumn = arrayOne.GetLength(1);
    }
    int[,] newArray = new int[arrayOne.GetLength(0), arrayTwo.GetLength(1)];
    for (int i = 0; i < minPow; i++)
    {
        for (int j = 0; j < minColumn; j++)
        {
            newArray[i, j] = arrayOne[i, j]* arrayTwo[i, j];
          
        }
    }
    return newArray;
}

int MatrixMultiplicationItem(int[,] arrayOne, int[,] arrayTwo, int i, int j)
{
    int newItem = 0;
    for (int k = 0; k < arrayOne.GetLength(1); k++)
    {
        newItem = newItem + arrayOne[i, k] * arrayTwo[k, j];

    }
    return newItem;

}