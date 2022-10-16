//Заданы 2 массива: info и data.В массиве info хранятся двоичные представления нескольких чисел (без разделителя). В массиве data хранится информация о количестве бит,
//которые занимают числа из массива info. Напишите программу, которая составит массив десятичных представлений чисел массива data с учётом информации из массива info.
//входные данные: data = { 0, 1, 1, 1, 1, 0, 0, 0, 1 }
//info = { 2, 3, 3, 1 }
//выходные данные: 1, 7, 0, 1

int[] data = { 0, 1, 1, 1, 1, 0, 0, 0, 1 };
int[] info = { 2, 3, 3, 1 };
int[] result = BinToDec(data, info);

Console.WriteLine(String.Join(",",result));

int[] BinToDec(int[] data, int[] info)
{
    int[] dec = new int[info.Length];
    int startPosition = 0;
    for (int i = 0; i < info.Length; i++)
    {
        int pow = info[i];
        for (int j = startPosition; j < startPosition + pow; j++)
        {
            dec[i] = dec[i] + data[j]*(int)Math.Pow(2,pow-1);
            startPosition = j+1;
            pow--;
        }


    }
    
    
    return dec;
}