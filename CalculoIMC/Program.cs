﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoIMC
{
    internal class Program
    {
        private const string LER_PESO = "Peso: ",
                             LER_ALTURA = "Altura: ",
                             PESO_BAIXO = "Abaixo do peso",
                             PESO_SAUDAVEL = "Peso saudável",
                             SOBREPESO = "Sobrepeso",
                             OBESO = "Obeso",
                             OBESO_MORBIDO = "Obeso mórbida";

        static void Main(string[] args)
        {
            calculoIMC();
        }

        private static void calculoIMC()
        {
            float peso = lerNumeroReal(LER_PESO);
            float altura = lerNumeroReal(LER_ALTURA);
            float imc = calcularIMC(peso, altura);

            if (imc < 18.5)
                exibirMensagem(PESO_BAIXO);

            else if (imc <= 24.9)
                exibirMensagem(PESO_SAUDAVEL);

            else if (imc <= 29.9)
                exibirMensagem(SOBREPESO);

            else if (imc <= 39.9)
                exibirMensagem(OBESO);

            else exibirMensagem(OBESO_MORBIDO);
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
