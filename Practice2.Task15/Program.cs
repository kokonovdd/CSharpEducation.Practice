namespace Practice2.Task15;

class Program
{
    static void Main(string[] args)
    {
        string[] array = new string[] { "жили", "были", "у", "бабуси", "два", "веселых", "гуся" };
        Console.WriteLine("Исходный массив:");
        PrintArray(array);

        Console.WriteLine("Инвертированный массив:");
        PrintArray(InvertArray(array));
    }

    /// <summary>
    /// Вывести массив на экран.
    /// </summary>
    /// <param name="array">Массив.</param>
    static void PrintArray(string[] array)
    {
        var row = string.Empty;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            row += array[i] + " ";
        }
        Console.WriteLine(row);
    }


    /// <summary>
    /// Инвертировать массив.
    /// </summary>
    /// <param name="array">Массив.</param>
    static string[] InvertArray(string[] array)
    {
        var result=new string[array.Length];

        int j = 0;
        for (int i = array.GetLength(0)-1; i >=0; i--)
        {
            result[j++] = array[i];
        }
     
        return result;
    }
}