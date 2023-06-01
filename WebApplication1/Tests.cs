using MySqlConnector;
using System.Data;
using System;

namespace WebApplication1
{
	public class Tests
	{
		public bool datab()
		{
			MySqlConnection conn = new MySqlConnection("server=127.0.0.1;port=3306;database=mydb;user id=root;password=1234;charset=utf8;Pooling=false;SslMode=None;");
			if (conn.State == ConnectionState.Closed)
			{
				conn.Open(); 
				return true; 
			}
			else { return false; }

		}

		public bool man()
		{
			MySqlConnection conn = new MySqlConnection("server=127.0.0.1;port=3306;database=mydb;user id=root;password=1234;charset=utf8;Pooling=false;SslMode=None;");
			try
			{
				if (conn.State == ConnectionState.Closed)
				{
					conn.Open();
					MySqlCommand cmd1 = new MySqlCommand("select max(manager_id) from manager", conn);
					int log = Convert.ToInt32(cmd1.ExecuteScalar());
					Random r = new Random();
					int idd = r.Next(1, log + 1);
					return true;
				}
				else { return false; }
			}
			catch (MySqlException ex)
			{
				return false; 
			}
		}


		public bool addzayavka(string Name, string Number, string radio)
		{
			MySqlConnection conn = new MySqlConnection("server=127.0.0.1;port=3306;database=mydb;user id=root;password=1234;charset=utf8;Pooling=false;SslMode=None;");
			try
			{
				if (conn.State == ConnectionState.Closed)
				{
					conn.Open();
					MySqlCommand cmd1 = new MySqlCommand("select max(manager_id) from manager", conn);
					int log = Convert.ToInt32(cmd1.ExecuteScalar());
					Random r = new Random();
					int idd = r.Next(1, log + 1);
					string time = "";
					if (radio == "1") { time = "10:00-13:00"; }
					if (radio == "2") { time = "13:00-16:00"; }
					if (radio == "3") { time = "16:00-19:00"; }
					string timenow = Convert.ToString(DateTime.Now);
					MySqlCommand cmd = new MySqlCommand("insert into zayavka (name, number, time, timenow, manager_id, status) values(@name, @number, @time, @timenow, @manager_id, @status);", conn);
					cmd.Parameters.AddWithValue("@name", Name);
					cmd.Parameters.AddWithValue("@number", Number);
					cmd.Parameters.AddWithValue("@time", time);
					cmd.Parameters.AddWithValue("@timenow", timenow);
					cmd.Parameters.AddWithValue("@manager_id", idd);
					cmd.Parameters.AddWithValue("@status", "ожидание звонка");
					cmd.ExecuteNonQuery();
					return true;

				}
				else { return false; }
			}
			catch (MySqlException ex)
			{
				return false;
			}
		}

		public bool check(string Number)
		{
			MySqlConnection conn = new MySqlConnection("server=127.0.0.1;port=3306;database=mydb;user id=root;password=1234;charset=utf8;Pooling=false;SslMode=None;");
			try
			{
				if (conn.State == ConnectionState.Closed)
				{
					conn.Open();
					MySqlCommand cmd = new MySqlCommand("select * from zayavka where number = @number", conn);
					cmd.Parameters.AddWithValue("@number", Number);
					MySqlDataReader reader = cmd.ExecuteReader();
					string line = "";
					while (reader.Read())
					{
						line += Convert.ToString(reader["timenow"]);
						line += ": ";
						line += Convert.ToString(reader["status"]);
						line += "\n";
					}
					reader.Close();
					return true;
				}
				else { return false; }
			}
			catch { return false; }

		}

		public bool all(string Name, string Number, string radio)
		{
			MySqlConnection conn = new MySqlConnection("server=127.0.0.1;port=3306;database=mydb;user id=root;password=1234;charset=utf8;Pooling=false;SslMode=None;");
			try
			{
				if (conn.State == ConnectionState.Closed)
				{
					conn.Open();
					MySqlCommand cmd1 = new MySqlCommand("select max(manager_id) from manager", conn);
					int log = Convert.ToInt32(cmd1.ExecuteScalar());
					Random r = new Random();
					int idd = r.Next(1, log + 1);
					string time = "";
					if (radio == "1") { time = "10:00-13:00"; }
					if (radio == "2") { time = "13:00-16:00"; }
					if (radio == "3") { time = "16:00-19:00"; }
					string timenow = Convert.ToString(DateTime.Now);
					MySqlCommand cmd = new MySqlCommand("insert into zayavka (name, number, time, timenow, manager_id, status) values(@name, @number, @time, @timenow, @manager_id, @status);", conn);
					cmd.Parameters.AddWithValue("@name", Name);
					cmd.Parameters.AddWithValue("@number", Number);
					cmd.Parameters.AddWithValue("@time", time);
					cmd.Parameters.AddWithValue("@timenow", timenow);
					cmd.Parameters.AddWithValue("@manager_id", idd);
					cmd.Parameters.AddWithValue("@status", "ожидание звонка");
					cmd.ExecuteNonQuery();

					cmd = new MySqlCommand("select * from zayavka where number = @number", conn);
					cmd.Parameters.AddWithValue("@number", Number);
					MySqlDataReader reader = cmd.ExecuteReader();
					string line = "";
					while (reader.Read())
					{
						line += Convert.ToString(reader["timenow"]);
						line += ": ";
						line += Convert.ToString(reader["status"]);
						line += "\n";
					}
					reader.Close();

					return true;

				}
				else { return false; }
			}
			catch (MySqlException ex)
			{
				return false;
			}
		}
	}
}
