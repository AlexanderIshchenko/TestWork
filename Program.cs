string[] array = { "hello", "2", "world", ":-)" };
int resultArrayLength = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3) resultArrayLength++;
}
string[] resultArray = new string[resultArrayLength];
int resultArrayIndex = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3)
    {
        resultArray[resultArrayIndex] = array[i];
        resultArrayIndex++;
    }
}
Console.WriteLine($"[{string.Join(", ", resultArray)}]");