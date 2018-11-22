using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
	class Program
	{
		static void Main(string[] args)
		{
			/* escrever um programa que receba um texto com uma sequencia de letras, uma letra e um número
               obs: a letra informada deverá estar contida no texto
               os dados recebidos deverão ser passado para uma função e retornar:
               VERDADEIRO, caso a primeira ocorrência da letra no texto, a quantidade de letras no texto for maior ou igual ao número
               informado
               FALSO, se até a primeira ocorrencia da letra no texto, a quantidade de letras no texto for maior ou igual ao número
               informado
               se o retorno for VERDADEIRO, deverá ser mostrado "quantidade igual ou superior"
               se o retorno for FALSO, deverá ser mostrado "quantidade inferior"
               saber a primeira ocorrencia até chegar na letra informada

               exemplo:
               texto: CONEXAOGLOBAL
               letra: A
               Número: 5
               Retorno: VERDADEIRO (pq até encontrar a primeira letra A, tem 5 letras) 
            */
			string texto, letraPesquisar;
			int numero;

			Console.Write("Texto: ");
			texto = Console.ReadLine().ToUpper();
			Console.Write("Letra: ");
			letraPesquisar = Console.ReadLine().ToUpper();

			try
			{
				Console.Write("Número: ");
				numero = Convert.ToInt32(Console.ReadLine());
			}
			catch
			{
				Console.WriteLine("Digite um número válido");
				return;
			}

			if (Verificar(texto, letraPesquisar, numero) == true)
			{
				Console.WriteLine("Quantidade igual ou superior");
			}
			else
			{
				Console.WriteLine("Quantidade inferior");
			}
		}

		static bool Verificar(string texto, string letrasPesquisar, int numero)
		{
			int contador = 0;

			for (int i = 0; i < texto.Length; i++)
			{
				if (letrasPesquisar == texto.Substring(i, 1))
				{
					break;
				}
				contador++;
			}

			if (numero <= contador)
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
