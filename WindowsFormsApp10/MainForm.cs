using System;

public class Class1
{
	public Class1()
	{
	//класс выполняющий  соедениение с бд и запрос к ней
	public DBRequest UserReq;
	//таблица -результат  выполнения запроса
	private DataTable Requests;
	//таблица структуры таблиц из бд
	private DataTable StructTab;
	//Название таблицы  обработанной  последний раз	 в structlab_onRowChanchged;
	private string LastTabName;


	}
}
