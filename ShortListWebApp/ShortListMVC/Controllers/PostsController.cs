#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ShortListMVC.Data;
using ShortListMVC.Models;

namespace ShortListMVC.Controllers
{
    public class PostsController : Controller
    {
        private readonly PostContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public PostsController(PostContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // GET: Posts
        public async Task<IActionResult> Index()
        {
            return View(await _context.Post.Include(c => c.Category).ToListAsync());
        }

        public async Task<IActionResult> Listing(string keyword, int category, string city, string tag, int page = 1)
        {
            ListingViewModel model = new ListingViewModel();
            model.CategoryStats = await _context.Post
                .Include(c => c.Category)
                .Where(p => p.CategoryId != null)
                .GroupBy(p => p.CategoryId)
                .Select(x => new CategoryStatsViewModel()
                {
                    Category = x.FirstOrDefault().Category,
                    CategoryPosts = x.Count()
                }).ToListAsync();

            model.CityStats = await _context.Post
                .Include(c => c.City)
                .Where(p => p.CityId != null)
                .GroupBy(p => p.CityId)
                .Select(x => new CityStatsViewModel()
                {
                    City = x.FirstOrDefault().City,
                    CityPosts = x.Count()
                }).ToListAsync();

            var posts = _context.Post
                .Include(p => p.City)
                .Include(p => p.Category)
                .AsQueryable();
            if (category > 0)
            {
                posts = posts.Where(p => p.CategoryId == category);
            }
            if (!string.IsNullOrWhiteSpace(city))
            {
                posts = posts.Where(p => p.CityId.Equals(city));
            }
            if (!string.IsNullOrWhiteSpace(tag))
            {
                posts = posts.Where(p => p.Tags.Contains(tag));
            }
            if (!string.IsNullOrWhiteSpace(keyword))
            {
                posts = posts.Where(p => p.Title.ToLower().Contains(keyword.Trim().ToLower()));
            }
            //model.Posts = await posts.ToListAsync();
            model.Posts = PagedList<Post>.ToPagedList(posts, page, 6);
            return View(model);
        }

        // GET: UserPosts
        public async Task<IActionResult> UserPosts()
        {
            var id = _userManager.GetUserId(User); // get user Id
            var user = await _userManager.GetUserAsync(User); // get user's all data
            // string id = User.FindFirst(ClaimTypes.NameIdentifier).Value;           
            return View(await _context.Post
                .Where(post => post.AccountId.Equals(id))
                .Include(x => x.Category)
                .OrderByDescending(p => p.CreatedTime)
                .ToListAsync());
        }

        // GET: Posts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var post = await _context.Post.Include(p => p.City)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (post == null)
            {
                return NotFound();
            }
            ViewBag.Author = await _userManager.FindByIdAsync(post.AccountId);

            return View(post);
        }

        // GET: Posts/Create
        [Authorize]
        public async Task<IActionResult> Create()
        {

            ViewBag.Categories = await _context.Category
                     .Select(cat => new SelectListItem
                     {
                         Value = cat.Id.ToString(),
                         Text = cat.Name
                     }).ToListAsync();
            ViewBag.Cities = await _context.City
                     .Select(city => new SelectListItem
                     {
                         Value = city.Id,
                         Text = city.Name
                     }).ToListAsync();

            return View();
        }

        // POST: Posts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<IActionResult> Create([Bind("Title,Content,ImageUrl,Tags,CategoryId,CityId,ContactPhone,ContactEmail")] CreatePostViewModel vm)
        {
            if (ModelState.IsValid)
            {
                Post post = new Post
                {
                    Title = vm.Title,
                    Content = vm.Content,
                    CategoryId = vm.CategoryId,
                    Tags = vm.Tags,
                    ImageUrl = vm.ImageUrl,
                    CityId = vm.CityId,
                    ContactPhone = vm.ContactPhone,
                    ContactEmail = vm.ContactEmail
                };
                var userid = _userManager.GetUserId(User);
                post.AccountId = userid;
                post.CreatedDate = DateTime.Now.Date;
                post.CreatedTime = DateTime.Now;
                _context.Add(post);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index", "Home");
            }
            return View(vm);
        }

        // GET: Posts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var post = await _context.Post.FindAsync(id);
            if (post == null)
            {
                return NotFound();
            }
            EditPostViewModel vm = new EditPostViewModel
            {
                Title = post.Title,
                Content = post.Content,
                CategoryId = post.CategoryId,
                Tags = post.Tags,
                ImageUrl = post.ImageUrl,
                CityId = post.CityId,
                ContactPhone = post.ContactPhone,
                ContactEmail = post.ContactEmail,
                AccountId = post.AccountId
            };

            ViewBag.Categories = await _context.Category
                     .Select(cat => new SelectListItem
                     {
                         Value = cat.Id.ToString(),
                         Text = cat.Name
                     }).ToListAsync();
            ViewBag.Cities = await _context.City
                     .Select(city => new SelectListItem
                     {
                         Value = city.Id,
                         Text = city.Name
                     }).ToListAsync();
            return View(vm);
        }

        // POST: Posts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title,Content,AccountId,ImageUrl,Tags,ContactPhone,ContactEmail,CategoryId,CityId")] EditPostViewModel vm)
        {
            if (id != vm.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                Post post = new Post
                {
                    Id = id,
                    Title = vm.Title,
                    Content = vm.Content,
                    CategoryId = vm.CategoryId,
                    Tags = vm.Tags,
                    ImageUrl = vm.ImageUrl,
                    CityId = vm.CityId,
                    ContactPhone = vm.ContactPhone,
                    ContactEmail = vm.ContactEmail
                };
                var userid = _userManager.GetUserId(User);
                post.AccountId = userid;
                try
                {
                    _context.Update(post);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PostExists(post.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("UserPosts");
            }
            return View(vm);
        }

        // GET: Posts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var post = await _context.Post
                .FirstOrDefaultAsync(m => m.Id == id);
            if (post == null)
            {
                return NotFound();
            }

            return View(post);
        }

        // POST: Posts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var post = await _context.Post.FindAsync(id);
            _context.Post.Remove(post);
            await _context.SaveChangesAsync();
            return RedirectToAction("UserPosts","Posts");
        }

        private bool PostExists(int id)
        {
            return _context.Post.Any(e => e.Id == id);
        }
    }
}
