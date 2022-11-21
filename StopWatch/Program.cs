internal class Program
{
    private static void Main(string[] args)
    {
        Start(6);
    }

    static void Menu()
    {
        Console.Clear();
        Console.WriteLine("S = Segundos - Ex: 10s (10 segundos)");
        Console.WriteLine("M = Minutos - Ex: 1m (1 minuto)");
        Console.WriteLine("0 = Sair");
        Console.WriteLine("Quanto tempo deseja contar?");

        Console.ReadLine();

        string data = Console.ReadLine().ToLower();
        char type = char.Parse(data.Substring((data.Length - 1), 1));
        int time = int.Parse(data.Substring(0, (data.Length - 1)));
    }

    static void Start(int time)
    {
        int currentTime = 0;

        while (currentTime != time)
        {
            Console.Clear();
            currentTime++;
            Console.WriteLine(currentTime);
            Thread.Sleep(1000);
        }

        Console.Clear();
        Console.WriteLine("Stopwatch finalizado.");
        Thread.Sleep(2500);
    }
}