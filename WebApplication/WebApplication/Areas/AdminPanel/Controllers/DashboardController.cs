using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
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

        public async Task<IActionResult> GetMMS()
        {
            DateTime beginDateTime = new DateTime(2019, 4, 18).Date; // örnek başlangıç tarihi
            DateTime endDateTime = new DateTime(2023, 4, 19).Date; // örnek bitiş tarihi

            List<string> data = new List<string>();
            string connectionString = "Server=202.207.14.2;Database=PakXalcaWeb;uid=test_aqil;pwd=Read123;MultipleActiveResultSets=true; Integrated Security=false";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string procedureName = "spFabrik_Irad_Gostericisi";
                    SqlCommand command = new SqlCommand(procedureName, connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@begin", beginDateTime);
                    command.Parameters.AddWithValue("@end", endDateTime);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            StringBuilder row = new StringBuilder();
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                row.Append(reader.GetValue(i).ToString() + "\t");
                            }
                            data.Add(row.ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return View(data);
        }





    }
}
