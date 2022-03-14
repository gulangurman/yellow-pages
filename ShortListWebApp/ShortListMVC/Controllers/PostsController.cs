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
        private readonly UserManager<IdentityUser> _userManager;

        public PostsController(PostContext context, UserManager<IdentityUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // GET: Posts
        public async Task<IActionResult> Index()
        {
            return View(await _context.Post.ToListAsync());
        }

        public async Task<IActionResult> Listing(string category = null)
        {
            ListingViewModel model = new ListingViewModel();
            model.Categories = await _context.Category.ToListAsync();
            model.Posts = await _context.Post.ToListAsync();
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
                .ToListAsync());
        }

        // GET: Posts/Details/5
        public async Task<IActionResult> Details(int? id)
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
            /*
             ViewBag.Categories.Insert(0, new SelectListItem()
            {
                Text = "----Kategori----",
                Value = string.Empty
            });
             */
            return View();
        }

        // POST: Posts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<IActionResult> Create([Bind("Title,Content,ImageUrl,Tags,CategoryId")] CreatePostViewModel vm)
        {
            if (ModelState.IsValid)
            {
                Post post = new Post
                {
                    Title = vm.Title,
                    Content = vm.Content,
                    CategoryId = vm.CategoryId,
                    Tags = vm.Tags,
                    ImageUrl = vm.ImageUrl
                };
                var userid = _userManager.GetUserId(User);
                post.AccountId = userid;
                _context.Add(post);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index), "Home");
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
            return View(post);
        }

        // POST: Posts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title,Content,AccountId,ImageUrl,Tags")] Post post)
        {
            if (id != post.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
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
                return RedirectToAction(nameof(Index));
            }
            return View(post);
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
            return RedirectToAction(nameof(Index));
        }

        private bool PostExists(int id)
        {
            return _context.Post.Any(e => e.Id == id);
        }
    }
}
