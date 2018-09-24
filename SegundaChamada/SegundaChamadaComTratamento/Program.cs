using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundaChamadaComTratamento
{
	class Program
	{
		static void Main(string[] args)
		{

			int alunos, nota;

			while (true) //Loop infinito
			{
				Console.Write("Informe a quantidade de alunos que farão a segunda chamada: ");
				try
				{
					alunos = Convert.ToInt32(Console.ReadLine());
				}
				catch
				{
					Console.WriteLine("Digite uma quantidade válida");
					continue; //Força iteração pra repetir semrpe que der erro
				}
				if (alunos < 0)
				{
					Console.WriteLine("Digite um número positivo");
					continue;
				}
				Console.Clear();
				break;
			}

			if (alunos == 0)
			{
				Console.WriteLine("Sem alunos para fazer a segunda chamada");
			}
			else
			{
				int i = 1;
				double mediaGeral = 0;

				while (i <= alunos) //Enquanto i for menor ou igual alunos, vai repetir
				{
					Console.Write("Digite a nota do {0}º aluno que fez a segunda chamada: ", i);
					try
					{
						nota = Convert.ToInt32(Console.ReadLine());
					}
					catch
					{
						Console.WriteLine("Digite uma nota válida");
						continue;
					}
					if (nota < 0 || nota > 10)
					{
						Console.WriteLine("Digite uma nota entre 0 e 10");
						continue;
					}
					mediaGeral += nota; //Somatório das notas
					i++; //aumenta o contador em 1 pra ter uma forma de sair do laço
				}
				mediaGeral = mediaGeral / alunos; //Média geral das notas
				Console.WriteLine("A média geral dos alunos que fizeram segunda chamada foi de: {0}", mediaGeral);
			}
			Console.ReadKey();
		}
	}
}
