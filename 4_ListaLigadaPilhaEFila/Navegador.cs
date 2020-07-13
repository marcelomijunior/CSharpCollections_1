using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_ListaLigadaPilhaEFila
{
    internal class Navegador
    {
        private readonly Stack<string> historicoAnterior = new Stack<string>();
        private readonly Stack<string> historicoPosterior = new Stack<string>();
        private string paginaAtual = "vazia";
        public Navegador()
        {
            Console.WriteLine("Página atual: " + paginaAtual);
        }

        public void NavegarPara(string url)
        {
            historicoAnterior.Push(paginaAtual);
            paginaAtual = url;
            Console.WriteLine("Página atual: " + paginaAtual);
        }

        public void PaginaAnterior()
        {
            if (historicoAnterior.Any())
            {
                historicoPosterior.Push(paginaAtual);
                paginaAtual = historicoAnterior.Pop();
                Console.WriteLine("Página atual: " + paginaAtual);
            }
        }

        public void PaginaPosterior()
        {
            if (historicoPosterior.Any())
            {
                historicoAnterior.Push(paginaAtual);
                paginaAtual = historicoPosterior.Pop();
                Console.WriteLine("Página atual: " + paginaAtual);
            }
        }
    }
}