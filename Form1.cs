using LibraryForET;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Windows.Forms;



namespace ElbrusTech
{
	public partial class Form1 : Form
	{
		Methods methods = new Methods();
		DataTable dataTable = new DataTable();
		SQLiteDataAdapter dataAdapter;

		public Form1()
		{
			InitializeComponent();
			dataAdapter = new SQLiteDataAdapter("SELECT * FROM emploees", "Data Source=employees.db");
			dataAdapter.Fill(dataTable);
			dataGridView1.DataSource = dataTable;

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
		private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
		{
			//MessageBox.Show($"Количество измененных строк в DataTable: {dataTable.GetChanges()?.Rows.Count}"); КИРИЛ УБЕРИ
			DataGridViewCell cell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];

			if (cell.Value != cell.OwningRow.DataBoundItem)
			{

				DataRowView rowView = (DataRowView)dataGridView1.Rows[e.RowIndex].DataBoundItem;
				DataRow row = rowView.Row;

				row[cell.OwningColumn.DataPropertyName] = cell.Value;
			}
		}
		private void Save_click(object sender, EventArgs e)
		{

			dataGridView1.EndEdit();//ДЕЛОЙ
			dataTable.AcceptChanges();
			UpdateData();
		}

		private void Delete_click(object sender, EventArgs e)
		{
			int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID"].Value);
			methods.Command($"DELETE FROM emploees WHERE ID = {id}");
			UpdateData();
		}

		Point lastpoint;
		private void panel1MouseMove(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				this.Left += e.X - lastpoint.X;
				this.Top += e.Y - lastpoint.Y;
			}
		}

		private void panel1MouseDown(object sender, MouseEventArgs e)
		{
			lastpoint = new Point(e.X, e.Y);
		}

		private void DeleteAll_click(object sender, EventArgs e)
		{
			methods.Command("DELETE FROM emploees");
			UpdateData();
		}

		private void GenereticEmployees_click(object sender, EventArgs e)
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

		private void guna2Button2_Click(object sender, EventArgs e)
		{

		}

		private void guna2Button3_Click(object sender, EventArgs e)
		{

		}

		private void guna2Button1_Click(object sender, EventArgs e)
		{

		}
	}
}
