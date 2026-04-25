namespace Practice2.Task5;

class Program
{
    static void Main(string[] args)
    {
        {
            Console.WriteLine("Программа сравнения двух целых чисел.");

            int a;
            int b;

            Console.Write("Введите 1 число: ");
            var input = Console.ReadLine();
            if (!int.TryParse(input,
                    out a))
            {
                Console.WriteLine("Неверный формат входных данных.");
                Console.ReadLine();
                return;
            }

            Console.Write("Введите 2 число: ");
            input = Console.ReadLine();
            if (!int.TryParse(input,
                    out b))
            {
                Console.WriteLine("Неверный формат входных данных.");
                Console.ReadLine();
                return;
            }

            if (a == b)
            {
                Console.WriteLine($"{a} = {b}");
            }
            else
            {
                if (a > b)
                {
                    Console.WriteLine($"{a} > {b}");
                }
                else
                {
                    Console.WriteLine($"{a} < {b}");
                }
            }
        }
    }
}