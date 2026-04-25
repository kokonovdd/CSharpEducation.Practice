namespace Practice1.Task5;

class Program
{
    static void Main(string[] args)
    {
        const float PI = 3.14f;
        float radius = 10f;
        float square = radius * radius * PI;
        Console.WriteLine($"Площадь круга радиуса {radius} = {square}");
    }
}