using Debatron_v1._0.Models;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;
using System.Data;
using System.Diagnostics;

namespace Debatron_v1._0.Controllers
{
    
    public class HomeController : Controller
    {
        string constr = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=Debatron-v1.0;Integrated Security=True;Encrypt=False";
        
        private readonly ILogger<HomeController> _logger;

       
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult userLogin()
        {
            return View();
        }

        [HttpPost]
        public ActionResult userLogin(User u)
        {
            User obj = new User();
            DataTable db = new DataTable();
            using (SqlConnection con = new SqlConnection(constr))
            {
                con.Open();
                string query = "SELECT * FROM [user] WHERE Email = @em AND Password = @pass";
                //SqlCommand cmd = new SqlCommand(query, con); --->Used To Send Data; adapter is used to retrive data
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.SelectCommand.Parameters.AddWithValue("@em", u.Email);
                da.SelectCommand.Parameters.AddWithValue("@pass", u.Password);
                da.Fill(db);
            }
            if (db.Rows.Count == 1)
            {
                obj.Name = db.Rows[0][1].ToString();
                obj.Bio = db.Rows[0][4].ToString();
                return View(obj);
            }
            else
            {
                return RedirectToAction("Index");
            }
            
        }
    }
}
