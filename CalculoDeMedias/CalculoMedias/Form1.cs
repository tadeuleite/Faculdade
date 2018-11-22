using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculoMedias
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			textBoxSegChamada.Enabled = false;
			textBoxFinal.Enabled = false;
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void buttonCalcular_Click(object sender, EventArgs e)
		{
			double media = ValidarNotas();

			if (media >= 7)
			{
				labelSituacao.ForeColor = Color.Blue;
				labelSituacao.Text = "Aprovado";
			}
			else if (media <= 6)
			{
				labelSituacao.ForeColor = Color.Red;
				labelSituacao.Text = "Reprovado";
			}
		}

		private void textBoxNota2_KeyUp(object sender, KeyEventArgs e)
		{
			ValidarNotas();
		}

		private double Media(double nota1, double nota2)
		{
			double Mediafinal = 0;

			Mediafinal = (nota1 + nota2) / 2;

			return Mediafinal;
		}

		private void textBoxNota2_Click(object sender, EventArgs e)
		{
		}
		private double ValidarNotas()
		{
			double media;
			try
			{
				if (textBoxNota1.Text != "" && textBoxNota2.Text != "")
				{
					media = Media(Convert.ToDouble(textBoxNota1.Text), Convert.ToDouble(textBoxNota2.Text));
					textBoxMediaFinal.Text = Convert.ToString(media);
				}
				else if (textBoxNota1.Text == "" || textBoxNota2.Text == "")
				{
					textBoxSegChamada.Enabled = true;
					if (textBoxNota1.Text != "")
					{
						media = Media(Convert.ToDouble(textBoxNota1.Text), Convert.ToDouble(textBoxNota2.Text));
						textBoxMediaFinal.Text = Convert.ToString(media);
					}
					else if (textBoxNota2.Text != "")
					{
						media = Media(Convert.ToDouble(textBoxNota2.Text), Convert.ToDouble(textBoxNota2.Text));
						textBoxMediaFinal.Text = Convert.ToString(media);
					}
				}
			}
			catch
			{
				MessageBox.Show("Deu alguma bronca ae bixo");
				return 991;
			}
			return 999;
		}

	}
}
