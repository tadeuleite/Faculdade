using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication19
{
	class Program
	{
		static void Main(string[] args)
		{
			string[,] Nomes =  { { "disk", "20" },
								 { "barnei", "29" },
								 { "alex", "25" },
								 { "cor", "23" },
								 { "equimo", "24" } };
			string armazenar;
			string armazenarIdade;
			for (int i = 0; i < 4; i++)
			{
				for (int j = i + 1; j < 5; j++)
				{
					if (String.Compare(Nomes[j, 0], Nomes[i, 0], true) == -1) //retorna -1 se for menor, 1 se for maior e 0 se for igual
					{
						armazenar = Nomes[j, 0];
						Nomes[j, 0] = Nomes[i, 0];
						Nomes[i, 0] = armazenar;

						armazenarIdade = Nomes[j, 1];
						Nomes[j, 1] = Nomes[i, 1];
						Nomes[i, 1] = armazenarIdade;
					}
				}
			}

			for (int i = 0; i < 5; i++)
			{
				for (int j = 0; j < 2; j++)
				{
					Console.Write("{0}  ", Nomes[i, j]);
				}
				Console.WriteLine();
			}
		}
	}
}
