using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatriculaComTratamento
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
				nome = Console.ReadLine().ToUpper();
				try
				{
					verificarNome = nome.Substring(0, 2);
				}
				catch
				{
					Console.WriteLine("Digite um nome válido");
					continue;
				}

				if (verificarNome == "XX") //quebra de repetição
				{
					percentualRejeicao = (contadorFalho * 100) / ContadorTotal; //Regra de 3 pra saber o percentual das matriculas não aprovadas
					Console.WriteLine("Percentual das matriculas rejeitadas: {0}\n", percentualRejeicao);
					Console.WriteLine("O programa será encerrado");
					break;
				}

				Console.Write("Digite a idade do aluno: ");
				try
				{
					idade = Convert.ToInt32(Console.ReadLine());
				}
				catch
				{
					Console.WriteLine("Digite uma idade válida");
					continue;
				}
				if (idade < 0 || idade > 130) //Se for menor que zero ou maior que 130
				{
					Console.WriteLine("Digite uma idade válida");
					continue; //Força iteração
				}
				if (idade < 15) // Se for menor que 15
				{
					Console.WriteLine("O aluno {0} não pode se matricular por ter {1} anos\n", nome, idade);
					contadorFalho++; //Aumenta o contador das matriculas que não deram certo
				}
				else if (idade >= 15 && idade < 21) //Se tiver entre 15 e 21
				{
					Console.WriteLine("O aluno {0} só poderá se matricular com o responsável e receberá o nome do responsável\n", nome, idade);
				}
				else if (idade >= 21) //Se for maior que 21
				{
					Console.WriteLine("O aluno {0} poderá se matricular\n", nome);
				}
				ContadorTotal++; //Aumenta o contador das matriculas
			}
			while (true); //Loop infinito

			Console.ReadKey();

		}
	}
}
