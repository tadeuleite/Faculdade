using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumerosPares1ComTratamento
{
	class Program
	{
		static void Main(string[] args)
		{
			int numero;
			while (true) //Loop infinito
			{

				Console.Write("Digite um número inteiro para saber todos os número pares positivos até ele: ");
				try
				{
					numero = Convert.ToInt32(Console.ReadLine());
				}
				catch
				{
					Console.WriteLine("Digite um número válido");
					continue;
				}
				if (numero < 0)
				{
					Console.WriteLine("Digite um número positivo");
					continue; //Força iteração
				}
				Console.Clear();
				break; //Quebra o laço de repetição
			}

			for (int i = 0; i <= numero; i += 2)
			{
				Console.Write("{0}, ", i);
			}

			Console.ReadKey();

		}
	}
}
