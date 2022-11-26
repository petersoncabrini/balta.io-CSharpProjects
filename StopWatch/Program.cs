internal class Program
{
    private static void Main(string[] args)
    {
        Menu();
    }

    static void Menu()
    {
        Console.Clear();
        Console.WriteLine("S = Segundos - Ex: 10s (10 segundos)");
        Console.WriteLine("M = Minutos - Ex: 1m (1 minuto)");
        Console.WriteLine("0 = Sair");
        Console.WriteLine("Quanto tempo deseja contar?");

        var data = Console.ReadLine();

        if (data?.Length == 1 && data.Contains("0"))
        {
            System.Environment.Exit(0);
        }
        else
        {
            data.ToLower();
        }

        char type = char.Parse(data.Substring(data.Length - 1, 1));
        int time = int.Parse(data.Substring(0, data.Length - 1));

        int multiplier = 1;

        if (type == 'm')
            multiplier = 60;

        PreStart(time * multiplier);
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
        Menu();
    }

    static void PreStart(int time)
    {
        Console.Clear();
        Console.WriteLine("Ready...");
        Thread.Sleep(1000);
        Console.WriteLine("Set...");
        Thread.Sleep(1000);
        Console.WriteLine("GO!");
        Thread.Sleep(2500);

        Start(time);
    }
}