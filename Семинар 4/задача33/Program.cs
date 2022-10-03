// Console.Clear();
 
// Console.Write("Введите размер массива: ");
// int arrayLenght = int.Parse(Console.ReadLine()!);
 
// int[] array = new int[arrayLenght];
 
// FillArray(array);
// PrintArray(array);
 
 
 
// void FillArray(int[] array)
// {
//     Random randGenerator = new Random();
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = randGenerator.Next(0, 2);
//     }
// }
 
// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
// }
int[] array = CreateArray();
PrintArray(array);
RevertArray(array);
PrintArray(array);

void PrintArray(int[] array)
{
int count = array.Length;
Console.Write("[");
for (int i = 0; i < count; i++)
{
Console.Write(array[i]);
if (i == count - 1)
Console.WriteLine("]");
else
Console.Write(", ");
}
Console.WriteLine();
}

int[] CreateArray()
{
int[] array = {2,-5, -8, 4, 5};
return array;
}

void RevertArray(int[] array)
{
for (int i = 0; i < array.Length; i++)
{
array[i] = -array[i];
}
}