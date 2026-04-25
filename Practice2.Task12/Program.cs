namespace Practice2.Task12;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Введите размер массива:");
        var inputDim = Console.ReadLine();

        if (int.TryParse(inputDim, out var dim) && dim > 0)
        {
            var array = new string[dim];

            for(int i = 0; i < dim;i++)
            {
                Console.WriteLine($"Введите {i} элемент строкового массива:") ;
                var inputText=Console.ReadLine();
                array[i] = inputText;
            }

            Console.WriteLine("Массив:");
            PrintArray(array);
        }
        else
        {
            Console.WriteLine("Неверный формат входных данных.");
        }
    }

   

    /// <summary>
    /// Вывести массив на экран.
    /// </summary>
    /// <param name="array">Массив.</param>
    static void PrintArray(string[] array)
    {
        foreach (var item in array)
        {
            Console.WriteLine(item);
        }
    }
}