using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_ListaLigadaPilhaEFila
{
	partial class Program
	{
		static void UsandoPilha()
		{
            var navegador = new Navegador();

            navegador.NavegarPara("google.com");
            navegador.NavegarPara("microsoft.com");
            navegador.NavegarPara("cursos.alura.com.br");

            navegador.PaginaAnterior();
            navegador.PaginaAnterior();
            navegador.PaginaAnterior();

            navegador.PaginaPosterior();
            navegador.PaginaPosterior();

            Console.ReadLine();
        }
	}
}