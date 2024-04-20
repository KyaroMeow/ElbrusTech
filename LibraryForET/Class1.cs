using Microsoft.Data.Sqlite;
using System;
using System.IO;

namespace LibraryForET
{
	public class Methods
	{
		public void Command(string com)
		{
			using (var connection = new SqliteConnection("Data Source=employees.db"))
			{
				connection.Open();
				SqliteCommand command = new SqliteCommand();
				command.Connection = connection;
				command.CommandText = com;
				command.ExecuteNonQuery();
			}
		}
		public void GenereticEmployees(int quantityEmployees)
		{

			string[] wName = File.ReadAllLines("resx/GenereticEmployees/wName.txt");
			string[] mName = File.ReadAllLines("resx/GenereticEmployees/mName.txt");
			string[] surName = File.ReadAllLines("resx/GenereticEmployees/Surname.txt");
			string[] mLastName = File.ReadAllLines("resx/GenereticEmployees/mLastName.txt");
			string[] wLastName = File.ReadAllLines("resx/GenereticEmployees/wLastName.txt");
			string[] dateOfBirth = File.ReadAllLines("resx/GenereticEmployees/dateOfBirth.txt");
			string[] dateOfEmployment = File.ReadAllLines("resx/GenereticEmployees/dateOfEmployment.txt");
			string[] department1 = File.ReadAllLines("resx/GenereticEmployees/department.txt");
			string[] dateOfFired = File.ReadAllLines("resx/GenereticEmployees/dateOfFired.txt");
			string[] post1 = File.ReadAllLines("resx/GenereticEmployees/post.txt");


			Random rand = new Random();
			for (int i = 0; i <= quantityEmployees; i++)
			{
				int rname = rand.Next(0, wName.Length);
				int rsurname = rand.Next(0, surName.Length);
				int rmLastName = rand.Next(0, mLastName.Length);
				int rwLastName = rand.Next(0, wLastName.Length);
				int rdateOfBirth = rand.Next(0, dateOfBirth.Length);
				int rdateOfEmployment = rand.Next(0, dateOfEmployment.Length);
				int rdepartment = rand.Next(0, department1.Length);
				int fired = rand.Next(1, 20);
				int rdateOfFired = rand.Next(0, dateOfFired.Length);
				int rpost = rand.Next(0, post1.Length);
				string dateofFired = null;
				if (fired == 1)
				{
					dateofFired = dateOfFired[rdateOfFired];
				}
				string fio;
				int salary = rand.Next(20000, 100000);
				string post = post1[rpost];
				string dateofbirth = dateOfBirth[rdateOfBirth];
				string dateofemployment = dateOfEmployment[rdateOfEmployment];
				string department = department1[rdepartment];
				if ((i % 2) == 0)
				{
					string name = mName[rname];
					string surname = surName[rsurname];
					string lastname = mLastName[rmLastName];
					fio = $"{surname} {name} {lastname}";
				}
				else
				{
					string name = wName[rname];
					string surname = surName[rsurname] + "а";
					string lastname = wLastName[rwLastName];
					fio = $"{surname} {name} {lastname}";
				}
				string commandText = $"INSERT INTO emploees ('ФИО', 'Дата рождения', 'Дата принятия на работу', 'Отдел', 'Дата увольнения с работы', 'Должность', 'Оклад') VALUES ('{fio}', '{dateofbirth}', '{dateofemployment}', '{department}', '{dateofFired}', '{post}', '{salary}')";
				Command(commandText);

			}
		}
	}
}
