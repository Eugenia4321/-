// Задача 70: Напишите программу, которая печатает последовательность чисел, где каждое следующее равно сумме двух предыдущих. 
// На вход принимает 3 числа: n1, n2 и N, где n1 n2 -
//  первые числа последовательности, N – длина последовательности 3 и 4, N = 5 -> 3 4 7 11 18 6 и 10, N = 4 -> 6 10 16 26 
int[] RowLikeFibo(int digit, int firstNum, int secondNum)
{
    int[] array = new int[digit];
    array[0] = firstNum;
    array[1] = secondNum;
 
    for (int i = 2; i < array.Length; i++)
    {
        array[i] = array[i - 1] + array[i - 2];
    }
 
    return array;
}
 
Console.Write("Введите первое число последовательности: ");
int numOne = int.Parse(Console.ReadLine()!);
 
Console.Write("Введите второе число последовательности: ");
int numTwo = int.Parse(Console.ReadLine()!);
 
Console.Write("Введите длину последовательности: ");
int numThree = int.Parse(Console.ReadLine()!);
 
int[] result = RowLikeFibo(numThree, numOne, numTwo);
Console.Write(string.Join(", ", result));


// Задача 71: В некотором машинном алфавите имеются четыре буквы «а», «и», «с» и «в». Покажите все слова, 
// состоящие из 2 букв, которые можно построить из букв этого алфавита.n = 2 -> аа, ии, сс, вв, аи, иа, ис, си, ас, са, ав, ва, ви, ив, св, вс
char[] alphabet = {'a', 'и', 'c', 'в'};
 
Console.Write("Сколько букв в слове? ");
int num = int.Parse(Console.ReadLine()!);
 
char[] word = new char[num];
 
WriteWord(alphabet, word);
 
void WriteWord(char[] array, char[] word, int length = 0)
{
    if (length == word.Length)
    {
        Console.WriteLine($" {new String(word) }");
        return;
    }
 
    for (int i = 0; i < array.Length; i++)
    {
        word[length] = array[i];
        WriteWord(array, word, length + 1);
    }
}

// // Задача 72: Задан массив, в котором хранится двоичное представление числа.Нужно вывести его десятичное представление
//  {0,1,1,1,1} -> 15Задача 72: Заданы 2 массива: info и data. В массиве info хранятся двоичные представления нескольких чисел (без разделителя).
//   В массиве data хранится информация о количестве бит, которые занимают числа из массива info. Напишите программу, которая составит
//    массив десятичных представлений чисел массива data с учётом информации из массива info.
// // входные данные: data = {0, 1, 1, 1, 1, 0, 0, 0, 1 } info = {2, 3, 3, 1 }выходные данные: 1, 7, 0, 1

int doubleNum = {0,1,1,1,1};
Array.Reverse(doubleNum);
int result =0;

for (int i = 0; i < doubleNum.Length; i++)
{
    result = result+Math.Pow(2,i)*doubleNum;
}