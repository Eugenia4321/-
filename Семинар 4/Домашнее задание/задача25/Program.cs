// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
// Ограничения:
// - Нельзя использовать класс Math
// - Должна быть отдельная функция Power, которая возвразает результат
// - Внутри функций НЕЛЬЗЯ использовать класс Console. Только в основном блоке кода

Console.Clear();

Console.Write("A = ");
int a = int.Parse(Console.ReadLine()!);

Console.Write("B = ");
int b = int.Parse(Console.ReadLine()!);
bool checkB = CheckB(b);
int result=Power(a,b);
if (checkB)
{
    Console.WriteLine($"Число {a} в степени {b} равно {result}");
}
else
{
    Console.WriteLine($"Число {b} не является натуральным, введите число больше 0 ");
}

bool CheckB(int b)
{
    if (b>1)
    {
        return true;
    }
    else
    {
        return false;
    }
}

int Power(int a, int b)
{
    int result=1;
    for(int i =1; i<=b; i++)
    {
        result*= a;
    }
    return result;
}

