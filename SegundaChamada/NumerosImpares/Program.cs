using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumerosImpares
{
	class Program
	{
		static void Main(string[] args)
		{
			int numero;

			Console.Write("Digite um número os números impares até ele: ");
			numero = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Números impares em ordem crescente");
			for (int i = 1; i <= numero; i += 2) //Começa em 1 e aumenta de 2 em 2 pra sempre cair em números impares
			{
				Console.Write("{0}, ", i);
			}
			Console.ReadKey();
		}
	}
}
