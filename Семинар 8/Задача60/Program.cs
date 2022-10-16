//Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
//Массив размером 2 x 2 x 2
//66(0,0,0) 25(0, 1, 0)
//34(1, 0, 0) 41(1, 1, 0)
//27(0, 0, 1) 90(0, 1, 1)
//26(1, 0, 1) 55(1, 1, 1)

using System;

Console.Write("Введите число строк матрицы: ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Введите число столбцов матрицы: ");
int coloumn = int.Parse(Console.ReadLine()!);
Console.Write("Введите число рядов матрицы: ");
int range = int.Parse(Console.ReadLine()!);
int[,,] intArrayOne = CreateIntArray(row, coloumn, range);
if (row * coloumn * range > 180)
{
    Console.WriteLine($"Невозможно заполнить массив неповторяющимися двухзначными числами, так как их всего 180, а в укзанном массиве {row * coloumn * range} элементов");
}
else
{
    FillIntArray(intArrayOne);
    PrintArray(intArrayOne);
}
void PrintArray(int[,,] array)
{
    for (int range = 0; range < array.GetLength(2); range++)
    {
        for (int rows = 0; rows < array.GetLength(0); rows++)
        {
            for (int coloumns = 0; coloumns < array.GetLength(1); coloumns++)
            {
                if (array[rows, coloumns, range] < 0)
                {
                    Console.Write($" {array[rows, coloumns, range]}({rows},{coloumns},{range}) ");
                }
                else
                {
                    Console.Write($"  {array[rows, coloumns, range]}({rows},{coloumns},{range}) ");
                }
            }
            Console.WriteLine();
        }

        Console.WriteLine();
    }
}

int[,,] CreateIntArray(int row, int coloumn, int range)
{
    int[,,] array = new int[row, coloumn, range];
    return array;
}

void FillIntArray(int[,,] array)
{
    Random intRandomGenerator = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                while (array[i,j,k]==0)             // для условий этой задачи допустимо сравнение с 0, если отрезок рандомных чисел будет включать 0, то заполнить сначала весь массив -1
                {
                    int item = intRandomGenerator.Next(10, 100);
                    
                    if (PlusMinus())
                    {
                        item = -item;
                    }
                    if (FindItem(array,item))
                    {
                        array[i,j,k] = item;    
                    }

                }
            }
        }
    }
}

bool FindItem(int[,,] array, int item)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                if (item == array[i, j, k])
                {
                    return false;
                }
                
            }
        }
    }
    return true;
}

bool PlusMinus()
{
    Random generator = new Random();
    int item = generator.Next(0, 2);
    if(item == 0)  return true; 
    else return false;

}