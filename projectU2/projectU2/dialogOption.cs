/*
 * Creado por SharpDevelop.
 * Usuario: Emmanuel Ay Tuz
 * Fecha: 29/09/2018
 * Hora: 11:40 p. m.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using projectU2;

namespace dialogOption
{
	public partial class MainForm : Form
	{
		//INSTANCIAS
		public methodsRegex mr = new methodsRegex();
		
		//VARIABLES
		private Form formExtend;
		private string regex = "";
		private RegexOptions op;
		
		public MainForm(){
	
		}
		
		public MainForm(Form _formEx)
		{
			InitializeComponent();
			this.formExtend = _formEx;
			int x = this.Size.Width;
			int y = (formExtend.Size.Height - this.Size.Height) / 2;
			Point point = new Point(formExtend.Location.X + x, formExtend.Location.Y + y);
			this.Location = point;
		}
		
		//EVENTOS
		private void MainFormLoad(object sender, EventArgs e)
		{
			regex = @"\b{0}\b";//{0} es para el string format
			op = RegexOptions.None;
			buttonSearch.Enabled = radioButtonExact.Checked;
		}
		
		private void RadioButtonExactClick(object sender, EventArgs e)
		{
			regex = @"\b{0}\b";//{0} es para el string format
			op = RegexOptions.None;
			textBoxReplace.Enabled = radioButtonExact.Checked;
			buttonReplaceAll.Enabled = radioButtonExact.Checked;
			buttonSearch.Enabled = radioButtonExact.Checked;
		}

		private void RadioButtonNoExactClick(object sender, EventArgs e)
		{
			regex = @"\b[\w]*{0}[\w]*\b";//{0} es para el string format
			op = RegexOptions.IgnoreCase;
			textBoxReplace.Enabled = !radioButtonNoExact.Checked;
			buttonReplaceAll.Enabled = !radioButtonNoExact.Checked;
			buttonSearch.Enabled = radioButtonNoExact.Checked;
		}
		
		
		private void ButtonReplaceAllClick(object sender, EventArgs e)
		{
			//Remplazar coincidencias
			mr.regexReplaceAllWords(string.Format(@regex, textBoxSearh.Text), textBoxReplace.Text);
		}
		
		private void ButtonSearchClick(object sender, EventArgs e)
		{
			//Buscar similares
			mr.regexSearch(string.Format(@regex, textBoxSearh.Text), op);
		}
		
		private void ButtonExpresionsClick(object sender, EventArgs e)
		{
			//Buscar expresiones matematicas
			mr.regexSearch(@"(\+|\-)*(\d*\w*)([\+\-\*\/\^\=]\d*\w*)+", RegexOptions.None);
		}
		
		private void ButtonDeleteClick(object sender, EventArgs e)
		{
			//Quitar palabras repetidas seguidas
			mr.regexRemoveMultiWords(@"([a-zA-Z]+[a-zA-Z])\s+\1", "$1");
		}
		
		private void ButtonUpperLowerClick(object sender, EventArgs e)
		{
			//MAYUSCULA --> minuscula
			mr.regexUpperToLower(@"\b[A-Z]+\b");
		}
		
		private void ButtonLowerUpperClick(object sender, EventArgs e)
		{
			//minuscula --> MAYUSCULA
			mr.regexLowerToUpper(@"\b[a-z]+\b");
		}
		
		private void ButtonExitClick(object sender, EventArgs e)
		{
			formExtend.Close();
		}
	}
}
