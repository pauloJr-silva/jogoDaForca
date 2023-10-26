
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Resources;
using System.Windows.Forms;

namespace jogodaforca
{
	public partial class MainForm : Form
	{
		static string palavra = Inicio.palavra.ToUpper();
		static String dica = Inicio.dica;
		Label[] labelf;
		
		
		public MainForm()
		{
			palavra = Inicio.palavra.ToUpper();
			dica = Inicio.dica;
			criarLabels();
			InitializeComponent();	
			
		}
		
		/*gerar a palavra*/
	
		int erro = 0;
		
		/* Iniciar o jogo*/
		void ButtonStartClick(object sender, EventArgs e)
		{	
			lblDica.Text = "Dica: " + dica;
			btnReiniciar.Enabled = true;
			btnStart.Enabled = false;
			liberarJogo();
			pictureBox1.Load("fc0.jpg");
			// palavra = Inicio.palavra.ToUpper();
		}
		
		
		/* criar os labels para receber a palavra - a quantidade de label vai ser criado a partir da qtd das palavras*/
		public void criarLabels()
		{			
			int tamanho = palavra.Length;
			int x = 180;
			int y = 172;
			labelf = new Label[tamanho];
			
			for (int i = 0; i < palavra.Length; i++) {
				labelf[i] = new Label();
				labelf[i].Size = new Size(27, 26);
				labelf[i].TextAlign = ContentAlignment.MiddleCenter;
				labelf[i].Font = new Font("Arial", 14f, FontStyle.Bold);
				labelf[i].Text = palavra[i] == ' ' ? "" : "_";
				labelf[i].Location = i == 0 ? new Point(x, y) : new Point((labelf[i - 1].Location.X + 22), y);
				this.Controls.Add(labelf[i]);
			}
		}
		
		
		/*Carregar Imagen*/
		public void carregarImagem(int erro)
		{			
			if (erro < 6) {
				pictureBox1.Load("fc" + erro + ".jpg");
			} else {
				pictureBox1.Load("fc6.jpg");
				MessageBox.Show("Você perdeu! a palavra era: " + palavra);
				terminarJogo();				
			}				
		}
		
		
		/* metodo para validar caracter*/
		public int validarCaracter(char letra)
		{			
			int cont = 0;
			
			for (int i = 0; i < palavra.Length; i++) {
				if (palavra[i] == letra) {
					labelf[i].Text = letra.ToString();
					cont++;
				}	
			}
			
			return cont;
		}
		
		/* conferir se o jogo acabou - se a arraya consta "-" quer dizer que a palavra esta completa.*/
		public void conferirJogo()
		{
			int cont = 0;
			
			foreach (Label lb in labelf) {
				if (lb.Text.Contains("_")) {
					cont++;
				}
			}
			
			if (cont == 0) {
				terminarJogo();
				MessageBox.Show("VOCÊ GANHOU!!!!!!");
			}
		}
		
		public void reiniciarJogo()
		{
			Inicio ini = new Inicio();
			ini.Show();
			this.Enabled = this.Visible = false;
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			reiniciarJogo();
		}
		
		/* Area dos botões*/
		
		void ButtonAClick(object sender, EventArgs e)
		{
			if (validarCaracter('A') > 0) {										
				buttonA.BackColor = System.Drawing.Color.Green;
				buttonA.Enabled = false;
				conferirJogo();
			} else {
				buttonA.BackColor = System.Drawing.Color.Red;
				erro++;
				label2.Text = "Erro: " + erro;
				buttonA.Enabled = false;
				carregarImagem(erro);
			}
				
		}
		
		
		void ButtonBClick(object sender, EventArgs e)
		{
		
			if (validarCaracter('B') > 0) {
				
				buttonB.BackColor = System.Drawing.Color.Green;
				buttonB.Enabled = false;
				conferirJogo();
			} else {
				buttonB.BackColor = System.Drawing.Color.Red;
				erro++;
				label2.Text = "Erro: " + erro;
				buttonB.Enabled = false;
				carregarImagem(erro);
			}
			
		}
		void ButtonCClick(object sender, EventArgs e)
		{
			if (validarCaracter('C') > 0) {
				
				buttonC.BackColor = System.Drawing.Color.Green;
				buttonC.Enabled = false;
				conferirJogo();
			} else {
				buttonC.BackColor = System.Drawing.Color.Red;
				erro++;
				label2.Text = "Erro: " + erro;
				buttonC.Enabled = false;
				carregarImagem(erro);
			}
		}
		
