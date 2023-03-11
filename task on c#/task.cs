System.Console.WriteLine("Введите колличество элементов");
int arrLength = int.Parse(Console.ReadLine());
string[] array = new string[arrLength];
string[] arr = getArray(arrLength);
PrintResult(filterArray(arr));

string[] getArray(int length)
{
    for (int i = 0; i < length; i++)
    {
        System.Console.WriteLine("Введите элемент массива");
        string result = System.Console.ReadLine();
        array[i] = result;
    }
    System.Console.WriteLine("[" + string.Join(", ", array) + "]");
    return array;
}

// string[] arr = getArray(arrLength);

string[] filterArray(string[] array)
{
    int limit = 3;
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= limit)
        {
            sum++;
        }
    }

    string[] tempArray = new string[sum];

    for (int i = 0, t = 0; i < array.Length; i++)
    {
        if (array[i].Length <= limit)
        {
            tempArray[t] = array[i];
            t++;
        }
    }
    return tempArray;
}
void PrintResult(string[] array)
{
    System.Console.WriteLine("[" + string.Join(", ", array) + "]");
}
