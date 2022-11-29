using System.IO;
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

        Save(text);
    }

    static void Save(string text)
    {
        Console.Clear();
        Console.WriteLine("Em qual diretorio voce deseja salvar o arquivo?");
        var path = Console.ReadLine();

        var file = new StreamWriter(path);
        using (file)
        {
            file.Write(text);
        }

        Console.WriteLine($"Arquivo {path} salvo com suessso!");
        Console.ReadLine();
        Menu();
    }
}