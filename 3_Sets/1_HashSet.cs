using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Sets
{
    partial class Program
    {
        static void HashSet()
        {
            // SETS = conjuntos

            // Duas propriedades do Set
            // 1. não permite duplicidade;
            // 2. os elementos não são mantidos em ordem específica.
            // Obs.: Não é lançada nenhu tipo de exceção ao tentar duplicar informação, apenas não é efetuado a duplicata.

            // declarando set de alunos
            ISet<string> alunos = new HashSet<string>();

            // adicionando alunos
            alunos.Add("Marcelo Junior");
            alunos.Add("Ana Luiza");
            alunos.Add("Anna Carolina");

            Console.WriteLine(alunos);
            Console.WriteLine(string.Join(", ", alunos));

            // adicionado mais 3 alunos
            alunos.Add("Gustavo Manzela");
            alunos.Add("Filipe Silva");
            alunos.Add("Victor Luiz");

            Console.WriteLine();
            Console.WriteLine(string.Join(", ", alunos));

            // remover aluno e adicionando outro aluno
            alunos.Remove("Gustavo Manzela");
            alunos.Add("Fernanda Silva");

            Console.WriteLine();
            Console.WriteLine(string.Join(", ", alunos));

            // adicionando aluno já existente
            alunos.Add("Anna Carolina");

            Console.WriteLine();
            Console.WriteLine(string.Join(", ", alunos));

            // ordenando o conjunto de alunos
            //alunos.Sort(); // Obs.: ISet não contém definição para o método sort.

            // copiar para uma lista para conseguir ordenar o conjunto
            List<string> alunosEmLista = new List<string>(alunos);

            // ordenando a lista cópia do conjunto
            alunosEmLista.Sort();

            Console.WriteLine();
            Console.WriteLine(string.Join(", ", alunosEmLista));

            Console.ReadLine();
        }
    }
}