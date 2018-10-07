/*
 * Creado por SharpDevelop.
 * Usuario: Emmanuel Ay Tuz
 * Fecha: 29/09/2018
 * Hora: 11:40 p. m.
 */
using System;
using System.Windows.Forms;

namespace dialogOption
{
	/// <summary>
	/// Class with program entry point.
	/// </summary>
	internal sealed class Program
	{
		/// <summary>
		/// Program entry point.
		/// </summary>
		[STAThread]
		private static void Main(string[] args)
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm());
		}
		
	}
}
