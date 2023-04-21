using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication.Models;
using WebApplication.ViewModels;

namespace WebApplication.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]
    public class DashboardController : Controller
    {
        private readonly PakXalcaWebContext _context;

        public DashboardController(PakXalcaWebContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            
            return View();
        }

        public async Task<IActionResult> GetMMS(DateTime? startDate, DateTime? endDate)
        {
            DateTime beginDateTime = startDate ?? DateTime.Today;
            DateTime endDateTime = endDate ?? DateTime.Today;

            PrecentVM precent = new PrecentVM();

            string connectionString = "Server=202.207.14.2;Database=PakXalcaWeb;uid=test_aqil;pwd=Read123;";
            SqlConnection connection = new SqlConnection(connectionString);

            try
            {
                connection.Open();
           
                string procedureName = "dbo.spFabrik_Irad_Gostericisi";
                string query = $"exec dbo.spFabrik_Irad_Gostericisi '{beginDateTime}','{endDateTime}'";
                SqlCommand command = new SqlCommand(query, connection);

                SqlDataReader reader = command.ExecuteReader();

                List<PrecentVM> precentList = new List<PrecentVM>();

                while (reader.Read())
                {
                    PrecentVM tempPrecent = new PrecentVM();
                    tempPrecent.Irad = reader.GetString(0);
         

                    tempPrecent.FaizEnd = (reader.GetDecimal(2) + reader.GetDecimal(4)) / 2;
                    tempPrecent.FaizEnd = Math.Round(tempPrecent.FaizEnd, 2);

                    tempPrecent.ReqemEnd = reader.GetInt32(1) + reader.GetInt32(3);

                    precentList.Add(tempPrecent);
                }

                reader.Close();
                precentList = precentList.OrderByDescending(p => p.ReqemEnd).ToList();

                return View(precentList);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return View();
        }
        //public async Task<IActionResult> GetallAdmin(int i)
        //{
        //    var data=_context.Users.Where(r=>r.IsAdmin==true).ToList();
        //    List<string> datas = new List<string>();
        //    foreach (var item in data)
        //    {
        //        datas.Add(item.Email);
        //    }
        //    Console.WriteLine(datas);
        //    return View();
        
        //}

     


    }
}
