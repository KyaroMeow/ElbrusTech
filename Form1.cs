using System.Windows.Forms;
using Microsoft.Extensions.Configuration;
using System.Data.SQLite;
using System.Collections.Generic;
using System;
using System.IO;
using System.Data;
using Microsoft.Data.Sqlite;
using LibraryForET;
using System.Data.Common;



namespace ElbrusTech
{
    public partial class Form1 : Form
    {
        Methods methods = new Methods();
        DataTable dataTable = new DataTable();
        public void UpdateData()
        {
            dataGridView1.DataSource = null;
            dataTable.Rows.Clear();

            List<People> peopleList = methods.ListPeople();
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
        }
        public Form1()
        {
            InitializeComponent();
            
        }
         SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter("SELECT * FROM emploees", "Data Source=employees.db");
        private void button1_Click(object sender, System.EventArgs e)
        {

            try
            {
                methods.GenereticEmployees(10);
                UpdateData();
                MessageBox.Show("Сотрудники сгенерированы");
            }
            catch
            {
                MessageBox.Show("ВСЕ ПЛОХО");
            }

        }

        private void Form1_Load(object sender, System.EventArgs e)
        {

            dataTable = new DataTable();
            dataTable.Columns.Add("ID", typeof(int));
            dataTable.Columns.Add("ФИО", typeof(string));
            dataTable.Columns.Add("Дата рождения", typeof(string));
            dataTable.Columns.Add("Дата принятия на работу", typeof(string));
            dataTable.Columns.Add("Отдел", typeof(string));
            dataTable.Columns.Add("Дата увольнения с работы", typeof(string));
            dataTable.Columns.Add("Должность", typeof(string));
            dataTable.Columns.Add("Оклад", typeof(string));
            UpdateData();


        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            methods.Update(dataAdapter, dataTable);
        }

		private void button3_Click(object sender, EventArgs e)
		{

		}
	}
}
