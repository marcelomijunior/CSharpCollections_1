using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_ListaAColecaoFlexivel.Models
{
    internal class Curso
    {
        private int qtdCursosCadastrados;
        public int QtdCursosCadastrados
        {
            get
            {
                return qtdCursosCadastrados;
            }
        }
        private IList<Aula> aulas;
        public IList<Aula> Aulas
        {
            get
            {
                return new ReadOnlyCollection<Aula>(aulas);
            }
        }
        //public IList<Aula> Aulas { get; }
        public string Nome { get; }
        public string Instrutor { get; }
        public int TempoTotalDoCurso
        {
            get
            {
                //int tempoTotal = 0;
                //foreach (var aula in aulas)
                //{
                //    tempoTotal += aula.Tempo;
                //}

                //return tempoTotal;

                // LINQ = Lenguage Integrated Query
                // Consulta Integrada à Linguagem

                // O método SUM está somando repetidamente o tempo das aulas.
                return aulas.Sum(aula => aula.Tempo);
            }
        }

        public Curso(string nome, string instrutor)
        {
            Nome = nome;
            Instrutor = instrutor;
            this.aulas = new List<Aula>();

            qtdCursosCadastrados++;
        }

        public void AdicionarAula(Aula aula)
        {
            if (aula == null)
            {
                throw new ArgumentNullException();
            }

            this.aulas.Add(aula);
        }

        public void AdicionarAulas(params Aula[] aulas)
        {
            foreach (var aula in aulas)
            {
                this.aulas.Add(aula);
            }
        }

        public override string ToString()
        {
            return $"\nCurso {Nome} \nInstrutor: {Instrutor} \nDuração: {TempoTotalDoCurso} minutos \nAulas: \n - {String.Join("\n - ", aulas)} \n";
        }
    }
}
