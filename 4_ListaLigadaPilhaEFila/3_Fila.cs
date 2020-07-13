using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_ListaLigadaPilhaEFila
{
	partial class Program
    {
        static Queue<string> pedagio = new Queue<string>();
        static void UsandoFila()
		{
            Enfileirar("Van");
            Enfileirar("Kombi");
            Enfileirar("Guincho");
            Enfileirar("Pickup");

            Desenfileirar();
            Desenfileirar();
            Desenfileirar();
            Desenfileirar();
            Desenfileirar();
            Desenfileirar();

            Console.ReadLine();
        }

        static void Enfileirar(string veiculo)
        {
            Console.WriteLine($"Entrou na fila: {veiculo}");
            pedagio.Enqueue(veiculo);

            ImprimirFila();
        }

        static void Desenfileirar()
        {
            if (pedagio.Any())
            {
                string veiculo = pedagio.Dequeue();
                Console.WriteLine($"Saiu fa fila: {veiculo}");

                ImprimirFila();
            }
        }

        static void ImprimirFila()
        {
            Console.WriteLine("Fila: ");

            foreach (var v in pedagio)
            {
                Console.WriteLine(v);
            }
        }
    }
}