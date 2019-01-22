using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SensorDataWeb.Models;
using Microsoft.AspNetCore.Http;
using System.IO;
using System.Data.SqlClient;

namespace SensorDataWeb.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            SqlServerConnHelp sqlConnManager = new SqlServerConnHelp();
            SqlConnection sqlConnection = sqlConnManager.GetConnection(@"DELL-SVR\SQLEXPRESS", "SensorData", "jdw", "asdf");
            //SqlConnection sqlConnection = sqlConnManager.GetConnection(@"LAPTOP-AD2UF7HI\SQLEXPRESS", "SensorData", "jdw", "asdf");
            string query = "select a.UniqueID, a.Created_On, (Select Max(SensorValue) From SensorDataDetail b where b.UniqueID = a.UniqueID AND b.SensorNode = 'Temperature'), (Select Max(SensorValue) From SensorDataDetail b where b.UniqueID = a.UniqueID AND b.SensorNode = 'Moisture'), (Select Max(SensorValue) From SensorDataDetail b where b.UniqueID = a.UniqueID AND (b.SensorNode = 'Sunlight' or b.SensorNode = 'Luminosity')) from SensorData a";
            SqlCommand cmd = new SqlCommand(query, sqlConnection);
            var reader = cmd.ExecuteReader();
            List<SensorDataFields> db = new List<SensorDataFields>();

            while(reader.Read())
            {
                SensorDataFields row = new SensorDataFields();
                row.UniqueId = reader.GetString(0).Trim();
                row.date = reader.GetDateTime(1);
                row.Temperature = reader.GetString(2).Trim();
                row.Moisture = reader.GetString(3).Trim();
                row.Luminosity = reader.GetString(4).Trim();
                db.Add(row);
            }

            reader.Close();
            cmd.Dispose();
            sqlConnection.Close();
            sqlConnection.Dispose();

            ViewData["SensorDataFields"] = db;
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

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
    }
}
