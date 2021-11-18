using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PIM_.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace PIM_.Controllers
{
    public class QuartosController : Controller
    {
        SqlConnection con = new SqlConnection();
        SqlCommand com = new SqlCommand();
        SqlDataReader dr;
       
        string conexao = @"Password=123456;Persist Security Info=True;User ID=isabelli;Initial Catalog=HotelariaExcellencia;Data Source=DESKTOP-N2K30DI\SQLSERVER";

        void connectionString()
        {
            con.ConnectionString = @"Password=123456;Persist Security Info=True;User ID=isabelli;Initial Catalog=HotelariaExcellencia;Data Source=DESKTOP-N2K30DI\SQLSERVER";
        }

        public IActionResult Index()
        {
            connectionString();
            con.Open();
            com.Connection = con;
            com.CommandText = "SELECT * FROM tbl_Quarto";
            dr = com.ExecuteReader();
            return View();
        }
    }
}
