# ElbrusTech
**ElbrusTech** - информационная система для отдела кадров. Данная система собирает данные о сотрудниках предприятия “Elbrus Tech”.
## Устанока
Скачайте архив и распакуйте в удобном для вас месте.

Первый запуск осуществлять через ElbrusTech.sln.

Если не запускается пересоберите проект.

В последующие разы можно запускать через ElbrusTech.exe, который находится в bin/Debug.
## Использование
В данной программе вы можете:
- Добавлять сотрудников

  Для добавления нажмите на пустую строку в таблице и заполните все данные о соруднике, сохраните данные занесенные в таблицу.
![add](https://raw.githubusercontent.com/KyaroMeow/ElbrusTech/main/Resources/Add.png)
- Удалять сотрудников

  Для удаления сотрудника выберите строку в которой он находится и нажмите кнопку "удалить".
![delete](https://raw.githubusercontent.com/KyaroMeow/ElbrusTech/main/Resources/delete.png)
- Редактировать информацию о сотрудниках

  Для редактирования информации о сотруднике выберите ячейку которую хотите изменить, измените данные, сохраните изменения.
![editing](https://raw.githubusercontent.com/KyaroMeow/ElbrusTech/main/Resources/Readact.png)
- Очищать всю таблицу

  для того чтобы очистить всю таблицу используйте кнопку "очистить таблицу".
![clearAll](https://raw.githubusercontent.com/KyaroMeow/ElbrusTech/main/Resources/ClearAll.png)
- Генерировать сотрудников

  Для того чтобы сгенерировать сотрудников введите количество сотрудников которое хотите сгенерировать и нажмите кнопку "добавить".
![generate](https://raw.githubusercontent.com/KyaroMeow/ElbrusTech/main/Resources/generate.png)
## Генератор сотрудников
Наш генератор берет рандомные строчки из файлов с фамилиями, именами, отчествами и т.д. и делает SQL запрос в базу данных, который её заполняет.
```C#
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
    for (int i = 1; i <= quantityEmployees; i++)
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
        using (var connection = new SqliteConnection("Data Source=employees.db"))
        {
            connection.Open();
            SqliteCommand command = new SqliteCommand();
            command.Connection = connection;
            command.CommandText = $"SELECT COUNT(*) FROM emploees WHERE ФИО = @fio";
            command.Parameters.AddWithValue("@fio", fio);
            int count = Convert.ToInt32(command.ExecuteScalar());
            connection.Close();

            if (count == 0)
            {
                string commandText = $"INSERT INTO emploees ('ФИО', 'Дата рождения', 'Дата принятия на работу', 'Отдел', 'Дата увольнения с работы', 'Должность', 'Оклад') VALUES ('{fio}', '{dateofbirth}', '{dateofemployment}', '{department}', '{dateofFired}', '{post}', '{salary}')";
                Command(commandText);
            }
        }
    }
```
Для SQL запросов, которые ничего не возвращают, был создан отдельный метод `Command`, также он используется при сохранении.
```C#
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
```
## Технические детали
- **Язык программирования**: C#
- **База данных**: SQLite
## Разработали
[diemeoow](https://github.com/diemeoow) (Шакурова М.В.)

[KyaroMeow](https://github.com/KyaroMeow) (Рыньков К.А.)
