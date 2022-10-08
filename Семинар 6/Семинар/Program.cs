// суммпа от 1 до А
// Console.Clear();                                                         
//  int number = int.Parse(Console.ReadLine()!);
//  Console.WriteLine($"Sum: {RecSum(number)}");
 
// int RecSum(int number)
// {
//     if (number > 1)
//     {
//         return number + RecSum(number - 1);
//     }
//     else
//     {
//         return 1;
//     }
// }


// количество знаков
//  Console.Write($"Введите число: ");

// int num = int.Parse(Console.ReadLine()!);
// Console.WriteLine($"В числе {num} число знаков равно {CountDigits(num)}");

// int CountDigits(int number, int counter = 0)
// {

// if (number / 10 == 0)
// {
// return counter + 1;
// }
// else
// {
// return counter + CountDigits(number / 10) + 1;
// }

// }


// Console.Clear();
// int number = int.Parse(Console.ReadLine());

// Console.WriteLine(CountNumber(number));


// int CountNumber(int num)
// {
// if (num / 10 < 1) return 1;

// else return 1 + CountNumber(num/10);
// }

// // Задача: Напишите программу, которая будет рекурсивно выводить каждый элемент массива в консоль

// int[] CreateArray()
// {
// Console.Write("Введи размерность массива: ");
// int size = int.Parse(Console.ReadLine()!);
// int[] array = new int[size];
// return array;
// }

// void FillArray(int[] array)
// {
// Random randGenerator = new Random();
// for (int i = 0; i < array.Length; i++)
// {
// array[i] = randGenerator.Next(-99, 100);
// }
// }

// void PrintArray(int[] array)
// {
// Console.Write("Массив: ");
// for (int i = 0; i < array.Length; i++)
// {
// Console.Write($"{array[i]} ");
// }
// }

// void RecPrintArray(int[] array, int index = 0)
// {
// if (index < array.Length)
// {
// Console.Write($"{array[index]} ");
// index++;
// RecPrintArray(array, index);
// }
// }
// Console.Clear();
// int[] array = CreateArray();
// FillArray(array);
// PrintArray(array);
// Console.WriteLine();

// Console.Write("Рекурсивный: ");
// RecPrintArray(array);


//Задача 44: Напишите программу, которая принимает на вход 2 числа, количество строк и количество столбцо, создаёт матрицуданного размера и заполняет нулями или единицами в случайном порядке и выводит в консоль.
// int[,] CreateArray(int row, int coloumn)
// {
//     int[,] array = new int [row, coloumn];
//     return array;
// }
 
// void FillArray(int[,] collection)
// {
//     for (int i = 0; i < collection.GetLength(0); i++)
//     {
//         for (int j = 0; j < collection.GetLength(1); j++)
//         {
//             collection[i,j] = new Random().Next(0, 2);
//         }
//     }
// }
 
// void PrintArray(int[,] arr)
// {
//     for (int rows = 0; rows < arr.GetLength(0); rows++)
//     {
//         for(int coloumns = 0; coloumns < arr.GetLength(1); coloumns++)
//         {
//             Console.Write($"| {arr[rows, coloumns]} |");
//         }
//     Console.WriteLine();
//     }
// }
 
// Console.Write("Введите число строк: ");
// int row = int.Parse(Console.ReadLine()!);
 
// Console.Write("Введите число столбцов: ");
// int coloumn = int.Parse(Console.ReadLine()!);
 
// int[,] ar = CreateArray(row, coloumn);
// FillArray(ar);
// PrintArray(ar);