		void ButtonDClick(object sender, EventArgs e)
		{
			if (validarCaracter('D') > 0) {
				
				buttonD.BackColor = System.Drawing.Color.Green;
				buttonD.Enabled = false;
				conferirJogo();
			} else {
				buttonD.BackColor = System.Drawing.Color.Red;
				erro++;
				label2.Text = "Erro: " + erro;
				buttonD.Enabled = false;
				carregarImagem(erro);
			}
		}
		
		void ButtonEClick(object sender, EventArgs e)
		{
			if (validarCaracter('E') > 0) {
				
				buttonE.BackColor = System.Drawing.Color.Green;
				buttonE.Enabled = false;
				conferirJogo();
			} else {
				buttonE.BackColor = System.Drawing.Color.Red;
				erro++;
				label2.Text = "Erro: " + erro;
				buttonE.Enabled = false;
				carregarImagem(erro);
			}
		}
		
		void ButtonFClick(object sender, EventArgs e)
		{
			if (validarCaracter('F') > 0) {
				
				buttonF.BackColor = System.Drawing.Color.Green;
				buttonF.Enabled = false;
				conferirJogo();
			} else {
				buttonF.BackColor = System.Drawing.Color.Red;
				erro++;
				label2.Text = "Erro: " + erro;
				buttonF.Enabled = false;
				carregarImagem(erro);
			}
		}
		
		void ButtonGClick(object sender, EventArgs e)
		{
			if (validarCaracter('G') > 0) {
				
				buttonG.BackColor = System.Drawing.Color.Green;
				buttonG.Enabled = false;
				conferirJogo();
			} else {
				buttonG.BackColor = System.Drawing.Color.Red;
				erro++;
				label2.Text = "Erro: " + erro;
				buttonG.Enabled = false;
				carregarImagem(erro);
			}
		}
		
		void ButtonHClick(object sender, EventArgs e)
		{
			if (validarCaracter('H') > 0) {
				
				buttonH.BackColor = System.Drawing.Color.Green;
				buttonH.Enabled = false;
				conferirJogo();
			} else {
				buttonH.BackColor = System.Drawing.Color.Red;
				erro++;
				label2.Text = "Erro: " + erro;
				buttonH.Enabled = false;
				carregarImagem(erro);
			}
		}
		
		void ButtonIClick(object sender, EventArgs e)
		{
			if (validarCaracter('I') > 0) {
				
				buttonI.BackColor = System.Drawing.Color.Green;
				buttonI.Enabled = false;
				conferirJogo();
			} else {
				buttonI.BackColor = System.Drawing.Color.Red;
				erro++;
				label2.Text = "Erro: " + erro;
				buttonI.Enabled = false;
				carregarImagem(erro);
			}
		}
		
		void ButtonJClick(object sender, EventArgs e)
		{
			if (validarCaracter('J') > 0) {
				
				buttonJ.BackColor = System.Drawing.Color.Green;
				buttonJ.Enabled = false;
				conferirJogo();
			} else {
				buttonJ.BackColor = System.Drawing.Color.Red;
				erro++;
				label2.Text = "Erro: " + erro;
				buttonJ.Enabled = false;
				carregarImagem(erro);
			}
		}
		
		void ButtonKClick(object sender, EventArgs e)
		{
			if (validarCaracter('J') > 0) {
				
				buttonK.BackColor = System.Drawing.Color.Green;
				buttonK.Enabled = false;
				conferirJogo();
			} else {
				buttonK.BackColor = System.Drawing.Color.Red;
				erro++;
				label2.Text = "Erro: " + erro;
				buttonK.Enabled = false;
				carregarImagem(erro);
			}
		}
		
		void ButtonLClick(object sender, EventArgs e)
		{
			if (validarCaracter('L') > 0) {
				
				buttonL.BackColor = System.Drawing.Color.Green;
				buttonL.Enabled = false;
				conferirJogo();
			} else {
				buttonL.BackColor = System.Drawing.Color.Red;
				erro++;
				label2.Text = "Erro: " + erro;
				buttonL.Enabled = false;
				carregarImagem(erro);
			}
		}
		
