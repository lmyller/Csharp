using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            calculadora();
        }

        private static void calculadora()
        {
            int opcao;

            do
            {
                opcao = lerNumeroInteiro("\n1- Somar\n2- Dividir\n3- Multiplicar\n4- Dividir\n5- Sair\n");
                if (opcao == 5)
                    break;

                double numero1 = lerNumeroReal("Número 1: ");
                double numero2 = lerNumeroReal("Número 2: ");

                switch (opcao)
                {
                    case 1: exibirResultado(somar(numero1, numero2)); break;
                    case 2: exibirResultado(subtrair(numero1, numero2)); break;
                    case 3: exibirResultado(multiplicar(numero1, numero2)); break;
                    case 4: exibirResultado(dividir(numero1, numero2)); break;
                }
            } while (opcao != 5);
        }

        private static void exibirResultado(double resultado)
        {
            exibirMensagem("Resultado: " + resultado);
        }

        private static double somar(double numero1, double numero2)
        {
            return numero1 + numero2;
        }

        private static double subtrair(double numero1, double numero2)
        {
            return numero1 - numero2;
        }
        
        private static double multiplicar(double numero1, double numero2)
        {
            return numero1 * numero2;
        }

        private static double dividir(double numero1, double numero2)
        {
            return numero1 / numero2;
        }

        private static int lerNumeroInteiro(string mensagem)
        {
            exibirMensagem(mensagem);

            return int.Parse(Console.ReadLine());
        }

        private static double lerNumeroReal(string mensagem)
        {
            exibirMensagem(mensagem);

            return double.Parse(Console.ReadLine());
        }

        private static void exibirMensagem(string mensagem)
        {
            Console.Write(mensagem);
        }
    }
}
