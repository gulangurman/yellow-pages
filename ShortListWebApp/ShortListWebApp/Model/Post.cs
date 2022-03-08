using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShortListWebApp.Model
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int AccountId { get; set; }
    }
}
