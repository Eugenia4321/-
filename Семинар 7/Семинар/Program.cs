for (int i = 1; i < 60; i++)
{
    Console.WriteLine($"f({i}) = {SlowFibonacci(i)}");
}
 
  double SlowFibonacci(int n)
{
    if (n == 1 || n == 2)
        return 1;
    else
        return SlowFibonacci(n - 1) + SlowFibonacci(n - 2);
}
double FastFibonacci(int n, int sum = 1, int previousSum = 0)
{
    if (n == 0) 
        return previousSum;
    else
        return FastFibonacci(n - 1, sum + previousSum, sum);
}
 
 Console.Clear();
 
Console.Write("Введите m: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите n: ");
int n = int.Parse(Console.ReadLine()!);
Console.Write("Введите z: ");
int z = int.Parse(Console.ReadLine()!);
 
int[,,] array = new int[m, n, z];
FillArray(array);
PrintArray(array);
 
 
 
void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i,j,k]} ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}
 
 
 
void FillArray(int[,,] array)
{
    Random generator = new Random();
 
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i,j,k] = generator.Next(0,100);
            }
        }
    }
}