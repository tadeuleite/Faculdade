using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundaChamada
{
	class Program
	{
		static void Main(string[] args)
		{
			int alunos, nota;

			Console.Write("Informe a quantidade de alunos que farão a segunda chamada: ");
			alunos = Convert.ToInt32(Console.ReadLine());

			if (alunos == 0) //Se não tiver alunos para segunda chamada, nem executa o resto
			{
				Console.WriteLine("Sem alunos para fazer a segunda chamada");
			}
			else //Caso tenha alunos para segunda chamada
			{
				double mediaGeral = 0; //Caso não tivesse alunos para segunda chamada, não seria necessário alocar essa variável antes

				for (int i = 1; i <= alunos; i++) //Repete enquanto o i for menor ou igual a quantidade de alunos da segunda chamada
				{
					Console.Write("Digite a nota do {0}º aluno que fez a segunda chamada: ", i);
					nota = Convert.ToInt32(Console.ReadLine());
					mediaGeral += nota; //Somatório das notas
				}
				mediaGeral = mediaGeral / alunos; //Média geral das notas
				Console.WriteLine("A média geral dos alunos que fizeram segunda chamada foi de: {0}", mediaGeral);
			}
			Console.ReadKey();
		}
	}
}
