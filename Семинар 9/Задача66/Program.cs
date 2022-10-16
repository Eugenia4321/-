//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. Рекурсивно

//M = 1; N = 15-> 120
//M = 4; N = 8. -> 30

Console.Write("Введите натуральное число N = ");
int n = int.Parse(Console.ReadLine());
Console.Write("Введите натуральное число M = ");
int m = int.Parse(Console.ReadLine());
if (m > n)
{
	Console.WriteLine($"Сумма натуральных элементов в промежутке от {n} до {m} равна {SumRec(n, m)}");
}
else
{
	Console.WriteLine("M должно быть больше N!");
}
int SumRec(int n=1,int m=15)
{
    int sum=n;
	if (n==m)
	{
		return m;
	}
	else
	{
		return m + SumRec(n,m-1);
	}
}