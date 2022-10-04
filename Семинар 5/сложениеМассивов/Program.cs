int[] ConcatArray(int[] array1, int[] array2)
{
int[] resultArray = new int[array1.Length + array2.Length];
int counter = 0;

for (int i = 0; i < array1.Length; i++)
{
resultArray[counter] = array1[i];
counter++;
}
for (int i = 0; i < array2.Length; i++)
{
resultArray[counter] = array2[i];
counter++;
}

return resultArray;
}