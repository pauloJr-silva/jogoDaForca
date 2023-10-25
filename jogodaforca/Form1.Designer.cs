/*
 * Criado por SharpDevelop.
 * Usuário: Paulo_junior
 * Data: 21/10/2023
 * Hora: 20:30
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
namespace jogodaforca
{
	partial class Inicio
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtPalavra;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtDica;
		private System.Windows.Forms.Button btnJogar;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.txtPalavra = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtDica = new System.Windows.Forms.TextBox();
			this.btnJogar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(75, 23);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(266, 27);
			this.label1.TabIndex = 0;
			this.label1.Text = "Digite a palavra para ser advinhada!";
			// 
			// txtPalavra
			// 
			this.txtPalavra.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPalavra.Location = new System.Drawing.Point(76, 53);
			this.txtPalavra.Name = "txtPalavra";
			this.txtPalavra.Size = new System.Drawing.Size(265, 24);
			this.txtPalavra.TabIndex = 1;
			this.txtPalavra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPalavraKeyPress);
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(75, 91);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(265, 27);
			this.label2.TabIndex = 2;
			this.label2.Text = "Digite uma dica sobre a palavra:";
			// 
			// txtDica
			// 
			this.txtDica.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDica.Location = new System.Drawing.Point(75, 121);
			this.txtDica.Name = "txtDica";
			this.txtDica.Size = new System.Drawing.Size(265, 24);
			this.txtDica.TabIndex = 3;
			// 
			// btnJogar
			// 
			this.btnJogar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnJogar.Location = new System.Drawing.Point(143, 163);
			this.btnJogar.Name = "btnJogar";
			this.btnJogar.Size = new System.Drawing.Size(112, 35);
			this.btnJogar.TabIndex = 4;
			this.btnJogar.Text = "INICIAR";
			this.btnJogar.UseVisualStyleBackColor = true;
			this.btnJogar.Click += new System.EventHandler(this.BtnJogarClick);
			// 
			// Inicio
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(389, 210);
			this.Controls.Add(this.btnJogar);
			this.Controls.Add(this.txtDica);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtPalavra);
			this.Controls.Add(this.label1);
			this.MaximizeBox = false;
			this.Name = "Inicio";
			this.Text = "Digitar Palavra";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.InicioFormClosing);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
