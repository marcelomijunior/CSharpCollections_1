using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_ListaAColecaoFlexivel.Models
{
    internal class Aula : IComparable
    {
        private int qtdAulasCadastradas;
        public int QtdAulasCadastradas
        {
            get
            {
                return qtdAulasCadastradas;
            }
        }
        public string Titulo { get; }
        public int Tempo { get; }

        public Aula(string titulo, int tempo)
        {
            Titulo = titulo;
            Tempo = tempo;

            qtdAulasCadastradas++;
        }

        public override string ToString()
        {
            return $"[ Aula: {Titulo}, Tempo de aula: {Tempo} minutos ]";
        }

        public int CompareTo(object obj)
        {
            var aula = obj as Aula;

            return Titulo.CompareTo(aula.Titulo);
        }
    }
}
