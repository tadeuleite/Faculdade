using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioMatrizes
{
	class Program
	{
		static void Main(string[] args)
		{
			//Considere uma matriz 3x3 onde em cada elemento estão
			//armazenados números inteiros.
			//Mostrar todos os números das linhas pares

			int[,] Numeros = new int[3, 3];
			int contador = 1;

			for (int i = 0; i < 3; i++)
			{
				for (int j = 0; j < 3; j++)
				{
					Console.Write("Digite o {0}º número na casa [{1},{2}]: ", contador, i, j);
					Numeros[i, j] = Convert.ToInt32(Console.ReadLine());
					contador++;
				}
			}

			Console.WriteLine("\n Números das linhas que forem pares");
			for (int x = 0; x < 3; x++) //percorre as linhas da matriz
			{
				if (Numeros[x, 0] % 2 == 0) //se a linha for divisível por 2, exibe os números que estão nessa linha
				{
					for (int z = 0; z < 3; z++) //exibir os números que estão na linha
					{
						Console.Write("{0}  ", Numeros[x, z]);
					}
				}
			}
			Console.ReadKey();
		}
	}
}
