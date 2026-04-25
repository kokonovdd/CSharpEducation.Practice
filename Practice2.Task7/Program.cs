namespace Practice2.Task7;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Программа для перевода строки в разные регистры.");

        Console.Write("Введите строку: ");
        var text = Console.ReadLine();

        var newText = text.ToUpper();

        Console.Write("Новая строка в верхнем регистре: ");
        Console.WriteLine(newText);
        
        newText = text.ToLower();

        Console.Write("Новая строка в нижнем регистре: ");
        Console.WriteLine(newText);
        
        newText = text.Substring(0,1).ToUpper()+text.Substring(1,text.Length-1).ToLower();
     
        Console.Write("Новая строка с первой заглавной буквой: ");
        Console.WriteLine(newText);
    }
}