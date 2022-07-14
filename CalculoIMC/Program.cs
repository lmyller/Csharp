using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoIMC
{
    internal class Program
    {
        private const string LER_PESO = "Peso: ",
                             LER_ALTURA = "Altura: ";

        static void Main(string[] args)
        {
            calculoIMC();
        }

        private static void calculoIMC()
        {
            float peso = lerNumeroReal(LER_PESO);
            float altura = lerNumeroReal(LER_ALTURA);

            Console.WriteLine(calcularIMC(peso, altura));
        }

        private static float calcularIMC(float peso, float altura)
        {
            return peso / (altura * altura);
        }

        public static float lerNumeroReal(string mensagem)
        {
            exibirMensagem(mensagem);

            return float.Parse(Console.ReadLine());
        }

        public static void exibirMensagem(string mensagem)
        {
            Console.Write(mensagem);
        }
    }
}
