using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Digirune.Controllers
{
    public class BookController : Controller
    {
        string Baseurl = "http://192.168.95.1:5555/";
        public async Task<IActionResult> Index()
        {
            return View();
        }
    }
}
