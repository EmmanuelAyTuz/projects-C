/*
 * Creado por SharpDevelop.
 * Usuario: Emmanuel Ay Tuz
 * Fecha: 29/09/2018
 * Hora: 10:51 p. m.
 */
namespace projectU2
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.RichTextBox richTextBoxProjectU2;
		private System.Windows.Forms.Button buttonLoadFile;
		private System.Windows.Forms.OpenFileDialog openFileDialogProjectU2;
		private System.Windows.Forms.Button buttonActions;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.richTextBoxProjectU2 = new System.Windows.Forms.RichTextBox();
			this.buttonLoadFile = new System.Windows.Forms.Button();
			this.openFileDialogProjectU2 = new System.Windows.Forms.OpenFileDialog();
			this.buttonActions = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// richTextBoxProjectU2
			// 
			this.richTextBoxProjectU2.Location = new System.Drawing.Point(12, 12);
			this.richTextBoxProjectU2.Name = "richTextBoxProjectU2";
			this.richTextBoxProjectU2.Size = new System.Drawing.Size(297, 385);
			this.richTextBoxProjectU2.TabIndex = 0;
			this.richTextBoxProjectU2.Text = resources.GetString("richTextBoxProjectU2.Text");
			// 
			// buttonLoadFile
			// 
			this.buttonLoadFile.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.buttonLoadFile.Location = new System.Drawing.Point(12, 403);
			this.buttonLoadFile.Name = "buttonLoadFile";
			this.buttonLoadFile.Size = new System.Drawing.Size(142, 23);
			this.buttonLoadFile.TabIndex = 5;
			this.buttonLoadFile.Text = "Cargar Archivo";
			this.buttonLoadFile.UseVisualStyleBackColor = false;
			this.buttonLoadFile.Click += new System.EventHandler(this.ButtonLoadFileClick);
			// 
			// openFileDialogProjectU2
			// 
			this.openFileDialogProjectU2.InitialDirectory = "/projectU2/";
			// 
			// buttonActions
			// 
			this.buttonActions.BackColor = System.Drawing.Color.White;
			this.buttonActions.Location = new System.Drawing.Point(172, 403);
			this.buttonActions.Name = "buttonActions";
			this.buttonActions.Size = new System.Drawing.Size(137, 23);
			this.buttonActions.TabIndex = 6;
			this.buttonActions.Text = "Buscar y Remplazar";
			this.buttonActions.UseVisualStyleBackColor = false;
			this.buttonActions.Click += new System.EventHandler(this.ButtonActionsClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.ClientSize = new System.Drawing.Size(321, 430);
			this.Controls.Add(this.buttonActions);
			this.Controls.Add(this.buttonLoadFile);
			this.Controls.Add(this.richTextBoxProjectU2);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Expresiones Regulares";
			this.ResumeLayout(false);

		}
	}
}
