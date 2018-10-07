/*
 * Creado por SharpDevelop.
 * Usuario: Emmanuel Ay Tuz
 * Fecha: 29/09/2018
 * Hora: 11:40 p. m.
 */
namespace dialogOption
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Panel panelBase;
		private System.Windows.Forms.Label labelSearch;
		private System.Windows.Forms.Label labelReplace;
		private System.Windows.Forms.Button buttonReplaceAll;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox textBoxSearh;
		private System.Windows.Forms.TextBox textBoxReplace;
		private System.Windows.Forms.Button buttonDelete;
		private System.Windows.Forms.Button buttonUpperLower;
		private System.Windows.Forms.RadioButton radioButtonExact;
		private System.Windows.Forms.ToolTip toolTipGeneral;
		private System.Windows.Forms.Button buttonSearch;
		private System.Windows.Forms.RadioButton radioButtonNoExact;
		private System.Windows.Forms.Button buttonLowerUpper;
		private System.Windows.Forms.GroupBox groupBoxMore;
		private System.Windows.Forms.Button buttonExpresions;
		private System.Windows.Forms.Button buttonExit;
		
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
			this.components = new System.ComponentModel.Container();
			this.panelBase = new System.Windows.Forms.Panel();
			this.buttonExit = new System.Windows.Forms.Button();
			this.groupBoxMore = new System.Windows.Forms.GroupBox();
			this.buttonExpresions = new System.Windows.Forms.Button();
			this.buttonLowerUpper = new System.Windows.Forms.Button();
			this.buttonUpperLower = new System.Windows.Forms.Button();
			this.buttonDelete = new System.Windows.Forms.Button();
			this.buttonSearch = new System.Windows.Forms.Button();
			this.textBoxReplace = new System.Windows.Forms.TextBox();
			this.labelReplace = new System.Windows.Forms.Label();
			this.buttonReplaceAll = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.radioButtonNoExact = new System.Windows.Forms.RadioButton();
			this.radioButtonExact = new System.Windows.Forms.RadioButton();
			this.textBoxSearh = new System.Windows.Forms.TextBox();
			this.labelSearch = new System.Windows.Forms.Label();
			this.toolTipGeneral = new System.Windows.Forms.ToolTip(this.components);
			this.panelBase.SuspendLayout();
			this.groupBoxMore.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panelBase
			// 
			this.panelBase.BackColor = System.Drawing.Color.White;
			this.panelBase.Controls.Add(this.buttonExit);
			this.panelBase.Controls.Add(this.groupBoxMore);
			this.panelBase.Controls.Add(this.buttonSearch);
			this.panelBase.Controls.Add(this.textBoxReplace);
			this.panelBase.Controls.Add(this.labelReplace);
			this.panelBase.Controls.Add(this.buttonReplaceAll);
			this.panelBase.Controls.Add(this.groupBox1);
			this.panelBase.Controls.Add(this.textBoxSearh);
			this.panelBase.Controls.Add(this.labelSearch);
			this.panelBase.Location = new System.Drawing.Point(12, -2);
			this.panelBase.Name = "panelBase";
			this.panelBase.Size = new System.Drawing.Size(304, 292);
			this.panelBase.TabIndex = 0;
			// 
			// buttonExit
			// 
			this.buttonExit.Location = new System.Drawing.Point(14, 236);
			this.buttonExit.Name = "buttonExit";
			this.buttonExit.Size = new System.Drawing.Size(274, 23);
			this.buttonExit.TabIndex = 1;
			this.buttonExit.Text = "Salir";
			this.buttonExit.UseVisualStyleBackColor = true;
			this.buttonExit.Click += new System.EventHandler(this.ButtonExitClick);
			// 
			// groupBoxMore
			// 
			this.groupBoxMore.Controls.Add(this.buttonExpresions);
			this.groupBoxMore.Controls.Add(this.buttonLowerUpper);
			this.groupBoxMore.Controls.Add(this.buttonUpperLower);
			this.groupBoxMore.Controls.Add(this.buttonDelete);
			this.groupBoxMore.Location = new System.Drawing.Point(15, 143);
			this.groupBoxMore.Name = "groupBoxMore";
			this.groupBoxMore.Size = new System.Drawing.Size(273, 87);
			this.groupBoxMore.TabIndex = 11;
			this.groupBoxMore.TabStop = false;
			this.groupBoxMore.Text = "Más";
			// 
			// buttonExpresions
			// 
			this.buttonExpresions.Location = new System.Drawing.Point(6, 19);
			this.buttonExpresions.Name = "buttonExpresions";
			this.buttonExpresions.Size = new System.Drawing.Size(128, 23);
			this.buttonExpresions.TabIndex = 10;
			this.buttonExpresions.Text = "Solo Expresiones";
			this.buttonExpresions.UseVisualStyleBackColor = true;
			this.buttonExpresions.Click += new System.EventHandler(this.ButtonExpresionsClick);
			// 
			// buttonLowerUpper
			// 
			this.buttonLowerUpper.Location = new System.Drawing.Point(6, 48);
			this.buttonLowerUpper.Name = "buttonLowerUpper";
			this.buttonLowerUpper.Size = new System.Drawing.Size(128, 25);
			this.buttonLowerUpper.TabIndex = 9;
			this.buttonLowerUpper.Text = "Minuscula a Mayuscula";
			this.toolTipGeneral.SetToolTip(this.buttonLowerUpper, "Cambiar palabras en minusculas\r\na MAYUSCULAS y viceversa, por ejemplo:\r\nhola --->" +
		" HOLA\r\nHOLA ---> hola");
			this.buttonLowerUpper.UseVisualStyleBackColor = true;
			this.buttonLowerUpper.Click += new System.EventHandler(this.ButtonLowerUpperClick);
			// 
			// buttonUpperLower
			// 
			this.buttonUpperLower.Location = new System.Drawing.Point(134, 48);
			this.buttonUpperLower.Name = "buttonUpperLower";
			this.buttonUpperLower.Size = new System.Drawing.Size(133, 25);
			this.buttonUpperLower.TabIndex = 6;
			this.buttonUpperLower.Text = "Mayuscula a Minuscula";
			this.toolTipGeneral.SetToolTip(this.buttonUpperLower, "Cambiar palabras en minusculas\r\na MAYUSCULAS y viceversa, por ejemplo:\r\nhola --->" +
		" HOLA\r\nHOLA ---> hola");
			this.buttonUpperLower.UseVisualStyleBackColor = true;
			this.buttonUpperLower.Click += new System.EventHandler(this.ButtonUpperLowerClick);
			// 
			// buttonDelete
			// 
			this.buttonDelete.Location = new System.Drawing.Point(134, 19);
			this.buttonDelete.Name = "buttonDelete";
			this.buttonDelete.Size = new System.Drawing.Size(133, 23);
			this.buttonDelete.TabIndex = 7;
			this.buttonDelete.Text = "Eliminar repetidas continuas";
			this.toolTipGeneral.SetToolTip(this.buttonDelete, "Clic para borrar palabras continuas.\r\nPor ejemplo: \r\nHola Hola\r\nmenos menos");
			this.buttonDelete.UseVisualStyleBackColor = true;
			this.buttonDelete.Click += new System.EventHandler(this.ButtonDeleteClick);
			// 
			// buttonSearch
			// 
			this.buttonSearch.Location = new System.Drawing.Point(14, 114);
			this.buttonSearch.Name = "buttonSearch";
			this.buttonSearch.Size = new System.Drawing.Size(135, 23);
			this.buttonSearch.TabIndex = 8;
			this.buttonSearch.Text = "Buscar";
			this.buttonSearch.UseVisualStyleBackColor = true;
			this.buttonSearch.Click += new System.EventHandler(this.ButtonSearchClick);
			// 
			// textBoxReplace
			// 
			this.textBoxReplace.Location = new System.Drawing.Point(97, 88);
			this.textBoxReplace.Name = "textBoxReplace";
			this.textBoxReplace.Size = new System.Drawing.Size(191, 20);
			this.textBoxReplace.TabIndex = 5;
			// 
			// labelReplace
			// 
			this.labelReplace.Location = new System.Drawing.Point(14, 91);
			this.labelReplace.Name = "labelReplace";
			this.labelReplace.Size = new System.Drawing.Size(77, 23);
			this.labelReplace.TabIndex = 4;
			this.labelReplace.Text = "Remplazar por";
			// 
			// buttonReplaceAll
			// 
			this.buttonReplaceAll.Location = new System.Drawing.Point(149, 114);
			this.buttonReplaceAll.Name = "buttonReplaceAll";
			this.buttonReplaceAll.Size = new System.Drawing.Size(139, 23);
			this.buttonReplaceAll.TabIndex = 3;
			this.buttonReplaceAll.Text = "Remplazar Todas";
			this.buttonReplaceAll.UseVisualStyleBackColor = true;
			this.buttonReplaceAll.Click += new System.EventHandler(this.ButtonReplaceAllClick);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.radioButtonNoExact);
			this.groupBox1.Controls.Add(this.radioButtonExact);
			this.groupBox1.Location = new System.Drawing.Point(14, 33);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(274, 49);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Coincidencia";
			// 
			// radioButtonNoExact
			// 
			this.radioButtonNoExact.Location = new System.Drawing.Point(83, 19);
			this.radioButtonNoExact.Name = "radioButtonNoExact";
			this.radioButtonNoExact.Size = new System.Drawing.Size(56, 24);
			this.radioButtonNoExact.TabIndex = 1;
			this.radioButtonNoExact.Text = "Similar";
			this.radioButtonNoExact.UseVisualStyleBackColor = true;
			this.radioButtonNoExact.Click += new System.EventHandler(this.RadioButtonNoExactClick);
			// 
			// radioButtonExact
			// 
			this.radioButtonExact.Checked = true;
			this.radioButtonExact.Location = new System.Drawing.Point(6, 19);
			this.radioButtonExact.Name = "radioButtonExact";
			this.radioButtonExact.Size = new System.Drawing.Size(58, 24);
			this.radioButtonExact.TabIndex = 0;
			this.radioButtonExact.TabStop = true;
			this.radioButtonExact.Text = "Exacta";
			this.radioButtonExact.UseVisualStyleBackColor = true;
			this.radioButtonExact.Click += new System.EventHandler(this.RadioButtonExactClick);
			// 
			// textBoxSearh
			// 
			this.textBoxSearh.Location = new System.Drawing.Point(97, 7);
			this.textBoxSearh.Name = "textBoxSearh";
			this.textBoxSearh.Size = new System.Drawing.Size(191, 20);
			this.textBoxSearh.TabIndex = 1;
			// 
			// labelSearch
			// 
			this.labelSearch.Location = new System.Drawing.Point(14, 10);
			this.labelSearch.Name = "labelSearch";
			this.labelSearch.Size = new System.Drawing.Size(77, 23);
			this.labelSearch.TabIndex = 0;
			this.labelSearch.Text = "Palabra";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(328, 288);
			this.ControlBox = false;
			this.Controls.Add(this.panelBase);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MainForm";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "Opciones";
			this.TopMost = true;
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.panelBase.ResumeLayout(false);
			this.panelBase.PerformLayout();
			this.groupBoxMore.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
	}
}
