using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2_ListaAColecaoFlexivel.Extensoes;
using _2_ListaAColecaoFlexivel.Models;

namespace _2_ListaAColecaoFlexivel
{
    partial class Program
    {
        static void Main(string[] args)
        {
            Curso csharpColecoes = new Curso("C# Collections", "Marcelo");

            csharpColecoes.AdicionarAula(new Aula("Trabalhando com Listas", 21));

            // Add + 2 aulas
            csharpColecoes.AdicionarAula(new Aula("Conceito de Modelagem Coleções de Listas", 20));
            csharpColecoes.AdicionarAula(new Aula("Modelando Coleções", 21));

            // Ordenar a Lista de Aulas.
            //csharpColecoes.Aulas.Sort(); Nota: A interface IList não implementa o método Sort().

            // Copiar a lista de Aulas para uma nova Lista dessas Aulas já cadastradas.
            List<Aula> aulasCopiadas = new List<Aula>(csharpColecoes.Aulas);

            // Imprimir as aulas
            Imprimir(csharpColecoes.Aulas);

            // Totalizando o tempo do Curso
            Console.WriteLine("Tempo total de curso: " + csharpColecoes.TempoTotalDoCurso);

            // Imprimindo informação do curso
            Console.WriteLine(csharpColecoes.ToString());

            Console.WriteLine();
            Console.WriteLine("Tecle enter para finalizar aplicação...");
            Console.ReadLine();
        }

        static void Imprimir(IList<Aula> aulas)
        {
            Console.WriteLine();

            foreach (var aula in aulas)
            {
                Console.WriteLine(aula.ToString());
            }
        }
    }
}
