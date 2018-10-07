/*
 * Creado por SharpDevelop.
 * Usuario: Emmanuel Ay Tuz
 * Fecha: 29/09/2018
 * Hora: 11:04 p. m.
 */
using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace projectU2
{
	public class methodsRegex
	{
		//INSTANCIA
		public projectU2.MainForm fm;
		private Regex rgx;
		
		private string t = "";
		
		public methodsRegex()
		{
			fm = new projectU2.MainForm();
			fm.propertyButtonActions.Enabled = false;
			fm.Show();
			t = fm.propertyRichTextBox.Text;
		}
		
		//TODO BUSQUEDA DE PALABRAS SIMILARES Y EXPRESIONES MATEMATICAS
		public void regexSearch(string _expresionsSearch, RegexOptions _option)
		{
			t = fm.propertyRichTextBox.Text;
			fm.propertyRichTextBox.Text = t;
			try {
				MatchCollection mc = Regex.Matches(fm.propertyRichTextBox.Text, _expresionsSearch, _option);
				if (mc != null && mc.Count > 0) {
					foreach (Match e in mc) {
						fm.propertyRichTextBox.Select(e.Index, e.Length);
						fm.propertyRichTextBox.SelectionColor = Color.Black;
						fm.propertyRichTextBox.SelectionBackColor = Color.Yellow;
					}
				}
			} catch (Exception ex) {
				ex.ToString();
			}
		}
		
		//TODO REMPLAZAR PALABRA POR OTRA (TODAS LAS COINCIDENCIAS)
		public void regexReplaceAllWords(string _regexSearch, String _word)
		{
			rgx = new Regex(_regexSearch);
			fm.propertyRichTextBox.Text = rgx.Replace(fm.propertyRichTextBox.Text, _word).TrimStart().TrimEnd();
		}
		
		//TODO REMOVER PALABRAS SEGUIDAS REPETIDAS
		public void regexRemoveMultiWords(string _regexSearch, string _word)
		{
			rgx = new Regex(_regexSearch, RegexOptions.None);
			do {
				fm.propertyRichTextBox.Text = rgx.Replace(fm.propertyRichTextBox.Text, _word);//<--- Refresh
			} while(Regex.IsMatch(fm.propertyRichTextBox.Text, _regexSearch));
		}
		
		//EVALUADORES
		private string stringLower(Match m)
		{
			return m.Value.ToLower();
		}
		
		private string stringUpper(Match m)
		{
			return m.Value.ToUpper();
		}
		
		//FIXME CONVERTIR PALABRA EN MAYUSCULA A MINUSCULA
		public void regexUpperToLower(string _regexSearch)
		{	
			rgx = new Regex(_regexSearch);
			fm.propertyRichTextBox.Text = rgx.Replace(fm.propertyRichTextBox.Text, new MatchEvaluator(stringLower));//<--- Refresh
		}
		
		//FIXME CONVERTIR PALABRA EN MINUSCULA A MAYUSCULA
		public void regexLowerToUpper(string _regexSearch)
		{	
			rgx = new Regex(_regexSearch);
			fm.propertyRichTextBox.Text = rgx.Replace(fm.propertyRichTextBox.Text, new MatchEvaluator(stringUpper));//<--- Refresh
		}
	}
}
