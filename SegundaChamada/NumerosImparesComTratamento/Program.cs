using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumerosImparesComTratamento
{
	class Program
	{
		static void Main(string[] args)
		{
			int numero;

			while (true) //Loop infinito
			{

				Console.Write("Digite um número os números impares até ele: ");
				try
				{
					numero = Convert.ToInt32(Console.ReadLine());
				}
				catch
				{
					Console.WriteLine("Digite um número válido");
					continue; //Forçar iteração
				}
				if (numero < 0)
				{
					Console.WriteLine("Digite um número positivo");
					continue;
				}
				Console.Clear();
				break; //Quebrar laço
			}

			Console.WriteLine("Números impares em ordem crescente");
			for (int i = 1; i <= numero; i += 2)
			{
				Console.Write("{0}, ", i);
			}

			Console.ReadKey();

		}
	}
}
