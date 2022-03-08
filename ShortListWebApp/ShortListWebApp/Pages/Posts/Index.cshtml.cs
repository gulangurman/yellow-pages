using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ShortListWebApp.Data;
using ShortListWebApp.Model;

namespace ShortListWebApp.Pages.Posts
{
    public class IndexModel : PageModel
    {
        private readonly PostContext _context;

        public IndexModel(PostContext context)
        {
            _context = context;
        }

        public IList<Post> Post { get;set; }

        public async Task OnGetAsync()
        {
            Post = await _context.Post.ToListAsync();
        }
    }
}
