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
            com.CommandText = "SELECT ID, nome, descricao, preco, foto FROM tbl_Quarto";
            dr = com.ExecuteReader();

            List<QuartosModels> quartos = new List<QuartosModels>();

            while (dr.Read())
            {
                QuartosModels quarto = new QuartosModels();
                quarto.Id = dr.GetInt32(0);
                quarto.Nome = dr.GetString(1);
                quarto.Descricao = dr.GetString(2);
                quarto.Preco = dr.GetDecimal(3);
                quarto.Foto = (byte[])dr.GetValue(4);

                quartos.Add(quarto);
            }

            ViewData["Quartos"] = quartos;

            return View("Index");
        }
    }
}
