using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaGeral
{
    public class Disciplina
    {
        private const int TAMANHO_VETOR_PROVAS = 4;

        public string Nome { get; set; }
        private Prova[] provas;
        public int TamanhoVetorProvas { get; set; }
        public int QuantidadeProvasAdicionadas { get; set; }

        public Disciplina() { }

        public Disciplina(string nome, int quantidadeProvas)
        {
            this.Nome = nome;
            provas = new Prova[quantidadeProvas];
            TamanhoVetorProvas = quantidadeProvas;
        }

        public Disciplina(string nome)
        {
            this.Nome = nome;
            provas = new Prova[TAMANHO_VETOR_PROVAS];
            TamanhoVetorProvas = TAMANHO_VETOR_PROVAS;
        }

        public bool adicionarNotaProva(float nota) {
            if(QuantidadeProvasAdicionadas == provas.Length)
                return false;

            provas[QuantidadeProvasAdicionadas] = new Prova();
            provas[QuantidadeProvasAdicionadas++].Nota = nota;

            return true;
        }
        
        public float obterNotaProva(int posicao) {
            return provas[posicao].Nota;
        }

        private class Prova
        {
            public float Nota { get; set; }
        }
    }
}
