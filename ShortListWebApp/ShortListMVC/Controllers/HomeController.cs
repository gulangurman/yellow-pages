using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ShortListMVC.Data;
using ShortListMVC.Models;
using System.Diagnostics;

namespace ShortListMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly PostContext _postContext;

        public HomeController(ILogger<HomeController> logger, PostContext postContext)
        {
            _logger = logger;
            _postContext = postContext;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _postContext.Post.ToListAsync());           
        }

        public IActionResult About()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}