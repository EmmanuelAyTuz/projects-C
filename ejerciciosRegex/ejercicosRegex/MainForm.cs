
/*
 * Creado por SharpDevelop.
 * Usuario: Emmanuel Ay Tuz
 * Fecha: 22/09/2018
 * Hora: 07:53 p. m.
 */
 
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ejercicosRegex
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}
		
		private void MainFormLoad(object sender, EventArgs e)
		{
			optionsRegex();
		}
		
		private void ButtonLoadClick(object sender, EventArgs e)
		{
			try {
				openFileDialog.ShowDialog();
				StreamReader file = new StreamReader(openFileDialog.FileName);
				richTextBoxInput.Text = file.ReadToEnd();
			} catch (ArgumentException ex) {
				ex.ToString();
			}
		}
		
		private void optionsRegex()
		{
			String[] regexs = { 
				"Palabras con longitud de 7 o más letras.",
				"Palabras que NO finalicen con una vocal.",
				"Palabras que inicien con \"M\" y la 2da letra no sea vocal.",
				"Palabras entre comillas.",
				"IP´s.",
				"Fechas.",
				"Telefonos.",
				"Correos electrónicos.",
				"URL´s.",
				"Códigos postales."
			};
			comboBoxOptions.Items.Clear();
			for (int i = 0; i < regexs.Length; i++) {
				comboBoxOptions.Items.Add((i + 1) + ". " + regexs[i]);
			}
		}
		
		private void regexMethod(String _regex)
		{
			try {
				MatchCollection mc = Regex.Matches(richTextBoxInput.Text, _regex, RegexOptions.Multiline);
				String textOut = "";
				foreach (var o in mc) {
					textOut += o + "\n";
				}
				MessageBox.Show(textOut, comboBoxOptions.SelectedItem.ToString());
				// disable once EmptyGeneralCatchClause
			} catch (Exception ex) {
				ex.ToString();
			}
		}
		
		private void ComboBoxOptionsSelectionChangeCommitted(object sender, EventArgs e)
		{
			string pattern = "";
			switch (comboBoxOptions.SelectedIndex) {
				case 0:
					//Palabras con longitud de 7 o más letras.
					regexMethod(@"[a-zA-Záéíóú]{7,}");
					break;
				case 1:
					//Palabras que NO finalicen con una vocal. Ejemplo COBAY [a-zA-Záéíóú]{1,}[^aeiou]\b
					regexMethod(@"[a-zA-ZAáéíóú]+([^aeiou]$)");
					break;
				case 2:
					//Palabras que inicien con \"M\" y la 2da letra no sea vocal.(M)[^aeiou][a-z]+
					pattern = @"M([b-d]|[f-h]|[j-n]|[p-t]|[v-z])+[a-z]{0,}";
					regexMethod(@pattern);
					break;
				case 3:
					//Palabras entre comillas. "\"(.+)\"";
					pattern = "\"[a-zA-Z]+\"";
					regexMethod(@pattern);
					break;
				case 4:
					//IP´s. son xxx.xxx.xxx.xxx
					regexMethod(@"\s\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}[^a-zA-Z]");
					break;
				case 5:
					//Fechas. Ejemplo: 23/09/2018
					regexMethod(@"[\s]\d{2}\/\d{2}\/\d{4}[^a-zA-Z]");
					break;
				case 6:
					//Telefonos. Ejemplo: (+xx) xxxxxxxxxx (+52) 9851105508
					regexMethod(@"(\()\+\d{2}(\))(\d|\s\d){10}");
					break;
				case 7:
					//Correos electrónicos. Ejemplo: emmanuel.aytuz@itva.edu.mx [a-zA-Z0-9(\.)]{1,}(\@)[a-zA-Z0-9(\.)]{1,}
					regexMethod(@"[a-zA-Z0-9.]+[^.]@[a-zA-Z0-9]+(\.)[a-z]+");
					break;
				case 8:
					//URL´s. Ejemplo: https://internet.com o http://internet.com.mx
					regexMethod(@"(http://|https://)[a-zA-Z0-9(\.)]{1,}[^\s](com|mx|net)");
					break;
				case 9:
					//Códigos postales.	Ejemplo: CP xxxxx cp xxxxx CP 99764 para méxico
					regexMethod(@"(CP|cp)[\s][0-9]{5}");
					break;
			}
		}
	}
}
