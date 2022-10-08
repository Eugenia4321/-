Console.Clear();

int num = 0;
Console.WriteLine($"sum = {summ(num)}");

double summ(int num, int count=1, double sum =0) 
{
    if (num==-1)
    {
        Console.WriteLine($" gewg {sum}");
        return sum ;
    }
    else
    {
        num = int.Parse(Console.ReadLine())!;
        Console.WriteLine($"sum {sum} summ(num, count+1) {summ(num, count + 1)}");
        sum = num + summ(num, count+1);
        Console.WriteLine(sum);
        return sum;

    }
    
}