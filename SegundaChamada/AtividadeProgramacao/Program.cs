using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeProgramacao
{
	class Program
	{
		static void Main(string[] args)
		{
			int alunos, nota;

			Console.Write("Informe a quantidade de alunos que farão a segunda chamada: ");
			alunos = Convert.ToInt32(Console.ReadLine());

			if (alunos == 0)
			{
				Console.WriteLine("Sem alunos para fazer a segunda chamada");
			}
			else
			{
				double mediaGeral = 0;

				for (int i = 1; i <= alunos; i++)
				{
					Console.Write("Digite a nota do {0}º aluno que fez a segunda chamada: ", i);
					nota = Convert.ToInt32(Console.ReadLine());
					mediaGeral += nota;
				}
				mediaGeral = mediaGeral / alunos;
				Console.WriteLine("A média geral dos alunos que fizeram segunda chamada foi de: {0}", mediaGeral);
			}
			Console.ReadKey();
		}
	}
}
