// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76


Console.Clear();

Console.Write("Введите числа массива через пробел: ");
string stringArray = Console.ReadLine()!;
double[] array = ParseToArray(stringArray);
PrintArray(array);
double maxNumberArray = FindMaxNumber(array);
double minNumberArray = FindMinNumber(array);

Console.WriteLine($"Разница между максимальным {maxNumberArray} и минимальным {minNumberArray} элементом равна {maxNumberArray - minNumberArray}");

// void FillArray(double[] array)
// {
//     Random randGenegator = new Random();
//     for (int i = 0; i < array.Length; i++)
//         {
//             array[i] = randGenegator.NextDouble()*100;          //так как NextDouble() возвращает от 0 до 1 , умножим на 100 для красоты , массив будет заполнен вещественными числами от 0 до 100
//         }
// }

void PrintArray(double[] array)
{
    int count = array.Length;
    Console.Write("[");
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]:f2}");
        if (i == count - 1)
        {
            Console.WriteLine("]");
        }
        else
        {
            Console.Write(", ");
        }
    }
}

double[] ParseToArray(string str)
{
    string[] stringArray = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);                            //скопировано из гугла, не выдает ошибку даже с пробелом после последней цифры, так как удаляет все пустые строки
                                                                                                                            // string[] stringArray = str.Split(" ");                                                                                //выдает ошибку, если после последней цифры стоит пробел
    double[] result = new double[stringArray.Length];

    for (int i = 0; i < stringArray.Length; i++)
    {
        result[i] = double.Parse(stringArray[i]);
    }

    return result;
}

double FindMaxNumber(double[] array)
{
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
    }
    return max;

}

double FindMinNumber(double[] array)
{
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }
    }
    return min;
}


