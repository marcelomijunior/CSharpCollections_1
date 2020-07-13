using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_ComecandoComArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string aulaIntro = "Introdução às Collections";
            string aulaModelando = "Modelando a Classe Aula";
            string aulaSets = "Trabalhando com Conjustos";

            // O índice do elemento será sempre n-1.
            //string[] aulas = new string[] // Declarando implicitamente que tenho 3 elementos no meu array.
            //{
            //    aulaIntro, aulaModelando, aulaSets
            //};

            string[] aulas = new string[3]; // Declarando explicitamente que tenho 3 elementos no meu array.

            aulas[0] = aulaIntro;
            aulas[1] = aulaModelando;
            aulas[2] = aulaSets;

            //Console.WriteLine(aulas);
            ImprimirAulas(aulas);

            Console.WriteLine("Aula modelando está no indice: " + Array.IndexOf(aulas, aulaModelando));

            Array.Reverse(aulas);
            ImprimirAulas(aulas);

            Array.Reverse(aulas);
            ImprimirAulas(aulas);

            // Diminuindo meu array.
            Array.Resize(ref aulas, 2);
            ImprimirAulas(aulas);

            // Aumentando meu array novamente.
            Array.Resize(ref aulas, 3); // Nota: A última posição do meu array ficará nula.
            ImprimirAulas(aulas);

            aulas[aulas.Length - 1] = "Conclusão";
            ImprimirAulas(aulas);

            // Ordenando o array.
            Array.Sort(aulas);
            ImprimirAulas(aulas);

            string[] copia = new string[2];

            // Copiando os valores do array aulas para o array copia.
            Array.Copy(aulas, 1, copia, 0, 2);
            ImprimirAulas(copia);

            // Clonando o array aulas.
            // Nota: O visal studio não consegue converter o tipo objeto para string, então devemos realizar a conversão colocando "as string[]".
            string[] clone = aulas.Clone() as string[]; 
            ImprimirAulas(clone);

            Array.Clear(clone, 1, 2);
            ImprimirAulas(clone);

            Console.ReadLine();
        }

        private static void ImprimirAulas(string[] aulas)
        {
            Console.WriteLine();
            //foreach (var aula in aulas)
            //{
            //    Console.WriteLine(aula);
            //}

            for (int i = 0; i < aulas.Length; i++)
            {
                Console.WriteLine(aulas[i]);
            }
        }
    }
}