		void ButtonMClick(object sender, EventArgs e)
		{
			if (validarCaracter('M') > 0) {
				
				buttonM.BackColor = System.Drawing.Color.Green;
				buttonM.Enabled = false;
				conferirJogo();
			} else {
				buttonM.BackColor = System.Drawing.Color.Red;
				erro++;
				label2.Text = "Erro: " + erro;
				buttonM.Enabled = false;
				carregarImagem(erro);
			}
		}
		
		void ButtonNClick(object sender, EventArgs e)
		{
			if (validarCaracter('N') > 0) {
				
				buttonN.BackColor = System.Drawing.Color.Green;
				buttonN.Enabled = false;
				conferirJogo();
			} else {
				buttonN.BackColor = System.Drawing.Color.Red;
				erro++;
				label2.Text = "Erro: " + erro;
				buttonN.Enabled = false;
				carregarImagem(erro);
			}
		}
		
		void ButtonOClick(object sender, EventArgs e)
		{
			if (validarCaracter('O') > 0) {
				
				buttonO.BackColor = System.Drawing.Color.Green;
				buttonO.Enabled = false;
				conferirJogo();
			} else {
				buttonO.BackColor = System.Drawing.Color.Red;
				erro++;
				label2.Text = "Erro: " + erro;
				buttonO.Enabled = false;
				carregarImagem(erro);
			}
		}
		
		void ButtonPClick(object sender, EventArgs e)
		{
			if (validarCaracter('P') > 0) {
				
				buttonP.BackColor = System.Drawing.Color.Green;
				buttonP.Enabled = false;
				conferirJogo();
			} else {
				buttonP.BackColor = System.Drawing.Color.Red;
				erro++;
				label2.Text = "Erro: " + erro;
				buttonP.Enabled = false;
				carregarImagem(erro);
			}
		}
		
		void ButtonQClick(object sender, EventArgs e)
		{
			if (validarCaracter('Q') > 0) {
				
				buttonQ.BackColor = System.Drawing.Color.Green;
				buttonQ.Enabled = false;
				conferirJogo();
			} else {
				buttonQ.BackColor = System.Drawing.Color.Red;
				erro++;
				label2.Text = "Erro: " + erro;
				buttonQ.Enabled = false;
				carregarImagem(erro);
			}
		}
		
		void ButtonRClick(object sender, EventArgs e)
		{
			if (validarCaracter('R') > 0) {
				
				buttonR.BackColor = System.Drawing.Color.Green;
				buttonR.Enabled = false;
				conferirJogo();
			} else {
				buttonR.BackColor = System.Drawing.Color.Red;
				erro++;
				label2.Text = "Erro: " + erro;
				buttonR.Enabled = false;
				carregarImagem(erro);
			}
		}
		
		void ButtonSClick(object sender, EventArgs e)
		{
			if (validarCaracter('S') > 0) {
				
				buttonS.BackColor = System.Drawing.Color.Green;
				buttonS.Enabled = false;
				conferirJogo();
			} else {
				buttonS.BackColor = System.Drawing.Color.Red;
				erro++;
				label2.Text = "Erro: " + erro;
				buttonS.Enabled = false;
				carregarImagem(erro);
			}
		}
		
		void ButtonTClick(object sender, EventArgs e)
		{
			if (validarCaracter('T') > 0) {
				
				buttonT.BackColor = System.Drawing.Color.Green;
				buttonT.Enabled = false;
				conferirJogo();
			} else {
				buttonT.BackColor = System.Drawing.Color.Red;
				erro++;
				label2.Text = "Erro: " + erro;
				buttonT.Enabled = false;
				carregarImagem(erro);
			}
		}
		
		void ButtonUClick(object sender, EventArgs e)
		{
			if (validarCaracter('U') > 0) {
				
				buttonU.BackColor = System.Drawing.Color.Green;
				buttonU.Enabled = false;
				conferirJogo();
			} else {
				buttonU.BackColor = System.Drawing.Color.Red;
				erro++;
				label2.Text = "Erro: " + erro;
				buttonU.Enabled = false;
				carregarImagem(erro);
			}
		}
		
		void ButtonVClick(object sender, EventArgs e)
		{
			if (validarCaracter('V') > 0) {
				
				buttonV.BackColor = System.Drawing.Color.Green;
				buttonV.Enabled = false;
				conferirJogo();
			} else {
				buttonV.BackColor = System.Drawing.Color.Red;
				erro++;
				label2.Text = "Erro: " + erro;
				buttonV.Enabled = false;
				carregarImagem(erro);
			}
		}
		
