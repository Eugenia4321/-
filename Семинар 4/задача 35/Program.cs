// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5
Console.Clear();
int[] array = new int[123];
FillArray(array);
int c = GetCount(array);
Console.WriteLine($"Количество элементов от 10 до 99 равно {c} ");


int GetCount(int[] arr)
{
int count = 0;
for (int i = 0; i < arr.Length; i++)
{
if (arr[i] >= 10 && arr[i] <= 99)
count ++;
}
return count;
}

void FillArray(int[] array)
{
Random randGenegator = new Random();
for (int i = 0; i < array.Length; i++)
{
array[i] = randGenegator.Next(0, 201);
}
}