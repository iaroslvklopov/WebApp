using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MySqlConnector;
using System;
using System.Data;
using System.Diagnostics;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult TaskFirst()
        {
            return View();
        }

        public IActionResult TaskSecond()
        {
            return View();
        }

        public IActionResult TaskThird()
        {
            return View();
        }




		[HttpPost]
		public IActionResult TaskThird(string contactName, string contactNumber, string radio, string type)
		{
			MySqlConnection conn = new MySqlConnection("server=127.0.0.1;port=3306;database=mydb;user id=root;password=1234;charset=utf8;Pooling=false;SslMode=None;");
			if (type == "Отправить")
			{
				//try
				//{
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
						cmd.Parameters.AddWithValue("@name", contactName);
						cmd.Parameters.AddWithValue("@number", contactNumber);
						cmd.Parameters.AddWithValue("@time", time);
					    cmd.Parameters.AddWithValue("@timenow", timenow);
					    cmd.Parameters.AddWithValue("@manager_id", idd);
						cmd.Parameters.AddWithValue("@status", "ожидает звонка");
						cmd.ExecuteNonQuery();

					}
					return RedirectToAction("TaskThird");
				//}
				//catch (MySqlException ex)
				//{
				//	return Content("<script language='javascript' type='text/javascript'>alert(ex.ToString());</script>");
				//}
			}
			if (type == "Узнать")
			{
				//try
				//{
					if (conn.State == ConnectionState.Closed)
					{
						conn.Open();
						MySqlCommand cmd = new MySqlCommand("select * from zayavka where number = @number", conn);
						cmd.Parameters.AddWithValue("@number", contactNumber);
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
						ViewBag.H = line;
					}
				//}
				//catch { Content("<script language='javascript' type='text/javascript'>alert(ex.ToString());</script>"); }
			}
			return View();
		}

	}

}
