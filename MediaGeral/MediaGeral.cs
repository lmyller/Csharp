using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaGeral
{
    internal class MediaGeral
    {
        static void Main(string[] args)
        {
            new MediaGeral();
        }

        public MediaGeral()
        {
            Aluno aluno = criarAluno();

            for (int indice = 0; indice < aluno.QuantidadeDisciplinas; indice++)
                aluno.adicionarDisciplina(criarDisciplina(indice));

            exibirMensagem($"A média da nota do aluno {aluno.Nome} é {calcularMediaNota(aluno)}");
        }

        private float calcularMediaNota(Aluno aluno)
        {
            float soma = 0;
            int quantidadeProvas = 0;

            for (int indiceDisciplinas = 0; indiceDisciplinas < aluno.QuantidadeDisciplinas; indiceDisciplinas++)
                soma += somarNotasProvas(aluno.obterDisciplina(indiceDisciplinas), ref quantidadeProvas);

            return soma / quantidadeProvas;
        }

        private float somarNotasProvas(Disciplina disciplina, ref int quantidadeProvas)
        {
            float soma = 0;

            for (int indiceProvas = 0; indiceProvas < disciplina.QuantidadeProvasAdicionadas; indiceProvas++)
                soma += disciplina.obterNotaProva(indiceProvas);

            quantidadeProvas += disciplina.QuantidadeProvasAdicionadas;

            return soma;
        }

        private Aluno criarAluno()
        {
            return new Aluno(lerString("Nome do aluno: "), lerNumeroInteiro("Número de disciplinas: "));
        }

        private Disciplina criarDisciplina(int indice)
        {
            Disciplina disciplina = new Disciplina($"Disciplina{indice}", lerNumeroInteiro("Número de provas:"));

            for (int i = 0; i < disciplina.TamanhoVetorProvas; i++)
                disciplina.adicionarNotaProva(lerNota($"Nota da prova {i + 1}: "));

            Console.WriteLine(disciplina.Nome);
            return disciplina;  
        }

        private float lerNota(string mensagem)
        {
            exibirMensagem(mensagem);

            return float.Parse(Console.ReadLine());
        }

        private string lerString(string mensagem)
        {
            exibirMensagem(mensagem);

            return Console.ReadLine();
        }

        private int lerNumeroInteiro(string mensagem)
        {
            exibirMensagem(mensagem);

            return int.Parse(Console.ReadLine());  
        }

        private void exibirMensagem(string mensagem)
        {
            Console.Write(mensagem);
        }
    }
}
