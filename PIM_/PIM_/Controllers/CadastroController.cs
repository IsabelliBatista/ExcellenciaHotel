using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PIM_.Models;
using System;
using System.Data.SqlClient;

using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace PIM_.Controllers
{
    public class CadastroController : Controller
    {
        private readonly ILogger<CadastroController> _logger;

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
        public IActionResult Verificar(Cadastro _acc)
        {
            var error = false;
            if (_acc.Nome == null)
                error = true;
            if (_acc.Email == null)
                error = true;
            if (_acc.Senha == null)
                error = true;

            if(error == true)
            {
                con.Close();
                return View("Erro");
            }
            else
            {
                connectionString();
                con.Open();
                com.Connection = con;
                com.CommandText = "insert into tbl_Login(login, email, senha) values ('" + _acc.Nome + "', '" + _acc.Email + "', '" + _acc.Senha + "')";
                dr = com.ExecuteReader();
                con.Close();
                return View("MinhaPagina");
            }

            con.Close();
            return View();
        }


    }
}
