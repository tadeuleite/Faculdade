using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioMatrizes2
{
	class Program
	{
		static void Main(string[] args)
		{
			//Considere uma matriz 3x3 onde em cada elemento estão
			//armazenados números inteiros.
			//Mostrar todos os números das diagonais principais e secundárias

			/* 
			 0,0  0,1  0,2
			 1,0  1,1  1,2
			 2,0  2,1  2,2
			 */
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

			Console.WriteLine("Dos números digitados, os números que compõem a diagonal principal são:");
			for (int x = 0; x < 3; x++)
			{
				for (int y = 0; y < 3; y++)
				{
					if (x == y)
					{
						Console.Write("{0}", Numeros[x, y]);
					}
				}
			}

			Console.WriteLine("Dos números digitados, os números que compõem a diagonal secundária são:");
			for (int x = 0; x < 3; x++)
			{
				for (int y = 2; y >= 0; y--)
				{
					Console.Write("{0} ", Numeros[x, y]);
					break;
				}
			}
		}
	}
}
