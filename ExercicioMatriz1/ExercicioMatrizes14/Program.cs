using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication26
{
	class Program
	{
		static void Main(string[] args)
		{
			/*
            Dado um vetor com 10 posições,
            escreva um programa para informar se há números repetidos
            */

			int[] numeros = { 1, 2, 2, 3, 3, 4, 5, 6, 7, 7, 8, 15, 15 };
			int[] numRepetido = new int[numeros.Length];

			if (VerificarNumRepetido(numeros, numRepetido) == true)
			{
				Console.WriteLine("Existem números repetidos no vetor, eles são: ");
				for (int i = 0; i < numRepetido.Length; i++)
				{
					if (numRepetido[i] == 0)
					{

					}
					else
					{
						Console.Write("{0} ", numRepetido[i]);
					}
				}
			}
			else
			{
				Console.WriteLine("Não existem números repetidos no vetor");
			}
		}

		static bool VerificarNumRepetido(int[] vetor, int[] vetorNumRepetido)
		{
			int cont = 0;

			for (int i = 0; i < vetor.Length - 1; i++)
			{
				for (int x = i + 1; x < vetor.Length; x++)
				{
					if (vetor[i] == vetor[x])
					{
						vetorNumRepetido[cont] = vetor[i];
						cont++;
					}
				}
			}
			if (cont > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
	}
}
