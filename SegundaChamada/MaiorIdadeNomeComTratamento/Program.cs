using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaiorIdadeNomeComTratamento
{
	class Program
	{
		static void Main(string[] args)
		{
			string nome, nomeMaiorIdade = "";
			int idade, maiorIdade = 0, i = 1;

			while (i <= 5) //Repete enquanto o i for menor ou igual que 5
			{
				Console.Write("Digite o {0}º nome: ", i);
				nome = Console.ReadLine();
				Console.Write("Digite a {0}ª idade: ", i);
				try
				{
					idade = Convert.ToInt32(Console.ReadLine());
				}
				catch
				{
					Console.WriteLine("Digite uma idade válida");
					continue; //Força iteração
				}

				if (idade < 0 || idade > 130)
				{
					Console.WriteLine("Digite uma idade válida");
					continue;
				}

				if (idade > maiorIdade)
				{
					nomeMaiorIdade = nome;
					maiorIdade = idade;
				}
				i++; //Aumenta o contador em 1
			}

			Console.WriteLine("A pessoa com a maior idade é: {0} com {1} anos", nomeMaiorIdade, maiorIdade);
			Console.ReadKey();
		}
	}
}
