
string[] FilterArrayByLength(string[] array, int maxLength)
{
    int count = 0;
    foreach (string str in array)
    {
        if (str.Length <= maxLength)
        {
            count++;
        }
    }

    string[] result = new string[count];
    int i = 0;
    foreach (string str in array)
    {
        if (str.Length <= maxLength)
        {
            result[i] = $"\"{str}\"";
            i++;
        }
    }

    return result;
}


Console.WriteLine("Введите строки для массива через запятую:");
string[] initialArray = Console.ReadLine().Split(',');

string[] newArray = FilterArrayByLength(initialArray, 3);

Console.WriteLine("Новый массив");
foreach (string str in newArray)
{
    Console.Write(string.Join(", ", str + " "));
}
