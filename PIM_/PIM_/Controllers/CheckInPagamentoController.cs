using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PIM_.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace PIM_.Controllers
{
    public class CheckInPagamentoController : Controller
    {
       /* private readonly ILogger<CheckInPagamentoController> _logger;*/

        /* public CheckInPagamentoController(ILogger<CheckInPagamentoController> logger)
         {
             _logger = logger;
         } */

        public IActionResult Index()
        {
            return View();
        }

       /* [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }*/
    }
}
