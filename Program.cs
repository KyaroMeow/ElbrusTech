using System;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Configuration;

namespace ElbrusTech
{
	internal static class Program
	{

		static void Main()
		{
			//string connectionString = ConfigurationManager.ConnectionStrings["SQLiteConnection"].ConnectionString;
			//using (SQLiteConnection connection = new SQLiteConnection(connectionString))
			//{
			//	connection.Open();
			//	// Ваш код для работы с базой данных
			//	connection.Close();
			//}

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Form1());
		}
	}
}
