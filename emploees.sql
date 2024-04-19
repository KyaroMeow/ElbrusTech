BEGIN TRANSACTION;
CREATE TABLE IF NOT EXISTS "emploees" (
	"ID"	INTEGER NOT NULL UNIQUE,
	"ФИО"	TEXT NOT NULL,
	"Дата рождения"	NUMERIC NOT NULL,
	"Дата принятия на работу"	NUMERIC NOT NULL,
	"Отдел"	TEXT NOT NULL,
	"Дата увольнения с работы"	NUMERIC,
	"Должность"	TEXT NOT NULL,
	"Оклад"	REAL NOT NULL,
	PRIMARY KEY("ID")
);
COMMIT;
