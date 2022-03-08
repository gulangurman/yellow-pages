using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using ShortListWebApp.Data;
using ShortListWebApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShortListWebApp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly PostContext _postContext;
        public IList<Post> Post;

        public IndexModel(ILogger<IndexModel> logger, PostContext postContext)
        {
            _logger = logger;
            _postContext = postContext;
        }

        public async void OnGetAsync()
        {
            Post = await _postContext.Post.ToListAsync();
        }
    }
}
