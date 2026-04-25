namespace Practice1.Task6;

class Program
{
    static void Main(string[] args)
    {
        double katet1 = 23.4;
        double katet2 = 33.4;
        double gipotenuza = 43.4;
        SendKatet(katet1,
            gipotenuza);
        SendGipotenuza(katet1,
            katet2);
    }
    /// <summary>
    /// Поиск второого катета, при известной гиротенузе и катету
    /// </summary>
    /// <param name="katet1">Катет</param>
    /// <param name="gipotenuza">Гипотенуза</param>
    /// <returns></returns>
    public static void SendKatet(double katet1, double gipotenuza)
    {
        double katet2 = Math.Sqrt(gipotenuza * gipotenuza - katet1 * katet1);
        Console.WriteLine($"При гипотенузе = {gipotenuza} и катету = {katet1} второй катет равен {katet2:F3}");
    }
    /// <summary>
    /// Поиск гипотенузы при известных катетах
    /// </summary>
    /// <param name="katet1"></param>
    /// <param name="katet2"></param>
    /// <returns></returns>
    public static void SendGipotenuza(double katet1, double katet2)
    {
        double gipotenuza = Math.Sqrt(katet2 * katet2 + katet1 * katet1);
        Console.WriteLine($"При катетах {katet1} и {katet2} гипотенуза равна {gipotenuza:F}");
        ;
    }
}