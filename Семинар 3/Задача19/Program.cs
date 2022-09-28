// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
Console.Clear();
Console.Write("Enter number: ");
int number = int.Parse(Console.ReadLine());
if ((Math.Abs(number)>99999) || (Math.Abs(number)<9999))
{
    Console.WriteLine(" not correct");
}
else
{
if ( number/10000 == number%10 && number/1000%10==number%100/10)
{
    Console.WriteLine($"{number} -> yes");
}
else 
{
        Console.WriteLine($"{number} -> no");
     //   Console.WriteLine($"{number/10000},{number%10},{number/1000%10},{number%100/10}");   // проверка правильности формул

}
}