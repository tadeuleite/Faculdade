using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication24
{
	class Program
	{
		static void Main(string[] args)
		{
			/*
            dada uma matriz 12x4, representando 44 cadeiras de um onibus, onde cada coluna é o tipo da cadeira
            1 coluna JE - janela esquerda
            2 coluna CE - corredor esquerdo
            3 coluna CD - corredor direito
            4 coluna JD - janela direita
            Se a cadeira estiver ocupada, o conteúdo de posição está ocupado com a letra "X",
            se a cadeira não estiver ocupada,  conteúdo da posição fica como vazia
            Escreva um programa para receber o tipo da cadeira J- janela ou C- corredor e o lado E- esqueda ou D- direita
            e informar quantas cadeiras tem disponivel e quantas tem disponivel do tipo e lado indicado
            */
			//                        JE   CE   CD   JD
			string[,] poltronas = { { "X", "X", "X", "X" },   //1
                                    { "X", "X", " ", " " },   //2
                                    { " ", " ", "X", "X" },   //3
                                    { "X", "X", "X", " " },   //4
                                    { " ", "X", "X", "X" },   //5
                                    { "X", "X", "X", "X" },   //6
                                    { "X", " ", " ", " " },   //7
                                    { " ", " ", " ", "X" },   //8
                                    { "X", " ", " ", "X" },   //9
                                    { "X", " ", " ", " " },   //10
                                    { "X", " ", " ", " " },   //11
                                    { " ", " ", " ", " " } }; //12
			#region
			string escolhaLado, escolhaEsqDir;
			int contadorLugarVazio = 0;

			for (int i = 0; i < 12; i++)
			{
				for (int x = 0; x < 4; x++)
				{
					if (poltronas[i, x] == " ")
					{
						contadorLugarVazio++;
					}
				}
			}

			Console.WriteLine("Atualmente, {0} poltronas estão disponíveis", contadorLugarVazio);
			Console.WriteLine();

			Console.Write("Digite J caso queira se sentar na Janela ou C caso queira se sentar no corredor: ");
			escolhaLado = Console.ReadLine().ToUpper();

			if (escolhaLado != "J" && escolhaLado != "C")
			{
				Console.WriteLine("\nPor favor, digite J para Janela ou C para Corredor");
				return;
			}

			Console.Write("Digite E caso queira se sentar no lado esquerdo ou D caso queira se sentar no lado direito: ");
			escolhaEsqDir = Console.ReadLine().ToUpper();

			if (escolhaEsqDir != "E" && escolhaEsqDir != "D")
			{
				Console.WriteLine("\nPor favor, digite E para lado Esquerdo ou D para lado Direito");
				return;
			}

			Console.WriteLine();
			if (escolhaLado == "J")
			{

				Console.WriteLine("{0} poltronas na janela disponíveis ", ValidarLados(poltronas, 0) + ValidarLados(poltronas, 3));
			}

			if (escolhaLado == "C")
			{
				Console.WriteLine("{0} poltronas no corredor disponíveis ", ValidarLados(poltronas, 1) + ValidarLados(poltronas, 2));
			}
			#endregion
			if (escolhaLado == "J" && escolhaEsqDir == "E")
			{
				Console.WriteLine("{0} poltronas disponíveis na Janela Esquerda", ValidarLados(poltronas, 0));
			}

			if (escolhaLado == "J" && escolhaEsqDir == "D")
			{
				Console.WriteLine("{0} poltronas disponíveis na Janela Direita", ValidarLados(poltronas, 3));
			}

			if (escolhaLado == "C" && escolhaEsqDir == "E")
			{
				Console.WriteLine("{0} poltronas disponíveis no Corredor Esquerdo", ValidarLados(poltronas, 2));
			}

			if (escolhaLado == "C" && escolhaEsqDir == "D")
			{
				Console.WriteLine("{0} poltronas disponíveis no Corredor Direito", ValidarLados(poltronas, 1));
			}

			Console.ReadKey();
		}
		static int ValidarLados(string[,] poltronas, int lado)
		{
			int contadorEscolhido = 0;
			for (int i = 0; i < 12; i++)
			{
				if (poltronas[i, lado] == " ")
				{
					contadorEscolhido++;
				}
			}

			return contadorEscolhido;
		}
	}
}
