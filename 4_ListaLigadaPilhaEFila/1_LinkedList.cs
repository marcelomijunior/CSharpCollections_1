using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_ListaLigadaPilhaEFila
{
    partial class Program
    {
        static void UsandoLinkedList()
        {

            List<string> frutas = new List<string>
            {
                "abacate", "banana", "damasco", "fígo", "caqui"
            };

            Console.WriteLine("Lista de frutas");

            for (int i = 0; i < frutas.Count; i++)
            {
                Console.WriteLine("- " + frutas[i]);
            }
            Console.WriteLine();

            LinkedList<string> diasDaSemana = new LinkedList<string>();
            var d4 = diasDaSemana.AddFirst("quarta-feira");
            var d2 = diasDaSemana.AddBefore(d4, "segunda-feira");
            var d3 = diasDaSemana.AddAfter(d2, "terça-feira");
            var d6 = diasDaSemana.AddAfter(d4, "sexta-feira");
            var d7 = diasDaSemana.AddAfter(d6, "sábado");
            var d5 = diasDaSemana.AddBefore(d6, "quinta-feira");
            var d1 = diasDaSemana.AddBefore(d2, "domingo");

            Console.WriteLine("Dias da Semana");

            foreach (var dia in diasDaSemana)
            {
                Console.WriteLine("- " + dia);
            }
            // Obs.: O LinkedList NÃO DÁ SUPORTE ao acesso de índice: diasDaSemana[3]. Por esse motivo não podemos usar o laço for.

            Console.ReadLine();
        }
    }
}