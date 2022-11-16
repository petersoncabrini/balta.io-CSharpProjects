namespace Calculator
{
    class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Primeiro valor:");
        float v1 = float.Parse(Console.ReadLine());
        Console.WriteLine("Segundo valor:");
        float v2 = float.Parse(Console.ReadLine());

        float resultado = v1 + v2;

        Console.WriteLine("");

        //Concatenação
        Console.WriteLine("O resultado da soma é: " + resultado);

        //Interpolação
        Console.WriteLine($"O resultado da soma é {resultado}");
    }
}
}

