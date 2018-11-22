using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
	class Program
	{
		static void Main(string[] args)
		{
			/*
            Dado uma matriz (7x3) contendo:
              1ª Coluna: dia da semana. Ex: 1 (domingo); 2(segunda) etc
              2ª Coluna: temperatura mínima do dia
              3ª Coluna: temperatura máxima do dia
            Escreva um programa para receber um dia, devendo ser informado:
              A temperatura média do dia informado
              A maior temperatura da semana
              Se a menor temperatura foi em dia útil ou final de semana (final de semana = dia 1 e dia 7)
            */
			//                        dia da semana / temperatura mínima / temperatura máxima
			int[,] diaTempMinMax =    { { 1,                10,                30 },
										{ 2,                30,                40 },
										{ 3,                40,                50 },
										{ 4,                50,                60 },
										{ 5,                60,                70 },
										{ 6,                70,                80 },
										{ 7,                80,                90 } };

			int dia;
			int menorTemperatura;
			menorTemperatura = DiaMenorTemperatura(diaTempMinMax);
			try
			{
				Console.WriteLine("Digite o dia");
				dia = Convert.ToInt32(Console.ReadLine());
			}
			catch
			{
				Console.WriteLine("Digite um dia válido");
				return;
			}

			Console.WriteLine("A temperatura média do dia escolhido foi: {0}", TemperaturaMediaDoDia(dia, diaTempMinMax));

			Console.WriteLine("A maior temperatura da semana foi: {0}", MaiorTemperaturaSemana(diaTempMinMax));

			if (menorTemperatura == 1 || menorTemperatura == 7) //domingo ou sábado
			{
				Console.WriteLine("A menor temperatura da semana foi registrada num final de semana");
			}
			else
			{
				Console.WriteLine("A menor temperatura da semana foi registrada num dia útil");
			}
		}
		static double TemperaturaMediaDoDia(int dia, int[,] matriz)
		{
			double temperaturaMedia = 0;
			const int qtdTemperaturas = 2;
			for (int i = 1; i <= qtdTemperaturas; i++)
			{
				temperaturaMedia = temperaturaMedia + matriz[dia - 1, i];
			}

			return temperaturaMedia = temperaturaMedia / 2;
		}

		static int MaiorTemperaturaSemana(int[,] matriz)
		{
			const int colunaTemperaturaMaxima = 2;
			const int diasSemana = 7;
			int maiorTemperatura = 0;

			for (int i = 0; i < diasSemana; i++)
			{
				if (matriz[i, colunaTemperaturaMaxima] >= maiorTemperatura)
				{
					maiorTemperatura = matriz[i, colunaTemperaturaMaxima];
				}
			}
			return maiorTemperatura;
		}

		static int DiaMenorTemperatura(int[,] matriz)
		{
			const int colunaTemperaturaMinima = 1;
			const int diasSemana = 7;

			int menorTemperatura = matriz[0, colunaTemperaturaMinima];
			int diaMenorTemperatura = 0;

			for (int i = 0; i < diasSemana; i++)
			{
				if (matriz[i, colunaTemperaturaMinima] < menorTemperatura)
				{
					menorTemperatura = matriz[i, colunaTemperaturaMinima];
				}
			}

			for (int x = 0; x < diasSemana; x++)
			{
				if (menorTemperatura == matriz[x, colunaTemperaturaMinima])
				{
					diaMenorTemperatura = x;
					break;
				}
			}

			return diaMenorTemperatura + 1;
		}
	}
}
