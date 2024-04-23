using LibraryForET;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Drawing.Drawing2D;
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

			this.FormBorderStyle = FormBorderStyle.None;
			this.DoubleBuffered = true;
		}
		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0 && e.ColumnIndex == dataGridView1.Columns["ID"].Index)
			{
				dataGridView1.CurrentCell = null;
			}
		}
		private void Form1_Paint(object sender, PaintEventArgs e)
		{
			GraphicsPath path = new GraphicsPath();
			int radius = 14;

			path.AddArc(0, 0, radius, radius, 180, 90);
			path.AddArc(this.Width - radius, 0, radius, radius, 270, 90);
			path.AddArc(this.Width - radius, this.Height - radius, radius, radius, 0, 90);
			path.AddArc(0, this.Height - radius, radius, radius, 90, 90);
			path.CloseAllFigures();

			this.Region = new Region(path);
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
		private void GenereticEmployees_click(object sender, EventArgs e)
		{
			if (guna2TextBox1.Text != "")
			{
				int count = Convert.ToInt32(guna2TextBox1.Text);
				methods.GenereticEmployees(count);
				UpdateData();
			}
		}
		private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
			{
				e.Handled = true;
			}
		}
		public void DataGridViewToDataBase(DataGridView dataGridView)
		{
			foreach (DataGridViewRow dgvRow in dataGridView.Rows)
			{
				if (!dgvRow.IsNewRow)
				{
					int id = Convert.ToInt32(dgvRow.Cells["ID"].Value);
					string fio = dgvRow.Cells["ФИО"].Value.ToString();
					string dateOfBirth = dgvRow.Cells["Дата рождения"].Value.ToString();
					string dateOfEmployment = dgvRow.Cells["Дата принятия на работу"].Value.ToString();
					string department = dgvRow.Cells["Отдел"].Value.ToString();
					string dateOfFired = dgvRow.Cells["Дата увольнения с работы"].Value.ToString();
					string post = dgvRow.Cells["Должность"].Value.ToString();
					string salary = dgvRow.Cells["Оклад"].Value.ToString();
					string query = $"INSERT INTO emploees (ID, ФИО, [Дата рождения], [Дата принятия на работу], Отдел, [Дата увольнения с работы], Должность, Оклад) " +
								   $"VALUES ('{id}', '{fio}', '{dateOfBirth}', '{dateOfEmployment}', '{department}', '{dateOfFired}', '{post}', '{salary}')";
					methods.Command(query);
				}
			}
		}
		private void Save_click(object sender, EventArgs e)
		{
			methods.Command("DELETE FROM emploees");
			DataGridViewToDataBase(dataGridView1);
			UpdateData();
		}

		private void Delete_click(object sender, EventArgs e)
		{
			int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID"].Value);
			methods.Command($"DELETE FROM emploees WHERE ID = {id}");
			UpdateData();
		}

		private void DeleteAll_click(object sender, EventArgs e)
		{
			methods.Command("DELETE FROM emploees");
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

		private void guna2HtmlToolTip2_Popup(object sender, PopupEventArgs e) { }

		private void Addcl(object sender, EventArgs e)//mouceHoveh
		{
			Guna.UI2.WinForms.Guna2HtmlToolTip guna2HtmlToolTip1 = new Guna.UI2.WinForms.Guna2HtmlToolTip();
			guna2HtmlToolTip1.SetToolTip(GenereticEmployees, "Добавить");
		}

		private void guna2Button1_MouseHover(object sender, EventArgs e)
		{
			Guna.UI2.WinForms.Guna2HtmlToolTip guna2HtmlToolTip2 = new Guna.UI2.WinForms.Guna2HtmlToolTip();
			guna2HtmlToolTip2.SetToolTip(guna2Button1, "Сохранить");
		}

		private void guna2Button2_MouseHover(object sender, EventArgs e)
		{
			Guna.UI2.WinForms.Guna2HtmlToolTip guna2Button2_MouseHover = new Guna.UI2.WinForms.Guna2HtmlToolTip();
			guna2Button2_MouseHover.SetToolTip(guna2Button2, "Удалить");
		}

		private void guna2Button3_MouseHover(object sender, EventArgs e)
		{
			Guna.UI2.WinForms.Guna2HtmlToolTip guna2Button3_MouseHover = new Guna.UI2.WinForms.Guna2HtmlToolTip();
			guna2Button3_MouseHover.SetToolTip(guna2Button3, "Очистить таблицу");
		}
	}
}
