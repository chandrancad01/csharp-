using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Csharp1.Models;
using System.Data.SqlTypes;
using Microsoft.Data.SqlClient;

namespace Csharp1.Controllers;

public class HomeController : Controller
{
    SqlConnection con=new SqlConnection();

    SqlCommand com=new SqlCommand();

    SqlDataReader? dr;
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
      public IActionResult Ticket()
    {
        return View();
    }

      public IActionResult Event()
    {
        return View();
    }
     [HttpGet]
      public IActionResult Login(){
        return View();
    }
    void ConnectionString(){
        con.ConnectionString="data source=192.168.1.240\\SQLEXPRESS ; database=cad_agri; User Id = CADBATCH01; password= CAD@123pass; TrustServerCertificate=True;";
    }
    [HttpPost]
    public IActionResult VerifyLogin(LoginModel lmodel){
         
         
         ConnectionString();
         con.Open();
         com.Connection=con;
         com.CommandText="select * from agr_login where user_name='"+lmodel.Username+"'and user_password='"+lmodel.Password+"';";
        
        dr=com.ExecuteReader();
        
        if(dr.Read()){
         con.Close();
                 return View("success");
        }
        else{
            con.Close();
                 return View("Error");
        }
    }



      public IActionResult Signin()
    {
       
  
         return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
