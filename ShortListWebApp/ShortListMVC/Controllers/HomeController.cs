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
            HomeViewModel model = new HomeViewModel();
            model.Categories = await _postContext.Category.ToListAsync();
            model.Posts = await _postContext.Post.Take(6).Include(p => p.City).ToListAsync();
            model.Cities = await _postContext.City.ToListAsync();

            model.CategoryStats = await _postContext.Post
                .Include(c => c.Category)
                .GroupBy(p => p.CategoryId)
                .Select(x => new CategoryStatsViewModel()
                {
                    Category = x.FirstOrDefault().Category,
                    CategoryPosts = x.Count()
                }).ToListAsync();
            return View(model);
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