using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace VegetablesFruits {
    class Program {
        SqlConnection conn = null;
        public Program() {
            conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;
                Initial Catalog=VegetablesFruits;Integrated Security=SSPI;";
        }
        static void Main(string[] args) {

            Console.WriteLine("\n\t\tВВЕДЕНИЕ в ADO.NET");

            Program pr = new Program();
            pr.ReadData();
        }
        public void ReadData() {
            SqlDataReader rdr = null;
            int num = -1;
            String[] str = { "Отображение всей таблицы", "Калорийность ниже средней", 
                "Калорийность выше средней", "Калорийность между min и max", 
                "Жёлтые или красные", "Количество овощей и фруктов каждого цвета", 
                "Овощи и фрукты", "Цвет", "Максимальная калорийность", "Минимальная калорийность",
                "Средняя калорийность", "Количество овощей", "Количество фруктов",
                "Количество овощей и фруктов красного цвета"};
            try { // открытие соединения
                conn.Open();
                Console.WriteLine("\n  Соединение с сервером установлено");
                SqlCommand cmd = new SqlCommand("SELECT * FROM VegetablesFruits;" +
                    "SELECT * FROM VegetablesFruits WHERE Calories < (SELECT AVG(Calories) FROM VegetablesFruits); " +
                    "SELECT * FROM VegetablesFruits WHERE Calories > (SELECT AVG(Calories) FROM VegetablesFruits); " +
                    "SELECT * FROM VegetablesFruits WHERE Calories BETWEEN (SELECT MIN(Calories) + 1 " +
                    "FROM VegetablesFruits) AND (SELECT MAX(Calories) - 1 FROM VegetablesFruits); " +
                    "SELECT * FROM VegetablesFruits WHERE Color IN (N'Жёлтый', N'Красный'); " +
                    "SELECT Color, COUNT(*) FROM VegetablesFruits GROUP BY Color; " +
                    "SELECT Name FROM VegetablesFruits; SELECT DISTINCT Color FROM VegetablesFruits; " +
                    "SELECT MAX(Calories) FROM VegetablesFruits; SELECT MIN(Calories) FROM VegetablesFruits; " +
                    "SELECT AVG (Calories) FROM VegetablesFruits; SELECT COUNT(*) FROM VegetablesFruits WHERE Type = N'Овощ'; " +
                    "SELECT COUNT(*) FROM VegetablesFruits WHERE Type = N'Фрукт'; SELECT COUNT(*) FROM VegetablesFruits WHERE Color = N'Красный'", conn);
                rdr = cmd.ExecuteReader();
                int line; // извлечение полученных строк
                do {
                    num++;
                    Console.WriteLine("\n" + "\t" + (num + 1) + ". "+ str[num]);
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
                        if (num <= 4) Console.WriteLine(rdr[0] + "\t" + rdr[1] + "\t" + rdr[2] + "\t"
                            + rdr[3] + "\t" + rdr[4]);
                        else if (num == 5) Console.WriteLine(rdr.GetString(0) + "\t" + rdr[1]);
                        else if ((num == 6) || (num == 7)) Console.WriteLine(rdr.GetString(0));
                        else Console.WriteLine(rdr[0]);
                    }
                    Console.WriteLine("  Обработано строк: " + line.ToString());
                } while (rdr.NextResult());
            }
            catch (Exception ex) {
                Console.WriteLine("  Ошибка: " + ex.Message);
            }
            finally {
                if (rdr != null) // закрытие reader
                    rdr.Close();
                if (conn != null) // закрытие соединения
                    conn.Close();
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
CREATE TABLE [dbo].[VegetablesFruits] (
    [Id]       INT           IDENTITY (1, 1) NOT NULL,
    [Name]     NVARCHAR (50) NOT NULL,
    [Type]     NVARCHAR (50) NOT NULL,
    [Color]    NVARCHAR (50) NOT NULL,
    [Calories] INT           DEFAULT ((100)) NOT NULL
);
 -> кнопка «Обновить» -> кнопка «Обновить базу данных» -> щелчок правой кнопкой по созданной таблице -> 
«Просмотр данных» -> заполнить базу (при необходимости)
ДЛЯ КОРРЕКТНОГО ОТОБРАЖЕНИЯ В КОНСОЛИ КОЛИЧЕСТВО СИМВОЛОВ В ЯЧЕЙКЕ НЕ ДОЛЖНО ПРЕВЫШАТЬ 7!!!
Пример заполнения:
| Id |  Name  |  Type  | Color  |Calories|
|  1 | Томат  | Овощ   | Красный|   25   |
|  2 | Банан  | Фрукт  | Жёлтый |   89   |
|  3 | Лимон  | Фрукт  | Жёлтый |   29   |
|  4 | Огурец | Овощ   | Зелёный|   14   |
|  5 | Слива  | Фрукт  | Синий  |   46   |
|  6 | Яблоко | Фрукт  | Красный|   52   |

Примечание: Если «Вид» не содержит «Обозреватель объектов SQL Server»: в «Обозревателе 
решений» щелчок правой кнопкой по наименованию проекта -> «Добавить» -> «Создать элемент …» -> 
«База данных, основанная на службах» -> кнопка «Добавить»*/