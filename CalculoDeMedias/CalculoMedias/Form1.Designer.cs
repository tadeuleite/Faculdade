namespace CalculoMedias
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
			this.labelNota1 = new System.Windows.Forms.Label();
			this.labelNota2 = new System.Windows.Forms.Label();
			this.labelSegChamada = new System.Windows.Forms.Label();
			this.labelFinal = new System.Windows.Forms.Label();
			this.textBoxNota1 = new System.Windows.Forms.TextBox();
			this.textBoxNota2 = new System.Windows.Forms.TextBox();
			this.textBoxSegChamada = new System.Windows.Forms.TextBox();
			this.textBoxFinal = new System.Windows.Forms.TextBox();
			this.buttonCalcular = new System.Windows.Forms.Button();
			this.labelSituacao = new System.Windows.Forms.Label();
			this.listBoxUltNotas = new System.Windows.Forms.ListBox();
			this.labelUltimasMedias = new System.Windows.Forms.Label();
			this.labelMediaFinal = new System.Windows.Forms.Label();
			this.textBoxMediaFinal = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// labelNota1
			// 
			this.labelNota1.AutoSize = true;
			this.labelNota1.Location = new System.Drawing.Point(25, 63);
			this.labelNota1.Name = "labelNota1";
			this.labelNota1.Size = new System.Drawing.Size(68, 13);
			this.labelNota1.TabIndex = 0;
			this.labelNota1.Text = "Primeira nota";
			// 
			// labelNota2
			// 
			this.labelNota2.AutoSize = true;
			this.labelNota2.Location = new System.Drawing.Point(25, 99);
			this.labelNota2.Name = "labelNota2";
			this.labelNota2.Size = new System.Drawing.Size(74, 13);
			this.labelNota2.TabIndex = 1;
			this.labelNota2.Text = "Segunda nota";
			// 
			// labelSegChamada
			// 
			this.labelSegChamada.AutoSize = true;
			this.labelSegChamada.Location = new System.Drawing.Point(25, 135);
			this.labelSegChamada.Name = "labelSegChamada";
			this.labelSegChamada.Size = new System.Drawing.Size(71, 13);
			this.labelSegChamada.TabIndex = 2;
			this.labelSegChamada.Text = "SegChamada";
			// 
			// labelFinal
			// 
			this.labelFinal.AutoSize = true;
			this.labelFinal.Location = new System.Drawing.Point(25, 172);
			this.labelFinal.Name = "labelFinal";
			this.labelFinal.Size = new System.Drawing.Size(29, 13);
			this.labelFinal.TabIndex = 3;
			this.labelFinal.Text = "Final";
			// 
			// textBoxNota1
			// 
			this.textBoxNota1.Location = new System.Drawing.Point(139, 56);
			this.textBoxNota1.Name = "textBoxNota1";
			this.textBoxNota1.Size = new System.Drawing.Size(100, 20);
			this.textBoxNota1.TabIndex = 4;
			// 
			// textBoxNota2
			// 
			this.textBoxNota2.Location = new System.Drawing.Point(139, 92);
			this.textBoxNota2.Name = "textBoxNota2";
			this.textBoxNota2.Size = new System.Drawing.Size(100, 20);
			this.textBoxNota2.TabIndex = 5;
			this.textBoxNota2.Click += new System.EventHandler(this.textBoxNota2_Click);
			this.textBoxNota2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxNota2_KeyUp);
			// 
			// textBoxSegChamada
			// 
			this.textBoxSegChamada.Location = new System.Drawing.Point(139, 128);
			this.textBoxSegChamada.Name = "textBoxSegChamada";
			this.textBoxSegChamada.Size = new System.Drawing.Size(100, 20);
			this.textBoxSegChamada.TabIndex = 6;
			// 
			// textBoxFinal
			// 
			this.textBoxFinal.Location = new System.Drawing.Point(139, 165);
			this.textBoxFinal.Name = "textBoxFinal";
			this.textBoxFinal.Size = new System.Drawing.Size(100, 20);
			this.textBoxFinal.TabIndex = 7;
			// 
			// buttonCalcular
			// 
			this.buttonCalcular.Location = new System.Drawing.Point(95, 292);
			this.buttonCalcular.Name = "buttonCalcular";
			this.buttonCalcular.Size = new System.Drawing.Size(108, 24);
			this.buttonCalcular.TabIndex = 8;
			this.buttonCalcular.Text = "Calcular média";
			this.buttonCalcular.UseVisualStyleBackColor = true;
			this.buttonCalcular.Click += new System.EventHandler(this.buttonCalcular_Click);
			// 
			// labelSituacao
			// 
			this.labelSituacao.AutoSize = true;
			this.labelSituacao.Location = new System.Drawing.Point(126, 257);
			this.labelSituacao.Name = "labelSituacao";
			this.labelSituacao.Size = new System.Drawing.Size(49, 13);
			this.labelSituacao.TabIndex = 9;
			this.labelSituacao.Text = "Situação";
			// 
			// listBoxUltNotas
			// 
			this.listBoxUltNotas.FormattingEnabled = true;
			this.listBoxUltNotas.Location = new System.Drawing.Point(307, 63);
			this.listBoxUltNotas.Name = "listBoxUltNotas";
			this.listBoxUltNotas.Size = new System.Drawing.Size(120, 95);
			this.listBoxUltNotas.TabIndex = 10;
			// 
			// labelUltimasMedias
			// 
			this.labelUltimasMedias.AutoSize = true;
			this.labelUltimasMedias.Location = new System.Drawing.Point(304, 30);
			this.labelUltimasMedias.Name = "labelUltimasMedias";
			this.labelUltimasMedias.Size = new System.Drawing.Size(78, 13);
			this.labelUltimasMedias.TabIndex = 11;
			this.labelUltimasMedias.Text = "Últimas Médias";
			// 
			// labelMediaFinal
			// 
			this.labelMediaFinal.AutoSize = true;
			this.labelMediaFinal.Location = new System.Drawing.Point(25, 210);
			this.labelMediaFinal.Name = "labelMediaFinal";
			this.labelMediaFinal.Size = new System.Drawing.Size(61, 13);
			this.labelMediaFinal.TabIndex = 12;
			this.labelMediaFinal.Text = "Média Final";
			// 
			// textBoxMediaFinal
			// 
			this.textBoxMediaFinal.Enabled = false;
			this.textBoxMediaFinal.Location = new System.Drawing.Point(139, 203);
			this.textBoxMediaFinal.Name = "textBoxMediaFinal";
			this.textBoxMediaFinal.Size = new System.Drawing.Size(100, 20);
			this.textBoxMediaFinal.TabIndex = 13;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(443, 345);
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
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelNota1;
		private System.Windows.Forms.Label labelNota2;
		private System.Windows.Forms.Label labelSegChamada;
		private System.Windows.Forms.Label labelFinal;
		private System.Windows.Forms.TextBox textBoxNota1;
		private System.Windows.Forms.TextBox textBoxNota2;
		private System.Windows.Forms.TextBox textBoxSegChamada;
		private System.Windows.Forms.TextBox textBoxFinal;
		private System.Windows.Forms.Button buttonCalcular;
		private System.Windows.Forms.Label labelSituacao;
		private System.Windows.Forms.ListBox listBoxUltNotas;
		private System.Windows.Forms.Label labelUltimasMedias;
		private System.Windows.Forms.Label labelMediaFinal;
		private System.Windows.Forms.TextBox textBoxMediaFinal;
	}
}

