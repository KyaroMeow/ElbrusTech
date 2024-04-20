using System;
using System.Windows.Forms;
using System.Data.SQLite;
using Microsoft.Extensions.Configuration;

namespace ElbrusTech
{
	internal static class Program
	{

		static void Main()
		{
			
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Form1());
		}
	}
}
