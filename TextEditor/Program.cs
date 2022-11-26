internal class Program
{
    private static void Main(string[] args)
    {

    }

    static void Menu()
    {
        Console.Clear();
        Console.WriteLine("O que voce deseja fazer?");
        Console.WriteLine("1- Abrir arquivo");
        Console.WriteLine("2- Criar novo arquivo");
        Console.WriteLine("0- Sair");
        short option = short.Parse(Console.Readline());
    }
}