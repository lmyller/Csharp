using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorTemperatura
{
    internal class Program
    {
        private const string FARENHEIT = "Farenheit";
        private const string KELVIN = "Kelvin";

        static void Main(string[] args)
        {
            conversorTemperatura();
        }

        private static void conversorTemperatura()
        {
            float temperatura = receberTemperaturaEmCelsius();
            exibirTemperatura(temperatura, FARENHEIT);
            exibirTemperatura(temperatura, KELVIN);
        }

        private static void exibirTemperatura(float temperatura, string medidaTemperatura)
        {
            if (medidaTemperatura.Equals(FARENHEIT))
                exibirTemperaturaEmFarenheit(temperatura);

            else
                exibirTemperaturaEmKelvin(temperatura);
        }

        private static void exibirTemperaturaEmFarenheit(float temperatura)
        {
            Console.WriteLine(temperatura * 1.8 + 32);
        }

        private static void exibirTemperaturaEmKelvin(float temperatura)
        {
            Console.WriteLine(temperatura + 273);
        }

        private static float receberTemperaturaEmCelsius()
        {
            return float.Parse(Console.ReadLine());
        }
    }
}
