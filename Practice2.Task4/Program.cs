namespace Practice2.Task4;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Программа для прорисовки треугольника.");
        
        Console.Write("Введите символ для построения треугольника: ");
        var symbol=Console.ReadLine();

        Console.Write("Введите высоту треугольника: ");
        var input = Console.ReadLine();
        if (int.TryParse(input, out int height) && height > 0)
        {
            for (int i = 0; i < height; i++)
            {
                var line = string.Empty;
                if (i < height)
                {
                    for (int j = 1; j < height - i; j++)
                    {
                        line += " ";
                    }
                }
                for (int j = height - 2 * i; j <= height; j++)
                {
                    line += symbol;
                }
                Console.WriteLine(line);
            }
        }
        else
        {
            Console.WriteLine("Неверный формат входных данных.");
        }
    }
}