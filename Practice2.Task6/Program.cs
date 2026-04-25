namespace Practice2.Task6;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Программа для расчета процента вхождения символа в строку.");
        //a
        PercentageOccurrence();
        //b
        Console.WriteLine("Введите строку:");
        var text = Console.ReadLine();
        Console.WriteLine("Введите символ:");
        var inputSymbol = Console.ReadLine();
        PercentageOccurrence(text, inputSymbol[0]);
        //c
        PercentageOccurrence(args);
    }
    
    private static void PercentageOccurrence()
    {
        var text = "safafafsafwe retertetcx";
        Console.WriteLine($"Строка: {text}");

        var symbol = 's';
        Console.WriteLine($"Символ: {symbol}");

        int count = 0;
        for (int i = 0; i < text.Length; i++)
        {
            if (text[i] == symbol)
            {
                count++;
            }
        }

        double percentageOccurrence = ((double)count / text.Length) * 100;

        Console.WriteLine($"Процент вхождения символа: {percentageOccurrence}");
    }
    
    private static void PercentageOccurrence(string text, char symbol)
    {
        Console.WriteLine("Программа для расчета процента вхождения символа в строку.");

        int count = 0;
        for (int i = 0; i < text.Length; i++)
        {
            if (text[i] == symbol)
            {
                count++;
            }
        }

        double percentageOccurrence = ((double)count / text.Length) * 100;

        Console.WriteLine($"Процент вхождения символа: {percentageOccurrence}");
    }
    
    private static void PercentageOccurrence(string[] args)
    {
     
        if (args.Length == 2)
        { 
            var text = args[0];
            char symbol = args[1][0];

            int count = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == symbol)
                {
                    count++;
                }
            }

            double percentageOccurrence = ((double)count / text.Length) * 100;

            Console.WriteLine($"Процент вхождения символа '{symbol}' в строку '{text}': {percentageOccurrence}");

        }
    }
}