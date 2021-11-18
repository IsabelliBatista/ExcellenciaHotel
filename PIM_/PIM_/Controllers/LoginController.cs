using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PIM_.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace PIM_.Controllers
{
    public class LoginController : Controller
    {
        SqlConnection con = new SqlConnection();
        SqlCommand com = new SqlCommand();
        SqlDataReader dr;
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        void connectionString()
        {
            con.ConnectionString = @"Password=123456;Persist Security Info=True;User ID=isabelli;Initial Catalog=HotelariaExcellencia;Data Source=DESKTOP-N2K30DI\SQLSERVER";
        }
        [HttpPost]
        public IActionResult Verificar(Login _acc)
        {
            connectionString();
            con.Open();
            com.Connection = con;
            com.CommandText = "select * from tbl_Login where email='"+ _acc.Email+"' and senha='"+ _acc.Senha+"'";
            dr = com.ExecuteReader();
            if (dr.Read())
            {
                con.Close();
                return View("MinhaPagina");
            }
            else
            {
                con.Close();
                return View("Erro");
            }
        }
    }
}
