using System.Windows.Forms;
using Microsoft.Extensions.Configuration;
using System.Data.SQLite;
using System.Collections.Generic;
using System;
using System.IO;
using System.Data;
using Microsoft.Data.Sqlite;
using LibraryForET;



namespace ElbrusTech
{
    public partial class Form1 : Form
    {

		private DataTable dataTable;
		private Methods methods;
		public Form1()
        {
            InitializeComponent();
			methods = new LibraryForET.Methods();
		}

        private void button1_Click(object sender, System.EventArgs e)
        {
            try
            {
                methods.GenereticEmployees(10);
				MessageBox.Show("все хорошо");
			}
            catch
            {
				MessageBox.Show("ВСЕ ПЛОХО");
			}

        }

		private void Form1_Load(object sender, System.EventArgs e)
		{

		}
		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			List<People> peopleList = methods.ListPeople();
			methodsBindingSource.DataSource = peopleList;
			dataGridView1.DataSource = methodsBindingSource;

			dataTable = new DataTable();
			dataTable.Columns.Add("ID", typeof(int));
			dataTable.Columns.Add("FIO", typeof(string));
			dataTable.Columns.Add("DateOfBirth", typeof(string));
			dataTable.Columns.Add("DateOfEmployment", typeof(string));
			dataTable.Columns.Add("Department", typeof(string));
			dataTable.Columns.Add("DateOfFired", typeof(string));
			dataTable.Columns.Add("Post", typeof(string));
			dataTable.Columns.Add("Salary", typeof(string));

			foreach (var person in peopleList)
			{
				dataTable.Rows.Add(
					person.ID,
					person.FIO,
					person.DateOfBirth,
					person.DateOfEmployment,
					person.Department,
					person.DateOfFired,
					person.Post,
					person.Salary
				);
			}

			dataGridView1.DataSource = dataTable;



			//List<People> employees = new List<People>(); 
			//employees = ListPeople(sqlExpression);
			//dataGridView1.DataSource = employees;
		}
	}
}
