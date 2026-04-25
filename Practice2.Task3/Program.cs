namespace Practice2.Task3;

class Program
{
    static void Main(string[] args)
    {
        double a;
        double b;
        double f;
     
        Console.WriteLine("Программа расчета выражения по формуле (а + b — f / а) + f * a * a — (a + b)");

        Console.Write("Введите величину а: ");
        var input = Console.ReadLine();
        if (!double.TryParse(input, out a))
        {
            Console.WriteLine("Неверный формат входных данных.");
            return;
        }
        if (a == 0)
        {
            Console.WriteLine("На 0 делить нельзя.");
            return;
        }

        Console.Write("Введите величину b: ");
        input = Console.ReadLine();
        if (!double.TryParse(input, out b))
        {
            Console.WriteLine("Неверный формат входных данных.");
            return;
        }

        Console.Write("Введите величину f: ");
        if (!double.TryParse(input, out f))
        {
            Console.WriteLine("Неверный формат входных данных.");
            return;
        }

        double result = (a + b - f / a) + f * a * a - (a + b);

        Console.WriteLine($"При а = {a}, b = {b}, f = {f} результат выражения = {result}.");
    }
}