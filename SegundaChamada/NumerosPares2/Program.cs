using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumerosPares2
{
	class Program
	{
		static void Main(string[] args)
		{
			int numero;

			Console.Write("Digite um número máximo para saber os números pares até o zero: ");
			numero = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Números pares positivos em ordem decrescente");
			for (int i = numero; i >= 0; i -= 2)
			{
				Console.Write("{0}, ", i);
			}
			Console.ReadKey();
		}
	}
}
