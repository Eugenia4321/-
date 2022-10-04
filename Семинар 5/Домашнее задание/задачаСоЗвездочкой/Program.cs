// Задача со звёздочкой
// Найти в массиве самую длинную последовательность, состоящую из одинаковых элементов. Вывести на экран количество элементов самой длиной последовательности, элемент самой последовательности и номер элемента, который является ее началом.
// Данная задача не вилияет на оценку
// Пример:
// [1 2 2 4 4 4 4 3 3 3] ->
// Count: 4
// Element: 4
// Position: 3

Console.Clear();

Console.Write("Введите числа массива через пробел: ");
string stringArray = Console.ReadLine()!;
int[] array = ParseToArray(stringArray);
PrintArray(array);


int[] arrayPosition = NumbersPositions(array);                                                  //создаем массив arrayPosition в котором указываем первый индекс повторяющегося элемента [1, 2, 2, 4, 4, 4, 3, 3, 3] ->[0, 1, 3, 6, 9, 0, 0, 0, 0]
//PrintArray(arrayPosition);
int position = MaxDifference(arrayPosition);
int number = array[position];
int count = CountLongestNumbers(array, position);

Console.Write($"позиция = {position}, значение = {number}, количество = {count}");


void PrintArray(int[] array)
{
    int count = array.Length;
    Console.Write("[");
    for (int i = 0; i < count; i++)
        {
            Console.Write($"{array[i]}");
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

int[] ParseToArray(string str)
{
    string[] stringArray = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);                            //скопировано из гугла, не выдает ошибку даже с пробелом после последней цифры, так как удаляет все пустые строки
   // string[] stringArray = str.Split(" ");                                                                                //выдает ошибку, если после последней цифры стоит пробел
    int[] result = new int[stringArray.Length];

    for (int i = 0; i < stringArray.Length; i++)
        {
        result[i] = int.Parse(stringArray[i]);
        }

        return result;
}


int[] NumbersPositions(int[] array)                                                                   //arrayPosition //создаем массив arrayPosition в котором указываем первый индекс повторяющегося элемента [1, 2, 2, 4, 4, 4, 3, 3, 3] ->[0, 1, 3, 6, 9, 0, 0, 0, 0]
{
    int[] numbersPositions = new int[array.Length];
    numbersPositions[0]=0;
    int count = 1;
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i]!=array[i-1])
        {
            numbersPositions[count]=i;
            count++;

        }
        numbersPositions[count]=array.Length;
    }
return numbersPositions;
}

int CountLongestNumbers(int[] array, int position)                                                   //count //по сути эта функция не нужна, мы можем из arrayPosition достать количество, но для тренировки написания функций пусть остается 
{
    count=0;
    if (position<array.Length)
    {
    for (int i = position; i < array.Length; i++)
    {   
        if (array[i]==array[position])
        {
            count++;
        }
    }
     
    }
  return count; 

}

int MaxDifference(int[] array)                                                                      //position      //из массива arrayPosition с первыми индексами повторяющихся элементов ищем наибольшую разницу - это и будет максимально длинная последовательность и возвращаем позицию первого элемента
{
    int position = 0;
    int max = 0;
    for (int i = 1; i < array.Length; i++) 
    {
        if ((array[i]-array[i-1])>max)
        {
            max=array[i]-array[i-1];
            position = i-1;
        }
    }
    return array[position];
}

