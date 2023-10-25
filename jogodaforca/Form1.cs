/*
 * Criado por SharpDevelop.
 * Usuário: Paulo_junior
 * Data: 21/10/2023
 * Hora: 20:30
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace jogodaforca
{
	/// <summary>
	/// Description of Form1.
	/// </summary>
	public partial class Inicio : Form
	{
	
		public static string palavra, dica;
		
		public Inicio()
		{
			
			InitializeComponent();
		
		}
		void BtnJogarClick(object sender, EventArgs e)
		{
			
			palavra = txtPalavra.Text;
			dica = txtDica.Text;
			
			if(txtPalavra.Text != ""){
				
				MainForm formPrincipal = new MainForm();
				formPrincipal.Show();
				this.Visible = this.Enabled =false;
				
			}else{
				MessageBox.Show("Informe uma Palavra válida!");
			}
			
			
		}
		
		
		/*evento para validar se os caracteres são letras*/
		void TxtPalavraKeyPress(object sender, KeyPressEventArgs e)
		{
			//"KeyChar" que retorna o caractere que foi pressionado pelo usuário
			//"IsLetter" que verifica se o argumento passado é de fato uma letra do alfabeto (e.KeyChar)
			//"IsControl" e "IsWhiteSpace" da estrutura 'char', retornam respectivamente se o caractere digitado é o backspace e o espaço.
			if((!char.IsLetter(e.KeyChar)) && (!char.IsControl(e.KeyChar))
			   && (!char.IsWhiteSpace(e.KeyChar))){
				e.Handled = true;
			}
		}
		
		
		/* evento qunado é fechado o formulário*/
		
		void InicioFormClosing(object sender, FormClosingEventArgs e)
		{
			Application.Exit();
	
		}
		
	}
}
