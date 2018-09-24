using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumerosPares2ComTratamento
{
	class Program
	{
		static void Main(string[] args)
		{
			int numero;
			while (true) //Loop infinito
			{

				Console.Write("Digite um número máximo para saber os números pares até o zero: ");
				try
				{
					numero = Convert.ToInt32(Console.ReadLine());
				}
				catch
				{
					Console.WriteLine("Informe um número válido");
					continue; //Força iteração pra repetir sempre que der erro
				}
				if (numero < 0)
				{
					Console.WriteLine("Digite um número válido");
					continue;
				}
				Console.Clear();
				break; //Se tudo der certo, quebra o laço
			}
			Console.WriteLine("Números positivos em ordem decrescente");
			for (int i = numero; i >= 0; i -= 2)
			{
				Console.Write("{0}, ", i);
			}
			Console.ReadKey();

		}
	}
}
