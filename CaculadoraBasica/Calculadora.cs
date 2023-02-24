using System;
using System.Globalization;


namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fala ai pessoal, de buenas? Trago-lhes uma calculadora bem traquila pra ajudar na lógica e aprendizado");

            while (true)
            {
                Console.Write("Vamos lá, Digite o #1º número: ");
                double num1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.Write("Continuando... Digite o #2º número: ");
                double num2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.WriteLine("Escolha o que vc deseja: ");
                Console.WriteLine("1. Adição (+)");
                Console.WriteLine("2. Subtração (-)");
                Console.WriteLine("3. Multiplicação (*)");
                Console.WriteLine("4. Divisão (/)");

                int opcao = int.Parse(Console.ReadLine());

                double resultado = 0;

                switch (opcao)
                {
                    case 1:
                        resultado = num1 + num2;
                        break;
                    case 2:
                        resultado = num1 - num2;
                        break;
                    case 3:
                        resultado = num1 * num2;
                        break;
                    case 4:
                        resultado = num1 / num2;
                        break;
                    default:
                        Console.WriteLine("Não existe essa opção!.");
                        break;
                }

                Console.WriteLine($"Resultado: {resultado}\n");

                Console.WriteLine("Deseja fazer outra operação? (s/n)");
                string resposta = Console.ReadLine();

                if (resposta == "n")
                {
                    break;
                }
            }

            Console.WriteLine("Então, curtiu a calculadora ? deixa o lika e vamo nessa =P");
        }
    }
}
