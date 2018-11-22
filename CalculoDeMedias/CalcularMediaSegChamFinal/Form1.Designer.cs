namespace CalcularMediaSegChamFinal
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.textBoxMediaFinal = new System.Windows.Forms.TextBox();
			this.labelMediaFinal = new System.Windows.Forms.Label();
			this.labelUltimasMedias = new System.Windows.Forms.Label();
			this.listBoxUltNotas = new System.Windows.Forms.ListBox();
			this.labelSituacao = new System.Windows.Forms.Label();
			this.buttonCalcular = new System.Windows.Forms.Button();
			this.textBoxFinal = new System.Windows.Forms.TextBox();
			this.textBoxSegChamada = new System.Windows.Forms.TextBox();
			this.textBoxNota2 = new System.Windows.Forms.TextBox();
			this.textBoxNota1 = new System.Windows.Forms.TextBox();
			this.labelFinal = new System.Windows.Forms.Label();
			this.labelSegChamada = new System.Windows.Forms.Label();
			this.labelNota2 = new System.Windows.Forms.Label();
			this.labelNota1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// textBoxMediaFinal
			// 
			this.textBoxMediaFinal.Enabled = false;
			this.textBoxMediaFinal.Location = new System.Drawing.Point(141, 182);
			this.textBoxMediaFinal.Name = "textBoxMediaFinal";
			this.textBoxMediaFinal.Size = new System.Drawing.Size(100, 20);
			this.textBoxMediaFinal.TabIndex = 27;
			// 
			// labelMediaFinal
			// 
			this.labelMediaFinal.AutoSize = true;
			this.labelMediaFinal.Location = new System.Drawing.Point(27, 189);
			this.labelMediaFinal.Name = "labelMediaFinal";
			this.labelMediaFinal.Size = new System.Drawing.Size(61, 13);
			this.labelMediaFinal.TabIndex = 26;
			this.labelMediaFinal.Text = "Média Final";
			// 
			// labelUltimasMedias
			// 
			this.labelUltimasMedias.AutoSize = true;
			this.labelUltimasMedias.Location = new System.Drawing.Point(306, 9);
			this.labelUltimasMedias.Name = "labelUltimasMedias";
			this.labelUltimasMedias.Size = new System.Drawing.Size(78, 13);
			this.labelUltimasMedias.TabIndex = 25;
			this.labelUltimasMedias.Text = "Últimas Médias";
			// 
			// listBoxUltNotas
			// 
			this.listBoxUltNotas.FormattingEnabled = true;
			this.listBoxUltNotas.Location = new System.Drawing.Point(309, 42);
			this.listBoxUltNotas.Name = "listBoxUltNotas";
			this.listBoxUltNotas.Size = new System.Drawing.Size(120, 95);
			this.listBoxUltNotas.TabIndex = 24;
			// 
			// labelSituacao
			// 
			this.labelSituacao.AutoSize = true;
			this.labelSituacao.Location = new System.Drawing.Point(128, 236);
			this.labelSituacao.Name = "labelSituacao";
			this.labelSituacao.Size = new System.Drawing.Size(49, 13);
			this.labelSituacao.TabIndex = 23;
			this.labelSituacao.Text = "Situação";
			// 
			// buttonCalcular
			// 
			this.buttonCalcular.Location = new System.Drawing.Point(97, 271);
			this.buttonCalcular.Name = "buttonCalcular";
			this.buttonCalcular.Size = new System.Drawing.Size(108, 24);
			this.buttonCalcular.TabIndex = 22;
			this.buttonCalcular.Text = "Calcular média";
			this.buttonCalcular.UseVisualStyleBackColor = true;
			this.buttonCalcular.Click += new System.EventHandler(this.buttonCalcular_Click);
			// 
			// textBoxFinal
			// 
			this.textBoxFinal.Location = new System.Drawing.Point(141, 144);
			this.textBoxFinal.Name = "textBoxFinal";
			this.textBoxFinal.Size = new System.Drawing.Size(100, 20);
			this.textBoxFinal.TabIndex = 21;
			// 
			// textBoxSegChamada
			// 
			this.textBoxSegChamada.Location = new System.Drawing.Point(141, 107);
			this.textBoxSegChamada.Name = "textBoxSegChamada";
			this.textBoxSegChamada.Size = new System.Drawing.Size(100, 20);
			this.textBoxSegChamada.TabIndex = 20;
			// 
			// textBoxNota2
			// 
			this.textBoxNota2.Location = new System.Drawing.Point(141, 71);
			this.textBoxNota2.Name = "textBoxNota2";
			this.textBoxNota2.Size = new System.Drawing.Size(100, 20);
			this.textBoxNota2.TabIndex = 19;
			// 
			// textBoxNota1
			// 
			this.textBoxNota1.Location = new System.Drawing.Point(141, 35);
			this.textBoxNota1.Name = "textBoxNota1";
			this.textBoxNota1.Size = new System.Drawing.Size(100, 20);
			this.textBoxNota1.TabIndex = 18;
			this.textBoxNota1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxNota1_KeyUp);
			// 
			// labelFinal
			// 
			this.labelFinal.AutoSize = true;
			this.labelFinal.Location = new System.Drawing.Point(27, 151);
			this.labelFinal.Name = "labelFinal";
			this.labelFinal.Size = new System.Drawing.Size(29, 13);
			this.labelFinal.TabIndex = 17;
			this.labelFinal.Text = "Final";
			// 
			// labelSegChamada
			// 
			this.labelSegChamada.AutoSize = true;
			this.labelSegChamada.Location = new System.Drawing.Point(27, 114);
			this.labelSegChamada.Name = "labelSegChamada";
			this.labelSegChamada.Size = new System.Drawing.Size(71, 13);
			this.labelSegChamada.TabIndex = 16;
			this.labelSegChamada.Text = "SegChamada";
			// 
			// labelNota2
			// 
			this.labelNota2.AutoSize = true;
			this.labelNota2.Location = new System.Drawing.Point(27, 78);
			this.labelNota2.Name = "labelNota2";
			this.labelNota2.Size = new System.Drawing.Size(74, 13);
			this.labelNota2.TabIndex = 15;
			this.labelNota2.Text = "Segunda nota";
			// 
			// labelNota1
			// 
			this.labelNota1.AutoSize = true;
			this.labelNota1.Location = new System.Drawing.Point(27, 42);
			this.labelNota1.Name = "labelNota1";
			this.labelNota1.Size = new System.Drawing.Size(68, 13);
			this.labelNota1.TabIndex = 14;
			this.labelNota1.Text = "Primeira nota";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(458, 318);
			this.Controls.Add(this.textBoxMediaFinal);
			this.Controls.Add(this.labelMediaFinal);
			this.Controls.Add(this.labelUltimasMedias);
			this.Controls.Add(this.listBoxUltNotas);
			this.Controls.Add(this.labelSituacao);
			this.Controls.Add(this.buttonCalcular);
			this.Controls.Add(this.textBoxFinal);
			this.Controls.Add(this.textBoxSegChamada);
			this.Controls.Add(this.textBoxNota2);
			this.Controls.Add(this.textBoxNota1);
			this.Controls.Add(this.labelFinal);
			this.Controls.Add(this.labelSegChamada);
			this.Controls.Add(this.labelNota2);
			this.Controls.Add(this.labelNota1);
			this.Name = "Form1";
			this.Text = "Calcular Média, Final e Segunda Chamada";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textBoxMediaFinal;
		private System.Windows.Forms.Label labelMediaFinal;
		private System.Windows.Forms.Label labelUltimasMedias;
		private System.Windows.Forms.ListBox listBoxUltNotas;
		private System.Windows.Forms.Label labelSituacao;
		private System.Windows.Forms.Button buttonCalcular;
		private System.Windows.Forms.TextBox textBoxFinal;
		private System.Windows.Forms.TextBox textBoxSegChamada;
		private System.Windows.Forms.TextBox textBoxNota2;
		private System.Windows.Forms.TextBox textBoxNota1;
		private System.Windows.Forms.Label labelFinal;
		private System.Windows.Forms.Label labelSegChamada;
		private System.Windows.Forms.Label labelNota2;
		private System.Windows.Forms.Label labelNota1;
	}
}

