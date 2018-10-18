using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioMatrizes3
{
	class Program
	{
		static void Main(string[] args)
		{
			/*Escreva um programa para receber uma matriz (5 x 2) que conterá o nomes e sexo de 5 pessoas.
			• Quantidade de pessoas do sexo masculino
			• Quantidade de pessoas do sexo feminino
			• Nome da pessoa com a maior quantidade de caracteres no nome (considerar que poderá ter mais de uma pessoa)
			*/

			string[,] NomeSexo = new string[5, 2];
			int contadorM = 0, contadorF = 0; // contadores masculino e feminino
			int maiorNome = 0; //gravar a quantidade de caracteres do nome maior
			string nomeGravar = "";

			string[] NomeIgual = new string[5];
			bool retorno = false;

			for (int i = 0; i < 5; i++)
			{
				Console.WriteLine("Digite o nome");
				NomeSexo[i, 0] = Console.ReadLine();
				Console.WriteLine("Digite o sexo (use M para masculino e F para feminino)");
				NomeSexo[i, 1] = Console.ReadLine().ToUpper();

				if (NomeSexo[i, 1] == "M")
				{
					contadorM++;
				}
				if (NomeSexo[i, 1] == "F")
				{
					contadorF++;
				}
				if (NomeSexo[i, 0].Length > maiorNome) //saber qual nome é o maior
				{
					nomeGravar = NomeSexo[i, 0];
					maiorNome = NomeSexo[i, 0].Length;
				}

				if (NomeSexo[i, 0].Length == maiorNome)
				{

				}

			}
					for (int x = 0; x < NomeIgual.Length; x++) //esvaziar pra caso tenha dois nomes com tamanhos iguais antes
					{
						NomeIgual[x] = " ";
					}
					for (int j = 0; j < 5; j++)
					{
						NomeIgual[j] = NomeSexo[j, 0];
					}
						retorno = true;
			if (retorno == true)
			{
				Console.WriteLine("Os nomes com maior quantidade de caracteres foram:");
				for (int z = 0; z < 5; z++)
				{
					Console.WriteLine("{0} ", NomeIgual[z]);
				}
			}
			else
			{

				Console.WriteLine("A pessoa com o maior nome foi: {0}", nomeGravar);
				Console.WriteLine("Das pessoas informadas, {0} são do sexo masculino e {1} do sexo feminino", contadorM, contadorF);
			}
		}
	}
}
