namespace Practice2.Task1;
/*Напишите цикл следующего вида:
a. цикл for. Пусть он выводит в консоль значение своего же счётчика.
b. цикл while. Пусть он выводит в консоль значение своего же счётчика.
c. цикл do while. Пусть он выводит в консоль значение своего же счётчика.
d. цикл for, в котором у пользователя запрашиваются слова, затем
выводится полная фраза, слова в которой разделены пробелами.
e. цикл while, в котором у пользователя запрашиваются слова, затем
выводится полная фраза, слова в которой разделены пробелами.
f. цикл do while, в котором у пользователя запрашиваются слова, затем
выводится полная фраза, слова в которой разделены пробелами.
*/

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите окончание счетчика: ");
        int k = int.Parse(Console.ReadLine());
        k++;
        AccaoutFor(k);
        AccaoutWhile(k);
        AccaoutDoWhile(k);
        WordFor(k-1);
        WordWhile();
        WordDoWhile();
    }
    /// <summary>
    /// Вывод счетчика для for
    /// </summary>
    /// <param name="k">последний счет</param>
    private static void AccaoutFor(int k)
    {
        for (int i = 0 ; i < k; i++)
            Console.WriteLine("For " + i);
    }
    /// <summary>
    /// Вывод счетчика для while
    /// </summary>
    /// <param name="k">последний счет</param>
    private static void AccaoutWhile(int k)
    {
        int i = 0;
        while (i < k)
        {
            Console.WriteLine("While " + i);
            i++;
        }
    }
    /// <summary>
    /// Вывод счетчика для do while
    /// </summary>
    /// <param name="k">последний счет</param>
    private static void AccaoutDoWhile(int k)
    {
        int i = 0;
        do
        {
            Console.WriteLine("Do while " + i);
            i++;
        } while (i < k);
    }
    /// <summary>
    /// Получит фразу из k слов счетчиком for
    /// </summary>
    /// <param name="k">количество фаз</param>
    private static void WordFor(int k)
    {
        string? word;
        string answer = "";
        for (var i =  1 ; i <= k; i++)
        {
            Console.Write($"Введите {i} из {k} слово: ");
            word = Console.ReadLine();
            answer += (word + " ");
        }
        Console.WriteLine("Полученная фраза: " + answer);
    }
    /// <summary>
    /// Вывод фразы полученной считыванием сток с помощью while
    /// </summary>
    private static void WordWhile()
    {
        string? word;
        Console.Write("Введите слово(пустая строка - остановка): ");
        word = Console.ReadLine();
        string? answer = word;
        while (word != "")
        {
            Console.Write("Введите слово: ");
            word = Console.ReadLine();
            answer += (word + " ");
        }
        Console.WriteLine("Полученная фраза: " + answer);
    }
    /// <summary>
    /// Вывод фразы полученной считыванием сток с помощью do while
    /// </summary>
    private static void WordDoWhile()
    {
        string? word;
        string answer = "";
        do
        {
            Console.Write("Введите слово(пустая строка - остановка): ");
            word = Console.ReadLine();
            answer += (word + " ");
        } while (word != "");
        Console.WriteLine("Полученная фраза: " + answer);
    }
}