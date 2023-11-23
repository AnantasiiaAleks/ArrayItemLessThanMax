public static class ArrayMaster
{
    public static string[] NewArrayStringsNoLongerThan(string[] array, int value)
    {
        string[] resultArray = new string[array.Length];
        int j = 0;

        for (int i = 0; i < array.Length;  i++)
        {
            if (array[i] <= value)
            {
                resultArray[j++] = array[i];
            }
        }
        array.Resize(ref resultArray, j);
        return resultArray;
    }
    
    public static void PrintArray(string[] array, string message = "")
    {
        Console.WriteLine(message);
        Console.WriteLine($"[{string.Join(", ", array)}]")
    }
}