// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.Clear();
Console.Write("Number= ");
int number = int.Parse(Console.ReadLine());
int i =1;
if (number%2==0){
while (i <(number-1)){
    if (i%2==0) Console.Write($"{i}, ");
    i++;
}
Console.Write(number);}
else{
    while (i <(number-1)){
    if (i%2==0) Console.Write($"{i}, ");
    i++;
}
Console.Write(number-1);}
