using _3_Sets.Models;
using _3_Sets.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Sets
{
	partial class Program
	{
		static void Sets()
		{
            // criando curso e logo em seguida adicionando aulas ao curso.
            Curso curso = new Curso("C# Collections", "Marcelo de Oliveira");
            curso.AdicionarAulas(new Aula("Trabalhando com Listas", 21), new Aula("Criando Alunos", 20), new Aula("Modelando Coleções", 24));

            // criando alunos.
            Aluno aluno1 = new Aluno("Marcelo Junior", 3451890);
            Aluno aluno2 = new Aluno("Gustavo Manzela", 3067412);
            Aluno aluno3 = new Aluno("Victor Luiz", 3265710);

            // matriculando alunos no curso.
            curso.MatricularAlunos(aluno1, aluno2, aluno3);

            // imprimindo os alunos matriculados
            Console.WriteLine("Alunos matriculados");
            foreach (var aluno in curso.Alunos)
            {
                Console.WriteLine(aluno);
            }

            // verificar se o aluno2 está matriculado no curso.
            Console.WriteLine();
            Console.WriteLine($"O aluno2 {aluno2.Nome} está matriculado no curso? {curso.VerificarAlunoCadastrado(aluno2)}");

            Console.ReadLine();
        }
	}
}