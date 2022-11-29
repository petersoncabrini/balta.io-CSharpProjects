internal class Program
{
    private static void Main(string[] args)
    {
        Menu();
    }

    static void Menu()
    {
        Console.Clear();
        Console.WriteLine("O que voce deseja fazer?");
        Console.WriteLine("1- Abrir arquivo");
        Console.WriteLine("2- Criar novo arquivo");
        Console.WriteLine("0- Sair");
        short option = short.Parse(Console.ReadLine());

        switch (option)
        {
            case 0: System.Environment.Exit(0); break;
            case 1: Abrir(); break;
            case 2: Create(); break;
            default: Menu(); break;
        }
    }

    static void Abrir() { }

    static void Create()
    {
        Console.Clear();
        Console.WriteLine("Digite seu texto (ESC para sair): ");
        Console.WriteLine("----------------------------------");

        string text = "";

        do
        {
            text += Console.ReadLine();
            text += Environment.NewLine;
        }
        while (Console.ReadKey().Key != ConsoleKey.Escape);

        Console.WriteLine(text);
    }
}