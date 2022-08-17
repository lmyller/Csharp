using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaCadastro
{
    public class ListaPessoas
    {
        private List<Pessoa> pessoas;

        public ListaPessoas()
        {
            pessoas = new List<Pessoa>();
        }

        public void AdicionarPessoa(Pessoa pessoa)
        {
            pessoas.Add(pessoa);  
        }

        public Pessoa ObterPessoa(int posicao)
        {
            return pessoas.ElementAt(posicao);
        }

        public int QuantidadePessoas()
        {
            return pessoas.Count();
        }

        public bool RemoverPessoa(string nome)
        {
            int posicao = 0;

            if (PesquisarPessoa(nome, ref posicao))
            {
                pessoas.RemoveAt(posicao);

                return true;
            }

            return false;
        }

        private bool PesquisarPessoa(string nome, ref int posicao)
        {
            for (int indice = 0; indice < QuantidadePessoas(); indice++)
            {
                if (ObterPessoa(indice).Nome.Equals(nome))
                {
                    posicao = indice;

                    return true;
                }
            }

            return false;
        }
    }
}
