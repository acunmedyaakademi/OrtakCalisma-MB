using Microsoft.AspNetCore.Mvc;
using OrtakCalisma_MB.Models;
using System.Diagnostics;

namespace OrtakCalisma_MB.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
