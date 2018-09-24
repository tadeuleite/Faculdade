using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaiorIdadeNome
{
	class Program
	{
		static void Main(string[] args)
		{
			string nome, nomeMaiorIdade = "";
			int idade, maiorIdade = 0;

			for (int i = 1; i <= 5; i++)
			{
				Console.Write("Digite o {0}º nome: ", i);
				nome = Console.ReadLine();
				Console.Write("Digite a {0}ª idade: ", i);
				idade = Convert.ToInt32(Console.ReadLine());

				if (idade > maiorIdade) //Se a idade for maior que a maior idade anterior, essa idade é armazenada junto com o nome
										//para futuras iterações do for e depois mostrar qual o nome da pessoa com maior idade
				{
					nomeMaiorIdade = nome;
					maiorIdade = idade;
				}
			}

			Console.WriteLine("A pessoa com a maior idade é: {0} com {1} anos", nomeMaiorIdade, maiorIdade);
			Console.ReadKey();
		}
	}
}
