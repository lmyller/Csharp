using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaGeral
{
    public class Aluno
    {
        private const int TAMANHO_VETOR_DISCIPLINAS = 4;

        public string Nome { get; set; }
        private Disciplina[] disciplinas;
        public int QuantidadeDisciplinas { get; set; }
        public int QuantidadeDisciplinasAdicionadas { get; set; }


        public Aluno(string nome, int quantidadeDisciplinas)
        {
            this.Nome = nome;
            disciplinas = new Disciplina[quantidadeDisciplinas];
            this.QuantidadeDisciplinas = quantidadeDisciplinas;
        }

        public Aluno(string nome)
        {
            this.Nome = nome;
            disciplinas = new Disciplina[TAMANHO_VETOR_DISCIPLINAS];
            this.QuantidadeDisciplinas = TAMANHO_VETOR_DISCIPLINAS;
        }

        public void adicionarDisciplina(Disciplina disciplina)
        {
            disciplinas[QuantidadeDisciplinasAdicionadas] = new Disciplina();
            disciplinas[QuantidadeDisciplinasAdicionadas++] = disciplina;
        }

        public Disciplina obterDisciplina(int posicao)
        {
            return disciplinas[posicao];
        }
    }
}
