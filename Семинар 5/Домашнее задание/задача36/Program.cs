// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Clear();

int countArray = 4;                 // размер массива
int minArray = -10;                   // минимальное значение для генератора рандомных чисел
int maxArray = 10;                  // максимальное значение для генератора рандомных чисел

int[] array = new int[countArray];
FillArray(array,minArray,maxArray);
PrintArray(array);
int sum = GetSumOddIndex(array);
Console.WriteLine($"Сумма нечетных элементов равна {sum}");

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

int GetSumOddIndex(int[] array)         //считаем сумму нечетных элементов относительно индексов в программе, то есть начиная с нулевого индекса, так как в примере сумма 1 и 3 элемента по индексам
{
    int sum =0;
    int i = 1;                          //начинаем с 1, т.к. ноль считается четным и он не нужен
     while ( i < array.Length)
        {
            sum+=array[i];
            i+=2;
        }
        return sum;
}