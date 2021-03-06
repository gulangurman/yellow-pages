using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShortListMVC.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string AccountId { get; set; }
        public string? ImageUrl { get; set; }
        public string? Tags { get; set; }

        public string? ContactPhone { get; set; }
        public string? ContactEmail { get; set; }
        
        public DateTime CreatedDate { get; set; }
        public DateTime CreatedTime { get; set; }

        public int? CategoryId { get; set; }
        public virtual Category Category { get; set; }

        public string? CityId { get; set; }
        public City City { get; set; }
    }
}
