using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumerosPares1
{
	class Program
	{
		static void Main(string[] args)
		{
			int numero;

			Console.Write("Digite um número inteiro para saber todos os número pares positivos até ele: ");
			numero = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Números pares positivos em ordem crescente");

			for (int i = 0; i <= numero; i += 2) //Começa em 0 e aumenta de 2 em 2 pra sempre cair números pares
			{
				Console.Write("{0}, ", i);
			}
			Console.ReadKey();
		}
	}
}
