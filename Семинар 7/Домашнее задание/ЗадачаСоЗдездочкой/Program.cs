//Задача *.Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.

Console.Write("Введите N: ");
int n = int.Parse(Console.ReadLine()!);
PrintFibonacci(n);

void PrintFibonacci(int n)
{
    
    int n1 = 1;
    int n2 = 2;
    int nN = 0;
    Console.WriteLine($"Числа фибоначчи:");
    Console.WriteLine($"1 --- 1");
    Console.WriteLine($"2 --- 2");
    for (int i = 3; i <= n; i++)
    {
        nN = n1 + n2;
        n1 = n2;
        n2 = nN;
        Console.WriteLine($"{i} --- {nN}");
    }
}