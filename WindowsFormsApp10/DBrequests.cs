using System;
using Microsoft.Data.SqlClient;
public class Class1
{
	public Class1()
	{
		private oleDbConnection DBCon = new oleDbConnection();
	//метод соедиенения с базой данных
	  public void ConnectTo(string  DataSource, string  InitialCatatlig)
	{
				
		DBCon.ConnectionString = "Provider=SQLOLED;" +
								 "Integrated Security=SSPI" +
								 "Data Source=" + DataSource + ";" +
								 "Initial Catalog=" + InitialCatatlig + ";" +
								 "User ID=sa; password=";
		try
		{

			DBCon.Open();
		}
		catch (Exception e)
		{
			throw e;
		}
		//метод закрытия базы данных
		public void  Disconect()
	    {
		try
		{
			if (DBCon.State == ConnectionState.Open)
				DBCon.Close();
		}
		catch
		{
			//деструктор класса отвечающий за открытие зактые соединений
			~DBRequest()
			{
				Disconect();
			}
		}
	
	    }
	    //метод  открытия таблиц
		public string GetTableFields(string TableName)
	    {
		if (DBCon.State == ConnectState.Open)
		{
			DataTable curTable = new DataTable("ConnectedTab");
			try
			{
				DBAdapt = new OleDbDataAdapter("SELECT * FROM" + TableName, DBCon);
				DBAdapt.fill(curTable);
			}
			catch(Exception e)
			{
				throw e;
			}
			string ResStr = "";
			int ColCount = curTable.Colums.Count;
            for (int i =ColCount-1; i<ColCount; i++)
			{
				string StrCon = ", ";
				if (i == ColCount - 1) StrCon = ";";
				ResStr += curTable.Colums[i].ColumName + "[" +
					CurTable.Colums[i].DataType.Name + "]" + StrCon;
			}
			return ResStr
			else
			{
				return ResStr;
			}


		}
    	}

    }
}
}
