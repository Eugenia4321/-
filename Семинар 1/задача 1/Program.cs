// задача 1 проверить является ли число квадратом второго числа
// Console.Clear();
// Console.Write("vvedi kvadrat chisla ");
// int sqr = int.Parse(Console.ReadLine());
// Console.Write("vvedi chislo ");
// int number = int.Parse(Console.ReadLine());
// if (number*number==sqr){
//     Console.WriteLine("verno");
// }
// else {
//     Console.WriteLine("ne verno");
// }

// //задача 2, день недели по заданному номеру
// Console.Clear();
// Console.Write("vvedi nomer dnya nedeli ");
// int number = int.Parse(Console.ReadLine());
// if(number>0 && number<8){
// switch(number){
//     case 1:
//     Console.WriteLine("monday");
//     break;
//      case 2:
//     Console.WriteLine("Tuesday");
//     break;
//      case 3:
//     Console.WriteLine("Wednesday ");
//     break;
//      case 4:
//     Console.WriteLine("Thursday ");
//     break;
//      case 5:
//     Console.WriteLine("Friday ");
//     break;
//      case 6:
//     Console.WriteLine("Saturday ");
//     break;
//      case 7:
//     Console.WriteLine("Sunday ");
//     break;
// }
// }
// else Console.WriteLine("net takogo dnya");

// задача 3 Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.

// Console.Clear();
// Console.Write("vvedi chislo ");
// int number = int.Parse(Console.ReadLine());
// if (number>=0){
// int i =number*(-1);

// while (i<number){
//     Console.Write(i+", ");
//     i++;
// }
// Console.Write(number);
// }
// else{
// int i =number*(-1);

// while (i>number){
//     Console.Write(number+", ");
//     number++;
// }
// Console.Write(i);
// }

// задача 4 Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа. 456 -> 6 782 -> 2 918 -> 8
//  Console.Clear();
// Console.Write("vvedi trehznachnoe chislo = ");
// int number = int.Parse(Console.ReadLine());
// if(number>99 && number<1000){
//     double result = (double)number%10;
//     Console.WriteLine(result);
    
// }
// else Console.WriteLine("ne vernoe chislo");
