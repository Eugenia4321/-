//Задача 57: Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.

Console.Write("Введите число строк: ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Введите число столбцов: ");
int coloumn = int.Parse(Console.ReadLine()!);

int[,] intArray = CreateIntArray(row, coloumn);
FillIntArray(intArray);
PrintArray(intArray);
Console.WriteLine("_________________");
int[,] vocabArray = VocabArray(intArray);
// отсортировать массив

PrintArray(vocabArray);
//int number = Number(intArray);
//Console.WriteLine(number);

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
//void PrintArray1(int[,] arr)
//{
//    for (int rows = 0; rows < arr.GetLength(0); rows++)
//    {
//        arr.
//        for (int coloumns = 0; coloumns < arr.GetLength(1); coloumns++)
//        {
//            for (int coloumns1 = coloumns; coloumns1 < arr.GetLength(1); coloumns1++)
//            {
//                if (arr[0, coloumns] != arr[0, coloumns1])
//                {

//                    Console.Write($"| {arr[0, coloumns]} |");
//                    Console.Write($"| {arr[1, coloumns]} |");
//                }
//            }
//        }
//        Console.WriteLine();
//    }
//}

//int Number(int[,] array)
//{
//    int number = 0;
//    for (int i = 0; i < array.GetLength(0); i++)
//    {
//        for (int j = 0; j < array.GetLength(1); j++)
//        {
//            for (int iI = i-1; iI >= 0; iI--)
//            {
//                for (int jJ = j - 1; jJ >= 0; jJ--)
//                {
//                    if (array[i, j] != array[iI, jJ]) number++;

//                }
//            }
//        }
//    }
//    return number;
//}

int[,] VocabArray(int[,] array)
{
    int k = 0;
    int[,] vocabArray = new int[2, array.Length];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            vocabArray[0,k]=array[i,j];
            k++;
        }
    }

    for (int i = 0; i < vocabArray.GetLength(1); i++)
    {
        for (int j = i; j < vocabArray.GetLength(1); j++)
        {
            if (vocabArray[0,i]== vocabArray[0,j])
            {
                vocabArray[1, i]++;

            }
        }

    }
    for (int i = 0; i < vocabArray.GetLength(1); i++)
    {
        for (int j = i; j < vocabArray.GetLength(1); j++)
        {
            if (vocabArray[0, i] == vocabArray[0, j])
            {
                vocabArray[1, j]=vocabArray[1,i];

            }
        }

    }
    return vocabArray;
}