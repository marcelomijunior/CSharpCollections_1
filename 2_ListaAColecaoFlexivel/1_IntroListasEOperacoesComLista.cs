using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_ListaAColecaoFlexivel
{
    partial class Program
    {
        static void IntroListasOperacoesLista()
        {
            string aulaIntro = "Introdução às Collections";
            string aulaModelando = "Modelando a Classe Aula";
            string aulaSets = "Trabalhando com Conjustos";

            //List<string> listaDeAulas = new List<string>
            //{
            //    aulaIntro,
            //    aulaModelando,
            //    aulaSets
            //};

            List<string> listaDeAulas = new List<string>();
            listaDeAulas.Add(aulaIntro); // Adicionando item na lista.
            listaDeAulas.Add(aulaModelando); // Adicionando item na lista.
            listaDeAulas.Add(aulaSets); // Adicionando item na lista.

            ImprimirIntroListasOperacoesLista(listaDeAulas);

            Console.WriteLine();
            Console.WriteLine("A primeira aula é " + listaDeAulas[0]);
            Console.WriteLine("A primeira aula é " + listaDeAulas.First()); // Pego a primeira posição do array.

            Console.WriteLine("A última aula é " + listaDeAulas[listaDeAulas.Count - 1]);
            Console.WriteLine("A última aula é " + listaDeAulas.Last()); // Pego a última posição do array.

            listaDeAulas[0] = "Trabalhando com listas";

            ImprimirIntroListasOperacoesLista(listaDeAulas);

            Console.WriteLine();

            // Procurando uma palavra que contém na lista de aulas.
            Console.WriteLine("A primeira aula 'trabalhando' é: "
                + listaDeAulas.First(aula => aula.Contains("Trabalhando"))); // Encontrar a primeira aula que contém a palavra "Trabalhando".

            Console.WriteLine("A última aula 'trabalhando' é: "
                + listaDeAulas.Last(aula => aula.Contains("Trabalhando"))); // Encontrar a última aula que contém a palavra "Trabalhando".

            Console.WriteLine("A primeira aula 'Conclusão' é: "
                + listaDeAulas.FirstOrDefault(aula => aula.Contains("Conclusão"))); // Encontrar aula que contém a palavra "Conclusão". Nota: Se usar o método First será lançado uma exceção.

            listaDeAulas.Reverse(); // Revertando as posições.
            ImprimirIntroListasOperacoesLista(listaDeAulas);

            listaDeAulas.Reverse(); // Revertando as posições.
            ImprimirIntroListasOperacoesLista(listaDeAulas);

            listaDeAulas.RemoveAt(listaDeAulas.Count - 1);
            ImprimirIntroListasOperacoesLista(listaDeAulas);

            listaDeAulas.Add("Conclusão");
            ImprimirIntroListasOperacoesLista(listaDeAulas);

            listaDeAulas.Sort(); // Ordenando a lista de aula.
            ImprimirIntroListasOperacoesLista(listaDeAulas);

            List<string> copiaDaLista = listaDeAulas.GetRange(listaDeAulas.Count - 2, 2); // Copiando os dois últimos itens da lista de aulas.
            ImprimirIntroListasOperacoesLista(copiaDaLista);

            List<string> cloneDaLista = new List<string>(listaDeAulas); // Clonando a lista de aulas.
            ImprimirIntroListasOperacoesLista(cloneDaLista);

            cloneDaLista.RemoveRange(cloneDaLista.Count - 2, 2); // Removendo os dois últimos itens de clone.
            ImprimirIntroListasOperacoesLista(cloneDaLista);

            Console.ReadLine();
        }

        private static void ImprimirIntroListasOperacoesLista(List<string> listaDeAulas)
        {
            Console.WriteLine();
            //foreach (var aula in listaDeAulas)
            //{
            //    Console.WriteLine(aula);
            //}

            //for (int i = 0; i < listaDeAulas.Count; i++)
            //{
            //    var aulaAtual = listaDeAulas[i];

            //    Console.WriteLine(aulaAtual);
            //}

            listaDeAulas.ForEach(aula =>
            {
                Console.WriteLine(aula);
            });
        }
    }
}