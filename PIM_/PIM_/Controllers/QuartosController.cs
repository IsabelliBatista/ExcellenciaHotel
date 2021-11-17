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
        /*   private readonly ILogger<QuartosController> _logger;

          public QuartosController(ILogger<QuartosController> logger)
           {
               _logger = logger;
           } */
        string conexao = @"Password=123456;Persist Security Info=True;User ID=isabelli;Initial Catalog=HotelariaExcellencia;Data Source=DESKTOP-N2K30DI\SQLSERVER";

        
        
        public IActionResult Index()
        {
            /*DataTable tabelaquartos = new DataTable();
            using (SqlConnection sqlCon = new SqlConnection(conexao))
            {
                sqlCon.Open();
                List<QuartosModels> quartosModels = con.Quartos.ToList();
                List<QuartosModels> quartosVas = new List<QuartosModels>;
                foreach (QuartosModels item in quartosModels)
                {
                    QuartosModels quartosVm = new QuartosModels();
                    quartosVm.Nome = item.Nome;
                    quartosVm.Descricao = item.Descricao;
                    quartosVm.Preco = item.Preco;
                }
            }*/
            return View();
        }
      

        
   /* public IActionResult ListarQuartos(QuartosModels _acc)
    {
            
            
        }*/
    }
}
