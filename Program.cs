using System;

namespace Calculadora

{
    class Program
    {
        static void Main()
        {
            double valor1 = 0, valor2 = 0, resultado, numero;
            string chave, inputUsuario;
            bool inputTest, contador = true;

            Console.WriteLine("Programa que faz calculos 'Calculadora Simples'");
            Console.WriteLine("");

            while (contador)
            {
                Console.WriteLine("Digite o primeiro número: ");
                inputUsuario = Console.ReadLine();
                inputTest = double.TryParse(inputUsuario, out numero);
                if (inputTest)
                {
                    valor1 = double.Parse(inputUsuario);
                    contador = false;
                }
                else
                {
                    Console.WriteLine("Digite um número válido");
                }
            }

            contador = true;

            while (contador)
            {
                Console.WriteLine("Digite o segundo número: ");
                inputUsuario = Console.ReadLine();
                inputTest = double.TryParse(inputUsuario, out numero);
                if (inputTest)
                {
                    valor2 = double.Parse(inputUsuario);
                    contador = false;
                }
                else
                {
                    Console.WriteLine("Digite um número válido");
                }
            }

            Console.WriteLine("Digite qual operação deseja realizar | '+' | '-' | '/' | '*' |");
            chave = Console.ReadLine();

            if (!(chave == "/" && (valor1 == 0 || valor2 == 0)))
            {
                switch (chave)
                {
                    case "+":
                        resultado = Math.Round(valor1 + valor2, 4);
                        Console.WriteLine($"{valor1}{'+'}{valor2} = {resultado}");
                        break;

                    case "-":
                        resultado = Math.Round(valor1 - valor2, 4);
                        Console.WriteLine($"{valor1}{'-'}{valor2} = {resultado}");
                        break;

                    case "*":
                        resultado = Math.Round(valor1 * valor2, 4);
                        Console.WriteLine($"{valor1}{'*'}{valor2} = {resultado}");
                        break;

                    case "/":
                        resultado = Math.Round(valor1 / valor2, 4);
                        Console.WriteLine($"{valor1}{'/'}{valor2} = {resultado}");
                        break;
                    default:
                        Console.WriteLine("Digite uma operação válida!");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Não pode ser divido por 0!");
            }

            Console.ReadKey();
        }
    }
}


