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
        public async Task<IActionResult> Calls(DateTime? endTime, DateTime? startTime,int[] userId)
        {
            DateTime beginDateTime = startTime ?? DateTime.Now.AddDays(-10);
            DateTime endDateTime = endTime ?? DateTime.Today;
            OrderStatusReportViewModel orderStatusReportViewModel = new OrderStatusReportViewModel();

            var orders = _context.Orders.Where(c => c.CreatedDate < endDateTime && c.CreatedDate > beginDateTime).ToList();

            List<Users> users = new List<Users>();
            if (userId.Length!=0)
            {
                foreach (var item in userId)
                {
                    var user = _context.Users.FirstOrDefault(u => u.Id == item);
                    if (user != null)
                    {
                        users.Add(user);
                    }

                }
            }
            else
            {
                users = _context.Users.ToList();
            }
          
          
           

            var model = from ord in orders
                        join usr in users on ord.CreatedBy equals usr.Id
                        where ord.OrderStatus != 2 
                        group new { ord, usr } by usr.FullName into g
                        select new OrderStatusReportViewModel
                        { 
                         
                            OperatorId = g.First().usr.Id,
                            OperatorName = g.Key,
                            OrderHasBeenTaken = g.Count(x => x.ord.OrderStatus == 0),
                            TakeSelf = g.Count(x => x.ord.OrderStatus == 2),
                            WasInterested = g.Count(x => x.ord.OrderStatus == 1),
                            Reject = g.Count(x => x.ord.OrderStatus == 4),
                            ReturnBack = g.Count(x => x.ord.OrderStatus == 3),
                       
        };
            ViewBag.Users = _context.Users.ToList();
           
            model = model.OrderByDescending(O => O.OrderHasBeenTaken).ToList();
           

            return View(model);
        }



        public async Task<IActionResult> GetMMS(DateTime? startDate, DateTime? endDate)
        {
            DateTime beginDateTime = startDate ?? DateTime.Now.AddDays(-7);
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

        public async Task<IActionResult> GardenOneSale(DateTime?starDate,DateTime dateTime, int[] userId, int[] productId)
        {
            return View();
        }
        

    }
}
