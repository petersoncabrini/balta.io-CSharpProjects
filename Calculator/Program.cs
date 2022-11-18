namespace Calculator
{
    class Program
    {
        private static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Calculadora C#");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Multiplicação");
            Console.WriteLine("5 - Sair");
            Console.WriteLine("-----------------");
            Console.WriteLine("Selecione uma opção: ");

            short opcao = short.Parse(Console.ReadLine());
        }


        static void soma()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor:");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Segundo valor:");
            float v2 = float.Parse(Console.ReadLine());

            float resultado = v1 + v2;

            Console.WriteLine("");

            //Concatenação
            // Console.WriteLine("O resultado da soma é: " + resultado);

            //Interpolação
            Console.WriteLine($"O resultado da soma é {resultado}");

            Console.ReadKey();
        }

        static void Subtracao()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor:");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Segundo valor:");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1 - v2;
            Console.WriteLine($"Oresultado da subtracao é {resultado}");

            Console.ReadKey();
        }

        static void Divisao()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor:");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor:");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1 / v2;

            Console.WriteLine($"O resultado da divisão é {resultado}");

            Console.ReadKey();
        }

        static void Multiplicacao()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1 * v2;
            Console.WriteLine($"O resultado da multiplicação é {resultado}");
            Console.ReadKey();
        }
    }
}

