using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Common;
using System.Data.SQLite;
using System.Data;
using System.IO;

namespace LibraryForET
{
	public class People
	{
		public int ID { get; set; }
		public string FIO { get; set; }
		public string DateOfBirth { get; set; }
		public string DateOfEmployment { get; set; }
		public string Department { get; set; }
		public string DateOfFired { get; set; }
		public string Post { get; set; }
		public string Salary { get; set; }

	}
	public class Methods
    {

        public void Update(SQLiteDataAdapter dataAdapter, DataTable dataTable)
        {
            using (var connection = new SqliteConnection("Data Source=employees.db"))
            {
                connection.Open();
                dataAdapter.UpdateCommand = new SQLiteCommandBuilder(dataAdapter).GetUpdateCommand();
                dataAdapter.Update(dataTable);
                connection.Close();
            }
        }
        public List<People> ListPeople()
        {
            List<People> people = new List<People>();
            string sqlExpression = "SELECT * FROM emploees";
            using (var connection = new SqliteConnection("Data Source=employees.db"))
            {
                connection.Open();

                SqliteCommand command = new SqliteCommand(sqlExpression, connection);
                using (SqliteDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows) // если есть данные
                    {
                        while (reader.Read())   // построчно считываем данные
                        {
                            var id = reader.GetValue(0);
                            var fio = reader.GetValue(1);
                            var dateofbirth = reader.GetValue(2);
                            var dateofemployment = reader.GetValue(3);
                            var department = reader.GetValue(4);
                            var dateoffired = reader.GetValue(5);
                            var post = reader.GetValue(6);
                            var salary = reader.GetValue(7);
                            people.Add(new People
                            {
                                ID = Convert.ToInt32(id),
                                FIO = fio.ToString(),
                                DateOfBirth = dateofbirth.ToString(),
                                DateOfEmployment = dateofemployment.ToString(),
                                Department = department.ToString(),
                                DateOfFired = dateoffired.ToString(),
                                Post = post.ToString(),
                                Salary = salary.ToString()
                            });
                        }
                    }
                }
            }
            return people;
        }
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
