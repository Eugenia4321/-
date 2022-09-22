// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.Clear();
Console.Write("First number= ");
int numberFirst = int.Parse(Console.ReadLine());
Console.Write("Second number = ");
int numberSecond = int.Parse(Console.ReadLine());
if (numberSecond==numberFirst){
    Console.WriteLine("numbers are equal ");
}
else {
    if(numberFirst>numberSecond)
    {
        Console.WriteLine($"max={numberFirst}");
        Console.WriteLine($"min={numberSecond}");
    }
    else{
        Console.WriteLine($"max={numberSecond}");
        Console.WriteLine($"min={numberFirst}");
        
    }
}
