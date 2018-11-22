using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcularMediaSegChamFinal
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			textBoxMediaFinal.Enabled = false;
			textBoxFinal.Enabled = false;
			textBoxSegChamada.Enabled = false;
		}

		private void buttonCalcular_Click(object sender, EventArgs e)
		{
			if (textBoxNota1.Text != "" && textBoxNota2.Text != "")
			{
				double media = Convert.ToDouble((textBoxNota1.Text + textBoxNota2.Text)) / 2;
				textBoxMediaFinal.Text = Convert.ToString(media);
			}

			if (textBoxNota1.Text == "" || textBoxNota2.Text == "")
			{
				if (textBoxNota1.Text == "")
				{
					textBoxSegChamada.Enabled = true;

					if (textBoxSegChamada.Text == "")
					{

					}
				}
			}
		}

		private void textBoxNota1_KeyUp(object sender, KeyEventArgs e)
		{
			if (textBoxNota1.Text != "")
			{

			}
		}
	}
}
