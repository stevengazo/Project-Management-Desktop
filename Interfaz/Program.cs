using System.Runtime.CompilerServices;

namespace Interfaz
{
	internal static class Program
	{
		/// <summary>
		///  The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			try
			{

				// To customize application configuration such as set high DPI settings or default font,
				// see https://aka.ms/applicationconfiguration.
				ApplicationConfiguration.Initialize();
				Application.Run(new Login());
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error interno, la aplicación se cerrará\nError {ex.Message}","Error interno",MessageBoxButtons.OK);			
			}
			
		}
	}
}