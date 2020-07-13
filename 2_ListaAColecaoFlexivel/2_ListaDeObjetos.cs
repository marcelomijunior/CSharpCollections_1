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
		static void ListaDeObjetos()
        {
            var aulaIntro = new Aula("Introdução às Collections", 20);
            var aulaModelando = new Aula("Modelando a Classe Aula", 18);
            var aulaSets = new Aula("Trabalhando com Conjustos", 16);

            List<Aula> aulas = new List<Aula>();
            aulas.Adicionar(aulaIntro, aulaModelando, aulaSets);

            ImprimirListaDeObjetos(aulas);

            aulas.Sort();
            ImprimirListaDeObjetos(aulas);

            aulas.Sort((a, b) => a.Tempo.CompareTo(b.Tempo));
            ImprimirListaDeObjetos(aulas);

            Console.WriteLine("Tecle enter para finalizar aplicação...");
            Console.ReadLine();
        }

        static void ImprimirListaDeObjetos(List<Aula> lista)
        {
            Console.WriteLine();

            foreach (var aula in lista)
            {
                Console.WriteLine(aula.ToString());
            }
        }
    }
}