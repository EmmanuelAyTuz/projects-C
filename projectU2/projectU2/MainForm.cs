/*
 * Creado por SharpDevelop.
 * Usuario: Emmanuel Ay Tuz
 * Fecha: 29/09/2018
 * Hora: 10:51 p. m.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace projectU2
{
	public partial class MainForm : Form
	{
		//INSTANCIAS
		private dialogOption.MainForm diag;
		
		public MainForm()
		{
			InitializeComponent();
		}
	
		//EVENTOS
		/*Abrir el File Explorer*/
		private void ButtonLoadFileClick(object sender, EventArgs e)
		{
			try {
				openFileDialogProjectU2.ShowDialog();
				StreamReader file = new StreamReader(openFileDialogProjectU2.FileName);
				richTextBoxProjectU2.Text = file.ReadToEnd();
			} catch (Exception ex) {
				ex.ToString();
			}
		}
		
		private void ButtonActionsClick(object sender, EventArgs e)
		{
			diag = new dialogOption.MainForm(this);
			diag.Show();
			this.Hide();
		}
		
		//PROPIEDAD DEL RICHTEXTBOX
		public RichTextBox propertyRichTextBox {
			get {
				return richTextBoxProjectU2;
			}
			set {
				richTextBoxProjectU2 = value;
			}
		}
		
		public Button propertyButtonActions {
			get {
				return buttonActions;
			}
			set {
				buttonActions = value;
			}
		}
	}
}