		void ButtonXClick(object sender, EventArgs e)
		{
			if (validarCaracter('X') > 0) {
				
				buttonX.BackColor = System.Drawing.Color.Green;
				buttonX.Enabled = false;
				conferirJogo();
			} else {
				buttonX.BackColor = System.Drawing.Color.Red;
				erro++;
				label2.Text = "Erro: " + erro;
				buttonX.Enabled = false;
				carregarImagem(erro);
			}
		}
		
		void ButtonYClick(object sender, EventArgs e)
		{
			if (validarCaracter('Y') > 0) {
				
				buttonY.BackColor = System.Drawing.Color.Green;
				buttonY.Enabled = false;
				conferirJogo();
			} else {
				buttonY.BackColor = System.Drawing.Color.Red;
				erro++;
				label2.Text = "Erro: " + erro;
				buttonY.Enabled = false;
				carregarImagem(erro);
			}
		}
		
		void ButtonWClick(object sender, EventArgs e)
		{
			if (validarCaracter('W') > 0) {
				
				buttonW.BackColor = System.Drawing.Color.Green;
				buttonW.Enabled = false;
				conferirJogo();
			} else {
				buttonW.BackColor = System.Drawing.Color.Red;
				erro++;
				label2.Text = "Erro: " + erro;
				buttonW.Enabled = false;
				carregarImagem(erro);
			}
		}
		
		void ButtonZClick(object sender, EventArgs e)
		{
			if (validarCaracter('Z') > 0) {
				
				buttonZ.BackColor = System.Drawing.Color.Green;
				buttonZ.Enabled = false;
				conferirJogo();
			} else {
				buttonZ.BackColor = System.Drawing.Color.Red;
				erro++;
				label2.Text = "Erro: " + erro;
				buttonZ.Enabled = false;
				carregarImagem(erro);
			}
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			if (validarCaracter('Ç') > 0) {
				
				button1.BackColor = System.Drawing.Color.Green;
				button1.Enabled = false;
				conferirJogo();
			} else {
				button1.BackColor = System.Drawing.Color.Red;
				erro++;
				label2.Text = "Erro: " + erro;
				button1.Enabled = false;
				carregarImagem(erro);
			}
		}
		
		public void liberarJogo()
		{
			buttonA.Enabled = true;
			buttonB.Enabled = true;
			buttonC.Enabled = true;
			buttonD.Enabled = true;
			buttonE.Enabled = true;
			buttonF.Enabled = true;
			buttonG.Enabled = true;
			buttonH.Enabled = true;
			buttonI.Enabled = true;
			buttonJ.Enabled = true;
			buttonK.Enabled = true;
			buttonL.Enabled = true;
			buttonM.Enabled = true;
			buttonN.Enabled = true;
			buttonO.Enabled = true;
			buttonP.Enabled = true;
			buttonQ.Enabled = true;
			buttonR.Enabled = true;
			buttonS.Enabled = true;
			buttonT.Enabled = true;
			buttonU.Enabled = true;
			buttonV.Enabled = true;
			buttonX.Enabled = true;
			buttonW.Enabled = true;
			buttonY.Enabled = true;
			buttonZ.Enabled = true;
			button1.Enabled = true;
			
			
		}
		
		public void terminarJogo()
		{
					
			buttonA.Enabled = false;
			buttonB.Enabled = false;
			buttonC.Enabled = false;
			buttonD.Enabled = false;
			buttonE.Enabled = false;
			buttonF.Enabled = false;
			buttonG.Enabled = false;
			buttonH.Enabled = false;
			buttonI.Enabled = false;
			buttonJ.Enabled = false;
			buttonK.Enabled = false;
			buttonL.Enabled = false;
			buttonM.Enabled = false;
			buttonN.Enabled = false;
			buttonO.Enabled = false;
			buttonP.Enabled = false;
			buttonQ.Enabled = false;
			buttonR.Enabled = false;
			buttonS.Enabled = false;
			buttonT.Enabled = false;
			buttonU.Enabled = false;
			buttonV.Enabled = false;
			buttonX.Enabled = false;
			buttonW.Enabled = false;
			buttonY.Enabled = false;
			buttonZ.Enabled = false;
			button1.Enabled = false;
			
			
		}
		void MainFormFormClosing(object sender, FormClosingEventArgs e)
		{
			Application.Exit();
		}
		
	}
	
		
}
