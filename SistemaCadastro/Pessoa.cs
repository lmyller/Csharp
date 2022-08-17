using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaCadastro
{
    public class Pessoa
    {
        public Pessoa(string nome, string sexo, string telefone, string estadoCivil, string dataNascimento)
        {
            Nome = nome;
            Sexo = sexo;
            Telefone = telefone;
            EstadoCivil = estadoCivil;
            DataNascimento = dataNascimento;
        }

        public string Nome { get; set; }
        public string Sexo { get; set; }
        public string Telefone { get; set; }
        public string EstadoCivil { get; set; }
        public string DataNascimento { get; set; }  

    }
}
