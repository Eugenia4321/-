//Задача 62.Напишите программу, которая заполнит спирально массив 4 на 4.
//Например, на выходе получается вот такой массив:
//01 02 03 04
//12 13 14 05
//11 16 15 06
//10 09 08 07
Console.Write("Введите число строк: ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Введите число столбцов: ");
int coloumn = int.Parse(Console.ReadLine()!);
int[,] intArray = CreateIntArray(row, coloumn);
Spiral(intArray);
PrintArray(intArray);


int[,] CreateIntArray(int row, int coloumn)
{
    int[,] array = new int[row, coloumn];
    return array;
}
void PrintArray(int[,] arr)
{
    for (int rows = 0; rows < arr.GetLength(0); rows++)
    {
        for (int coloumns = 0; coloumns < arr.GetLength(1); coloumns++)
        {
            if (arr[rows, coloumns] > 9)
            {
                Console.Write($"| {arr[rows, coloumns]} |");
            }
            else
            {
                Console.Write($"|  {arr[rows, coloumns]} |");
            }
        }
        Console.WriteLine();
    }
}

void Spiral(int[,] array)
{
    array[0, 0] = 1;
    int iStart=0;
    int iEnd=array.GetLength(0)-1;
    int jStart = 0;
    int jEnd=array.GetLength(1)-1;

    while (CheckEmptyItem(array))
    {

        RightStep(array, iStart, jStart);
        DownStep(array, iStart, jEnd);
        LeftStep(array, iEnd, jEnd);
        UpStep(array, iEnd, jStart);
        iStart++;
        iEnd--;
        jStart++;
        jEnd--;
    }    
   
}
bool CheckEmptyItem(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == 0)
                return true;
        }
    }
    return false;
}
void RightStep(int[,] array,int i,int j)
{
    for (int k = j; k < array.GetLength(1); k++)
	{
        if (array[i, k] == 0)
        {
            array[i, k] = array[i, k - 1] + 1;
        }
       
    }
  
}
void LeftStep(int[,] array, int i, int j)
{
    for (int k = j; k>0; k--)
	{
        if(array[i, k - 1]==0)
        array[i, k-1] = array[i, k] + 1;
    }
}
void DownStep(int[,] array, int i, int j)
{
    for (int k = i; k < array.GetLength(0); k++)
    {
        if(array[k, j] == 0)
        array[k, j] = array[k-1, j] + 1;

    }
}
void UpStep(int[,] array, int i, int j)
{
    for (int k = i; k > 0; k--)
    {
        if (array[k - 1, j]==0)
        array[k-1, j] = array[k, j] + 1;
    }
}