namespace Practice2.Task9;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите размер массива: ");
        var inputDim = Console.ReadLine();

        if (int.TryParse(inputDim, out var dim) && dim > 0)
        {
            var array = CreateArray(dim);
            Console.Write("Массив: ");
            PrintArray(array);
        }
        else
        {
            Console.WriteLine("Неверный формат входных данных.");
        }
    }

    /// <summary>
    /// Создать массив, заполненных случайными числами.
    /// </summary>
    /// <param name="lengthArray">Размер массива.</param>
    /// <returns>Созданный массив с заданной размерностью.</returns>
    static int[] CreateArray(int lengthArray)
    {
        int[] result = new int[lengthArray];
        Random rnd = new Random();
      
        for (int i = 0;i<lengthArray;i++)
        {
            result[i] = rnd.Next(1, 100);
        }

        return result;
    }

    /// <summary>
    /// Вывести массив на экран.
    /// </summary>
    /// <param name="array">Массив.</param>
    static void PrintArray(int[] array)
    {
        foreach(var item in array)
        {
            Console.WriteLine(item);
        }
    }
}