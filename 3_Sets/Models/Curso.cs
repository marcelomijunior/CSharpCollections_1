using _3_Sets.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Sets.Models
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
        // implementando um dicionário de alunos.
        private IDictionary<int, Aluno> dicionarioAlunos = new Dictionary<int, Aluno>();
        private ISet<Aluno> alunos = new HashSet<Aluno>();
        public IList<Aluno> Alunos
        {
            get
            {
                return new ReadOnlyCollection<Aluno>(alunos.ToList());
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

        public void MatricularAluno(Aluno aluno)
        {
            if (aluno == null)
            {
                throw new ArgumentNullException();
            }

            alunos.Add(aluno);
            dicionarioAlunos.Add(aluno.NumeroMatricula, aluno);
        }

        public void MatricularAlunos(params Aluno[] alunos)
        {
            foreach (var aluno in alunos)
            {
                this.alunos.Add(aluno);
                dicionarioAlunos.Add(aluno.NumeroMatricula, aluno);
            }
        }

        public bool VerificarAlunoCadastrado(Aluno aluno)
        {
            return alunos.Contains(aluno);
        }

        public Aluno BuscarAlunoMatriculado(int numeroMatricula)
        {
            // realizando a busca do aluno pelo seu hashset
            //foreach (var aluno in Alunos)
            //{
            //    if (aluno.NumeroMatricula == numeroMatricula)
            //    {
            //        return aluno;
            //    }
            //}

            //throw new Exception($"Matrícula {numeroMatricula} não encontrada.");

            // realizando a busca do aluno pelo Dictionary.
            //return dicionarioAlunos[numeroMatricula];
            Aluno aluno = null;
            dicionarioAlunos.TryGetValue(numeroMatricula, out aluno);

            return aluno;
        }

        public override string ToString()
        {
            return $"\nCurso {Nome} \nInstrutor: {Instrutor} \nDuração: {TempoTotalDoCurso} minutos \nAulas: \n - {String.Join("\n - ", aulas)} \n";
        }
    }
}
