/*
 * Creado por SharpDevelop.
 * Usuario: Emmanuel Ay Tuz
 * Fecha: 22/09/2018
 * Hora: 07:53 p. m.
 */
namespace ejercicosRegex
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.OpenFileDialog openFileDialog;
		private System.Windows.Forms.Button buttonLoad;
		private System.Windows.Forms.RichTextBox richTextBoxInput;
		private System.Windows.Forms.ComboBox comboBoxOptions;
		private System.Windows.Forms.Label labelOptions;
		
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
			this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.buttonLoad = new System.Windows.Forms.Button();
			this.richTextBoxInput = new System.Windows.Forms.RichTextBox();
			this.comboBoxOptions = new System.Windows.Forms.ComboBox();
			this.labelOptions = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// buttonLoad
			// 
			this.buttonLoad.Location = new System.Drawing.Point(13, 251);
			this.buttonLoad.Name = "buttonLoad";
			this.buttonLoad.Size = new System.Drawing.Size(310, 23);
			this.buttonLoad.TabIndex = 0;
			this.buttonLoad.Text = "Cargar";
			this.buttonLoad.UseVisualStyleBackColor = true;
			this.buttonLoad.Click += new System.EventHandler(this.ButtonLoadClick);
			// 
			// richTextBoxInput
			// 
			this.richTextBoxInput.Location = new System.Drawing.Point(13, 13);
			this.richTextBoxInput.Name = "richTextBoxInput";
			this.richTextBoxInput.Size = new System.Drawing.Size(310, 232);
			this.richTextBoxInput.TabIndex = 1;
			this.richTextBoxInput.Text = "";
			// 
			// comboBoxOptions
			// 
			this.comboBoxOptions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxOptions.FormattingEnabled = true;
			this.comboBoxOptions.Location = new System.Drawing.Point(76, 280);
			this.comboBoxOptions.Name = "comboBoxOptions";
			this.comboBoxOptions.Size = new System.Drawing.Size(247, 21);
			this.comboBoxOptions.TabIndex = 2;
			this.comboBoxOptions.SelectionChangeCommitted += new System.EventHandler(this.ComboBoxOptionsSelectionChangeCommitted);
			// 
			// labelOptions
			// 
			this.labelOptions.Location = new System.Drawing.Point(12, 283);
			this.labelOptions.Name = "labelOptions";
			this.labelOptions.Size = new System.Drawing.Size(58, 23);
			this.labelOptions.TabIndex = 3;
			this.labelOptions.Text = "Opciones";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(339, 352);
			this.Controls.Add(this.labelOptions);
			this.Controls.Add(this.comboBoxOptions);
			this.Controls.Add(this.richTextBoxInput);
			this.Controls.Add(this.buttonLoad);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ejerciciosRegex";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.ResumeLayout(false);

		}
	}
}
