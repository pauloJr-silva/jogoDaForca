
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace jogodaforca
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			
			InitializeComponent();
			
			
		}
		
		/*gerar a palavra*/
		static string palavra = "Abacate";
		char [] novaPalavra = new char[palavra.Length];
		int erro = 0;
						
	
		
		/* metodo para validar caracter*/
		
		public int validarCaracter( char letra){			
			int cont = 0;
			for (int i = 0; i < palavra.Length; i++) {
				if(palavra[i] ==  letra){
					novaPalavra[i] = letra;
					cont++;
				}				
			}
			return cont;
		}
		
		
		/* Iniciar o jogo*/
		void ButtonStartClick(object sender, EventArgs e)
		{		
			
			for (int i = 0; i < novaPalavra.Length; i++) {
				novaPalavra[i] = '-';
				label1.Text = label1.Text + novaPalavra[i];
			}
			
			buttonStart.Enabled = false;
		    liberarJogo();
		}
		
		public Boolean conferirJogo(char[] novaPalavra){
			int cont = 0;
			for (int i = 0; i < novaPalavra.Length; i++) {
				if (novaPalavra[i] == '-'){
					cont++;
				}
			}
			
			return cont== 0?true : false;
		}
		
		
		/* Area dos botões*/		
		
		void ButtonAClick(object sender, EventArgs e)
		{
			if (validarCaracter('a') > 0) {
				label1.Text ="";
				for (int i = 0; i < novaPalavra.Length; i++) {
					label1.Text = label1.Text + novaPalavra[i];
				}
				buttonA.BackColor= System.Drawing.Color.Green;
				buttonA.Enabled = false;
				terminarJogo(conferirJogo(novaPalavra));
			}else{
				buttonA.BackColor= System.Drawing.Color.Red;
				erro++;
				label2.Text = "Erro: " + erro;
				buttonA.Enabled = false;
			}
				
		}	
		
		
		void ButtonBClick(object sender, EventArgs e)
		{
		
			if (validarCaracter('b') > 0) {
				label1.Text ="";
				for (int i = 0; i < novaPalavra.Length; i++) {
					label1.Text = label1.Text + novaPalavra[i];
				}
			buttonB.BackColor= System.Drawing.Color.Green;
				buttonB.Enabled = false;
				terminarJogo(conferirJogo(novaPalavra));
			}else{
				buttonB.BackColor= System.Drawing.Color.Red;
				erro++;
				label2.Text = "Erro: " + erro;
				buttonB.Enabled = false;
			}
			
		}
		void ButtonCClick(object sender, EventArgs e)
		{
			if (validarCaracter('c') > 0) {
				label1.Text ="";
				for (int i = 0; i < novaPalavra.Length; i++) {
					label1.Text = label1.Text + novaPalavra[i];
				}
				buttonC.BackColor= System.Drawing.Color.Green;
				buttonC.Enabled = false;
				terminarJogo(conferirJogo(novaPalavra));
			}else{
				buttonC.BackColor= System.Drawing.Color.Red;
				erro++;
				label2.Text = "Erro: " + erro;
				buttonC.Enabled = false;
			}
		}
		
		void ButtonDClick(object sender, EventArgs e)
		{
			if (validarCaracter('d') > 0) {
				label1.Text ="";
				for (int i = 0; i < novaPalavra.Length; i++) {
					label1.Text = label1.Text + novaPalavra[i];
				}
				buttonD.BackColor= System.Drawing.Color.Green;
				buttonD.Enabled = false;
				terminarJogo(conferirJogo(novaPalavra));
			}else{
				buttonD.BackColor= System.Drawing.Color.Red;
				erro++;
				label2.Text = "Erro: " + erro;
				buttonD.Enabled = false;
			}
		}
		
		void ButtonEClick(object sender, EventArgs e)
		{
			if (validarCaracter('e') > 0) {
				label1.Text ="";
				for (int i = 0; i < novaPalavra.Length; i++) {
					label1.Text = label1.Text + novaPalavra[i];
				}
				buttonE.BackColor= System.Drawing.Color.Green;
				buttonE.Enabled = false;
				terminarJogo(conferirJogo(novaPalavra));
			}else{
				buttonE.BackColor= System.Drawing.Color.Red;
				erro++;
				label2.Text = "Erro: " + erro;
				buttonE.Enabled = false;
			}
		}
		
		void ButtonFClick(object sender, EventArgs e)
		{
			if (validarCaracter('f') > 0) {
				label1.Text ="";
				for (int i = 0; i < novaPalavra.Length; i++) {
					label1.Text = label1.Text + novaPalavra[i];
				}
				buttonF.BackColor= System.Drawing.Color.Green;
				buttonF.Enabled = false;
				terminarJogo(conferirJogo(novaPalavra));
			}else{
				buttonF.BackColor= System.Drawing.Color.Red;
				erro++;
				label2.Text = "Erro: " + erro;
				buttonF.Enabled = false;
			}
		}
		
		void ButtonGClick(object sender, EventArgs e)
		{
			if (validarCaracter('g') > 0) {
				label1.Text ="";
				for (int i = 0; i < novaPalavra.Length; i++) {
					label1.Text = label1.Text + novaPalavra[i];
				}
				buttonG.BackColor= System.Drawing.Color.Green;
				buttonG.Enabled = false;
				terminarJogo(conferirJogo(novaPalavra));
			}else{
				buttonG.BackColor= System.Drawing.Color.Red;
				erro++;
				label2.Text = "Erro: " + erro;
				buttonG.Enabled = false;
			}
		}
		
		void ButtonHClick(object sender, EventArgs e)
		{
			if (validarCaracter('h') > 0) {
				label1.Text ="";
				for (int i = 0; i < novaPalavra.Length; i++) {
					label1.Text = label1.Text + novaPalavra[i];
				}
				buttonH.BackColor= System.Drawing.Color.Green;
				buttonH.Enabled = false;
				terminarJogo(conferirJogo(novaPalavra));
			}else{
				buttonH.BackColor= System.Drawing.Color.Red;
				erro++;
				label2.Text = "Erro: " + erro;
				buttonH.Enabled = false;
			}
		}
		
		void ButtonIClick(object sender, EventArgs e)
		{
			if (validarCaracter('i') > 0) {
				label1.Text ="";
				for (int i = 0; i < novaPalavra.Length; i++) {
					label1.Text = label1.Text + novaPalavra[i];
				}
				buttonI.BackColor= System.Drawing.Color.Green;
				buttonI.Enabled = false;
				terminarJogo(conferirJogo(novaPalavra));
			}else{
				buttonI.BackColor= System.Drawing.Color.Red;
				erro++;
				label2.Text = "Erro: " + erro;
				buttonI.Enabled = false;
			}
		}
		
		void ButtonJClick(object sender, EventArgs e)
		{
			if (validarCaracter('j') > 0) {
				label1.Text ="";
				for (int i = 0; i < novaPalavra.Length; i++) {
					label1.Text = label1.Text + novaPalavra[i];
				}
				buttonJ.BackColor= System.Drawing.Color.Green;
				buttonJ.Enabled = false;
				terminarJogo(conferirJogo(novaPalavra));
			}else{
				buttonJ.BackColor= System.Drawing.Color.Red;
				erro++;
				label2.Text = "Erro: " + erro;
				buttonJ.Enabled = false;
			}
		}
		
		void ButtonKClick(object sender, EventArgs e)
		{
			if (validarCaracter('k') > 0) {
				label1.Text ="";
				for (int i = 0; i < novaPalavra.Length; i++) {
					label1.Text = label1.Text + novaPalavra[i];
				}
				buttonK.BackColor= System.Drawing.Color.Green;
				buttonK.Enabled = false;
				terminarJogo(conferirJogo(novaPalavra));
			}else{
				buttonK.BackColor= System.Drawing.Color.Red;
				erro++;
				label2.Text = "Erro: " + erro;
				buttonK.Enabled = false;
			}
		}
		
		void ButtonLClick(object sender, EventArgs e)
		{
			if (validarCaracter('L') > 0) {
				label1.Text ="";
				for (int i = 0; i < novaPalavra.Length; i++) {
					label1.Text = label1.Text + novaPalavra[i];
				}
				buttonL.BackColor= System.Drawing.Color.Green;
				buttonL.Enabled = false;
				terminarJogo(conferirJogo(novaPalavra));
			}else{
				buttonL.BackColor= System.Drawing.Color.Red;
				erro++;
				label2.Text = "Erro: " + erro;
				buttonL.Enabled = false;
			}
		}
		
		void ButtonMClick(object sender, EventArgs e)
		{
			if (validarCaracter('m') > 0) {
				label1.Text ="";
				for (int i = 0; i < novaPalavra.Length; i++) {
					label1.Text = label1.Text + novaPalavra[i];
				}
				buttonM.BackColor= System.Drawing.Color.Green;
				buttonM.Enabled = false;
				terminarJogo(conferirJogo(novaPalavra));
			}else{
				buttonM.BackColor= System.Drawing.Color.Red;
				erro++;
				label2.Text = "Erro: " + erro;
				buttonM.Enabled = false;
			}
		}
		
		void ButtonNClick(object sender, EventArgs e)
		{
			if (validarCaracter('n') > 0) {
				label1.Text ="";
				for (int i = 0; i < novaPalavra.Length; i++) {
					label1.Text = label1.Text + novaPalavra[i];
				}
				buttonN.BackColor= System.Drawing.Color.Green;
				buttonN.Enabled = false;
				terminarJogo(conferirJogo(novaPalavra));
			}else{
				buttonN.BackColor= System.Drawing.Color.Red;
				erro++;
				label2.Text = "Erro: " + erro;
				buttonN.Enabled = false;
			}
		}
		
		void ButtonOClick(object sender, EventArgs e)
		{
			if (validarCaracter('o') > 0) {
				label1.Text ="";
				for (int i = 0; i < novaPalavra.Length; i++) {
					label1.Text = label1.Text + novaPalavra[i];
				}
				buttonO.BackColor= System.Drawing.Color.Green;
				buttonO.Enabled = false;
				terminarJogo(conferirJogo(novaPalavra));
			}else{
				buttonO.BackColor= System.Drawing.Color.Red;
				erro++;
				label2.Text = "Erro: " + erro;
				buttonO.Enabled = false;
			}
		}
		
		void ButtonPClick(object sender, EventArgs e)
		{
			if (validarCaracter('p') > 0) {
				label1.Text ="";
				for (int i = 0; i < novaPalavra.Length; i++) {
					label1.Text = label1.Text + novaPalavra[i];
				}
				buttonP.BackColor= System.Drawing.Color.Green;
				buttonP.Enabled = false;
				terminarJogo(conferirJogo(novaPalavra));
			}else{
				buttonP.BackColor= System.Drawing.Color.Red;
				erro++;
				label2.Text = "Erro: " + erro;
				buttonP.Enabled = false;
			}
		}
		
		void ButtonQClick(object sender, EventArgs e)
		{
			if (validarCaracter('q') > 0) {
				label1.Text ="";
				for (int i = 0; i < novaPalavra.Length; i++) {
					label1.Text = label1.Text + novaPalavra[i];
				}
				buttonQ.BackColor= System.Drawing.Color.Green;
				buttonQ.Enabled = false;
				terminarJogo(conferirJogo(novaPalavra));
			}else{
				buttonQ.BackColor= System.Drawing.Color.Red;
				erro++;
				label2.Text = "Erro: " + erro;
				buttonQ.Enabled = false;
			}
		}
		
		void ButtonRClick(object sender, EventArgs e)
		{
			if (validarCaracter('r') > 0) {
				label1.Text ="";
				for (int i = 0; i < novaPalavra.Length; i++) {
					label1.Text = label1.Text + novaPalavra[i];
				}
				buttonR.BackColor= System.Drawing.Color.Green;
				buttonR.Enabled = false;
				terminarJogo(conferirJogo(novaPalavra));
			}else{
				buttonR.BackColor= System.Drawing.Color.Red;
				erro++;
				label2.Text = "Erro: " + erro;
				buttonR.Enabled = false;
			}
		}
		
		void ButtonSClick(object sender, EventArgs e)
		{
			if (validarCaracter('s') > 0) {
				label1.Text ="";
				for (int i = 0; i < novaPalavra.Length; i++) {
					label1.Text = label1.Text + novaPalavra[i];
				}
				buttonS.BackColor= System.Drawing.Color.Green;
				buttonS.Enabled = false;
				terminarJogo(conferirJogo(novaPalavra));
			}else{
				buttonS.BackColor= System.Drawing.Color.Red;
				erro++;
				label2.Text = "Erro: " + erro;
				buttonS.Enabled = false;
			}
		}
		
		void ButtonTClick(object sender, EventArgs e)
		{
			if (validarCaracter('t') > 0) {
				label1.Text ="";
				for (int i = 0; i < novaPalavra.Length; i++) {
					label1.Text = label1.Text + novaPalavra[i];
				}
				buttonT.BackColor= System.Drawing.Color.Green;
				buttonT.Enabled = false;
				terminarJogo(conferirJogo(novaPalavra));
			}else{
				buttonT.BackColor= System.Drawing.Color.Red;
				erro++;
				label2.Text = "Erro: " + erro;
				buttonT.Enabled = false;
			}
		}
		
		void ButtonUClick(object sender, EventArgs e)
		{
			if (validarCaracter('u') > 0) {
				label1.Text ="";
				for (int i = 0; i < novaPalavra.Length; i++) {
					label1.Text = label1.Text + novaPalavra[i];
				}
				buttonU.BackColor= System.Drawing.Color.Green;
				buttonU.Enabled = false;
				terminarJogo(conferirJogo(novaPalavra));
			}else{
				buttonU.BackColor= System.Drawing.Color.Red;
				erro++;
				label2.Text = "Erro: " + erro;
				buttonU.Enabled = false;
			}
		}
		
		void ButtonVClick(object sender, EventArgs e)
		{
			if (validarCaracter('v') > 0) {
				label1.Text ="";
				for (int i = 0; i < novaPalavra.Length; i++) {
					label1.Text = label1.Text + novaPalavra[i];
				}
				buttonV.BackColor= System.Drawing.Color.Green;
				buttonV.Enabled = false;
				terminarJogo(conferirJogo(novaPalavra));
			}else{
				buttonV.BackColor= System.Drawing.Color.Red;
				erro++;
				label2.Text = "Erro: " + erro;
				buttonV.Enabled = false;
			}
		}
		
		void ButtonXClick(object sender, EventArgs e)
		{
			if (validarCaracter('x') > 0) {
				label1.Text ="";
				for (int i = 0; i < novaPalavra.Length; i++) {
					label1.Text = label1.Text + novaPalavra[i];
				}
				buttonX.BackColor= System.Drawing.Color.Green;
				buttonX.Enabled = false;
				terminarJogo(conferirJogo(novaPalavra));
			}else{
				buttonX.BackColor= System.Drawing.Color.Red;
				erro++;
				label2.Text = "Erro: " + erro;
				buttonX.Enabled = false;
			}
		}
		
		void ButtonYClick(object sender, EventArgs e)
		{
			if (validarCaracter('y') > 0) {
				label1.Text ="";
				for (int i = 0; i < novaPalavra.Length; i++) {
					label1.Text = label1.Text + novaPalavra[i];
				}
				buttonY.BackColor= System.Drawing.Color.Green;
				buttonY.Enabled = false;
				terminarJogo(conferirJogo(novaPalavra));
			}else{
				buttonY.BackColor= System.Drawing.Color.Red;
				erro++;
				label2.Text = "Erro: " + erro;
				buttonY.Enabled = false;
			}
		}
		
		void ButtonWClick(object sender, EventArgs e)
		{
			if (validarCaracter('w') > 0) {
				label1.Text ="";
				for (int i = 0; i < novaPalavra.Length; i++) {
					label1.Text = label1.Text + novaPalavra[i];
				}
				buttonW.BackColor= System.Drawing.Color.Green;
				buttonW.Enabled = false;
				terminarJogo(conferirJogo(novaPalavra));
			}else{
				buttonW.BackColor= System.Drawing.Color.Red;
				erro++;
				label2.Text = "Erro: " + erro;
				buttonW.Enabled = false;
			}
		}
		
		void ButtonZClick(object sender, EventArgs e)
		{
			if (validarCaracter('z') > 0) {
				label1.Text ="";
				for (int i = 0; i < novaPalavra.Length; i++) {
					label1.Text = label1.Text + novaPalavra[i];
				}
				buttonZ.BackColor= System.Drawing.Color.Green;
				buttonZ.Enabled = false;
				terminarJogo(conferirJogo(novaPalavra));
			}else{
				buttonZ.BackColor= System.Drawing.Color.Red;
				erro++;
				label2.Text = "Erro: " + erro;
				buttonZ.Enabled = false;
			}
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			if (validarCaracter('ç') > 0) {
				label1.Text ="";
				for (int i = 0; i < novaPalavra.Length; i++) {
					label1.Text = label1.Text + novaPalavra[i];
				}
				button1.BackColor= System.Drawing.Color.Green;
				button1.Enabled = false;
				terminarJogo(conferirJogo(novaPalavra));
			}else{
				button1.BackColor= System.Drawing.Color.Red;
				erro++;
				label2.Text = "Erro: " + erro;
				button1.Enabled = false;
			}
		}
		
		public void liberarJogo(){
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
		
		public void terminarJogo(Boolean boolean){
			
		if (boolean == true) {			
			
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
			
		}
	}
	
		
}
