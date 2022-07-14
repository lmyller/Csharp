using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InverterNomes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome1 = Console.ReadLine();
            string nome2 = Console.ReadLine();
            string auxiliar;

            auxiliar = nome1;
            nome1 = nome2;
            nome2 = auxiliar;

            Console.WriteLine(nome1 + nome2);
        }
    }
}
