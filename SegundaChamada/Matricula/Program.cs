using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matricula
{
	class Program
	{
		static void Main(string[] args)
		{
			string nome, verificarNome;
			int idade, contadorFalho = 1, ContadorTotal = 1, percentualRejeicao;

			do
			{
				Console.Write("Digite o nome do aluno: ");
				nome = Console.ReadLine().ToUpper(); //Pega o nome digitado e converte pra maiúsculo
				verificarNome = nome.Substring(0, 2); //Verifica se o nome digitado começa com xx

				if (verificarNome == "XX") //Se começar com xx
				{
					percentualRejeicao = (contadorFalho * 100) / ContadorTotal; //Regra de 3 pra saber o percentual das matriculas não aprovadas
					Console.WriteLine("Percentual das matriculas rejeitadas: {0}\n", percentualRejeicao);
					Console.WriteLine("O programa será encerrado");
					break; //Termina o programa
				}
				Console.Write("Digite a idade do aluno: ");
				idade = Convert.ToInt32(Console.ReadLine());

				if (idade < 15)
				{
					Console.WriteLine("O aluno {0} não pode se matricular por ter {1} anos\n", nome, idade);
					contadorFalho++;
				}
				else if (idade >= 15 && idade < 21)
				{
					Console.WriteLine("O aluno {0} só poderá se matricular com o responsável e receberá o nome do responsável\n", nome, idade);
				}
				else if (idade >= 21)
				{
					Console.WriteLine("O aluno {0} poderá se matricular\n", nome);
				}
					ContadorTotal++;
			}
			while (verificarNome != "XX");

			Console.ReadKey();
		}
	}
}
