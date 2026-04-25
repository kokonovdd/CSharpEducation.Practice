namespace Practice2.Task2;
/*Напишите программу, которая переводит:
a. метры в километры
b. километры в сантиметры
c. м/с в км/ч
d. градусы C в градусы F
*/
class Program
{
    static void Main(string[] args)
    {
        ConvertMToKm();
        ConvertKmToCm();
        ConvertSpeedMToKm();
        ConvertCToF();
    }

    private static void ConvertMToKm()
    {
        const double mToKm = 0.001;
        Console.WriteLine("Метод перевода метры в километры.");
        Console.Write("Введите величину в метрах:");
        var valueKm = Console.ReadLine();
        if (double.TryParse(valueKm, out var val))
        {
            double valueCm = val * mToKm;
            Console.WriteLine($"{valueKm} м = {valueCm} км");
        }
        else
        {
            Console.WriteLine("Неверный формат входных данных.");
        }
    }
    private static void ConvertKmToCm()
    {
        const int kmToCm = 100000;
        Console.WriteLine("Метод перевода километров в сантиметры.");
        Console.Write("Введите величину в километрах:");
        var valueKm = Console.ReadLine();
        if (double.TryParse(valueKm, out var val))
        {
            double valueCm = val * kmToCm;
            Console.WriteLine($"{valueKm} км = {valueCm} см");
        }
        else
        {
            Console.WriteLine("Неверный формат входных данных.");
        }
    }
    
    private static void ConvertSpeedMToKm()
    {
        const int kmToM = 1000;
        const int hourToSec = 3600;
        Console.WriteLine("Метод перевода м/с в км/ч.");
        Console.Write("Введите величину в м/с:");
        var valueMSec = Console.ReadLine();
        if (double.TryParse(valueMSec, out var val))
        {
            double valueKmHour = (val / kmToM) * hourToSec;
            Console.WriteLine($"{valueMSec} м/с = {valueKmHour} км/ч");
        }
        else
        {
            Console.WriteLine("Неверный формат входных данных.");
        }
    }
    
    private static void ConvertCToF()
    {
        const double koef1 = (double)9/5;
        const int koef2 = 32;
        Console.WriteLine("Метод перевода градусов C в градусы F.");
        Console.Write("Введите величину в градусах C:");
        var valueC = Console.ReadLine();
        if (double.TryParse(valueC, out var val))
        {
            double valueF = (val * koef1) +koef2;
            Console.WriteLine($"{valueC} C = {valueF} F");
        }
        else
        {
            Console.WriteLine("Неверный формат входных данных.");
        }
    }
}