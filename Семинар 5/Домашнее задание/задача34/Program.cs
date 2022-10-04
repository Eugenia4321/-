// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2


Console.Clear();

int countArray = 10;                 // размер массива
int minArray = 100;                   // минимальное значение для генератора рандомных чисел
int maxArray = 999;                  // максимальное значение для генератора рандомных чисел

int[] array = new int[countArray];
FillArray(array,minArray,maxArray);
PrintArray(array);
int count = GetCountEvenNumbers(array);
Console.WriteLine($"Количество четных элементов в массиве равно {count}");

void FillArray(int[] array, int minArray, int maxArray)
{
    Random randGenegator = new Random();
    for (int i = 0; i < array.Length; i++)
        {
            array[i] = randGenegator.Next(minArray, maxArray+1);
        }
}

void PrintArray(int[] array)
{
    int count = array.Length;
    Console.Write("[");
    for (int i = 0; i < count; i++)
        {
            Console.Write(array[i]);
            if (i == count - 1)
                {
                Console.WriteLine("]");
                }
            else
                {
                Console.Write(", ");
                }
        }
}

int GetCountEvenNumbers(int[] array)
{
    int count =0;
     for (int i = 0; i < array.Length; i++)
        {
            if (array[i]%2==0)
            {
                count++;
            }
        }
        return count;
}