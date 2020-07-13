using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_ListaAColecaoFlexivel.Extensoes
{
    internal static class ListExtensao
    {
        public static void Adicionar<T>(this List<T> lista, params T[] itens)
        {
            foreach (var item in itens)
            {
                lista.Add(item);
            }
        }
    }
}
