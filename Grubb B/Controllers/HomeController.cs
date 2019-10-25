using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Npgsql;

namespace Grubb_B.Controllers
{
    public class HomeController : Controller
    {
        NpgsqlConnection conn = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["dbConn"].ConnectionString);
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            string stmt = "select * from freelancer;";

            try
            {

                


                using (var conn = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["dbConn"].ConnectionString))
                {
                    conn.Open();
                    using (var cmd = new NpgsqlCommand(stmt, conn))
                    {
                        cmd.Connection = conn;
                        int freelancer_id = (Int32)cmd.ExecuteScalar();
                        ViewBag.Message = "Freelancer id: " + Convert.ToString(freelancer_id);
                    }
                }

                
            }
            catch (PostgresException ex)
            {
                ViewBag.Message = ex.Message;
            }
            
            

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}