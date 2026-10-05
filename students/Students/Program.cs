using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Students {
    class Program {
        SqlConnection conn = null;
        public Program() {
            conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;
                Initial Catalog=Students;Integrated Security=SSPI;";
        }
        static void Main(string[] args) {

            Console.WriteLine("\n\t\tВВЕДЕНИЕ в ADO.NET");

            Program pr = new Program();
            pr.ReadData();
        }
        public void ReadData() {
            SqlDataReader rdr = null;
            int num = -1;
            String[] str = { "Отображение всей таблицы", "Количество студентов в каждой группе",
                "Средняя оценка по группе", "Отображение всех студентов", "Отображение всех средних оценок",
                "Студенты со средней оценкой, большей, чем минимальная", 
                "Предметы с минимальными средними оценками", "Минимальная средняя оценка", 
                "Максимальная средняя оценка", "Количество студентов с минимальной средней оценкой по алгебре",
                "Количество студентов с максимальной средней оценкой по алгебре" };
            try { // открытие соединения
                conn.Open();
                Console.WriteLine("\n  Соединение с сервером установлено");
                SqlCommand cmd = new SqlCommand("SELECT * FROM Students; " +
                    "SELECT [Group], COUNT(*) FROM Students GROUP BY [Group]; " +
                    "SELECT [Group], AVG(AveGr) FROM Students GROUP BY [Group]; " +
                    "SELECT Name FROM Students; SELECT AveGr FROM Students; " +
                    "SELECT Name FROM Students WHERE AveGr > (SELECT MIN(AveGr) FROM Students); " +
                    "SELECT DISTINCT MinSub FROM Students; SELECT MIN(AveGr) FROM Students; " +
                    "SELECT MAX(AveGr) FROM Students; SELECT COUNT(*) FROM Students WHERE MinSub = N'Алгебра'; " +
                    "SELECT COUNT(*) FROM Students WHERE MaxSub = N'Алгебра'", conn);
                rdr = cmd.ExecuteReader();
                int line; // извлечение полученных строк
                do {
                    num++;
                    Console.WriteLine("\n" + "\t" + (num + 1) + ". " + str[num]);
                    line = 0;
                    while (rdr.Read()) {
                        if (line == 0) { // формирование шапки таблицы перед выводом первой строки
                            Console.Write("  ");
                            for (int i = 0; i < rdr.FieldCount; i++) // цикл по числу прочитанных полей
                                Console.Write(rdr.GetName(i).ToString() + "\t"); // вывод в консольное окно имён полей
                            Console.WriteLine();
                        }
                        line++;
                        Console.Write("  ");
                        if (num == 0) Console.WriteLine(rdr[0] + "\t" + rdr[1] + "\t" + rdr[2] + "\t"
                            + rdr[3] + "\t" + rdr[4] + "\t" + rdr[5]);
                        else if ((num == 1) || (num == 2)) Console.WriteLine(rdr.GetString(0) + "\t" + rdr[1]);
                        else Console.WriteLine(rdr[0]);
                    }
                    Console.WriteLine("  Обработано строк: " + line.ToString());
                } while (rdr.NextResult());
            }
            catch (Exception ex) {
                Console.WriteLine("  Ошибка: " + ex.Message);
            }
            finally {
                rdr?.Close(); // закрытие reader
                conn?.Close(); // закрытие соединения
            }

            Console.Write("\n  Для выхода нажмите любую клавишу ");
            Console.ReadKey();
        }
    }
}

/*Создание базы данных:
«Главное меню» -> «Вид» -> «Обозреватель объектов SQL Server» -> щелчок по узлу SQL Server -> 
щелчок по узлу (localdb)\MSSQLLocalDB -> «Базы данных» (щелчок правой кнопкой) -> 
«Добавить новую базу данных» -> изменить имя (указано ниже в [] после CREATE TABLE [dbo].) -> 
кнопка «OK» -> щелчок по узлу созданной базы -> «Таблицы» (щелчок правой кнопкой) -> «Добавить новую 
таблицу» -> вставить скрипт:
CREATE TABLE [dbo].[Students] (
    [Id]           INT           IDENTITY (1, 1) NOT NULL,
    [Name]         NVARCHAR (50) NOT NULL,
    [Group]    NVARCHAR (50) NOT NULL,
    [AveGr] FLOAT (53)    NULL,
    [MinSub]   NVARCHAR (50) NULL,
    [MaxSub]   NVARCHAR (50) NULL
);
 -> кнопка «Обновить» -> кнопка «Обновить базу данных» -> щелчок правой кнопкой по созданной таблице -> 
«Просмотр данных» -> заполнить базу (при необходимости)
ДЛЯ КОРРЕКТНОГО ОТОБРАЖЕНИЯ В КОНСОЛИ КОЛИЧЕСТВО СИМВОЛОВ В ЯЧЕЙКЕ НЕ ДОЛЖНО ПРЕВЫШАТЬ 7!!!
Пример заполнения:
| Id |  Name  | Group  | AveGr  | MinSub | MaxSub |
|  1 | Иванов |   А1   |  3,5   | Химия  | История|
|  2 | Петров |   Б2   |  4     | История| Физика |
|  3 | Сидоров|   А1   |  3     | Алгебра| Русский|
|  4 | Титов  |   В3   |  3,8   | Русский| История|
|  5 | Фролов |   Б2   |  3,7   | Алгебра| Химия  |

Примечание: Если «Вид» не содержит «Обозреватель объектов SQL Server»: в «Обозревателе 
решений» щелчок правой кнопкой по наименованию проекта -> «Добавить» -> «Создать элемент …» -> 
«База данных, основанная на службах» -> кнопка «Добавить»*/