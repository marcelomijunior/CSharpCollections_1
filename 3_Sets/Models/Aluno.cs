using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Sets.Models
{
    public class Aluno
    {
		private string nome;
		public string Nome
		{
			get { return nome; }
		}
		private int numeroMatricula;
		public int NumeroMatricula
		{
			get { return numeroMatricula; }
		}

		public Aluno(string nome, int matricula)
		{
			this.nome = nome;
			this.numeroMatricula = matricula;
		}

		public override bool Equals(object obj)
		{
			var outroAluno = obj as Aluno;

			if (outroAluno == null)
			{
				return false;
			}

			return NumeroMatricula == outroAluno.NumeroMatricula;
		}

		public override int GetHashCode()
		{
			return NumeroMatricula.GetHashCode();
		}
		// Obs.: Dosi objetos iguais possuem o mesmo hash code. 
		// Porém dois objetos com o mesmo hash code não são necessariamente iguais.

		public override string ToString()
		{
			return $"Nome: {Nome}, Matricula: {NumeroMatricula}";
		}
	}
}
