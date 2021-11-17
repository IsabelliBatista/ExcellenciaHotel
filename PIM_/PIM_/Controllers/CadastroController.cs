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
        //private readonly ILogger<CadastroController> _logger;

     /*   SqlConnection con = new SqlConnection();
        SqlCommand com = new SqlCommand();
        SqlDataReader dr;
        [HttpGet]*/
        public IActionResult Index()
        {
            return View();
        }
      /*  void connectionString()
        {
            con.ConnectionString = @"Password=123456;Persist Security Info=True;User ID=isabelli;Initial Catalog=HotelariaExcellencia;Data Source=DESKTOP-N2K30DI\SQLSERVER";
        }*/
        [HttpPost]
        public IActionResult Cadastro(FormCollection dados)
        {
         /*   using(var ctx = new Models Cadastro()){
                ctx.Cadastro.Add(new Models.Cadastro()
                {
                    Nome = dados["nome"],
                    Email = dados["email"],
                    Senha = dados["senha"]
                });
                ctx.SaveChanges();
            }*/
           
            return View();
        }

       
        /* public IActionResult Confirmar(Cadastro _acc)
{
    connectionString();
    con.Open();
    com.Connection = con;
    com.CommandText = "insert into tbl_Login(login, email, senha) values (login'"+_acc.Nome +"', email='" + _acc.Email + "', senha='" + _acc.Senha + "')";
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
    con.Close();
    return View();
}*/


    }
}
