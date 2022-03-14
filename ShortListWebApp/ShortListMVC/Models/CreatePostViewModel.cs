namespace ShortListMVC.Models
{
    public class CreatePostViewModel
    {        
        public string Title { get; set; }
        public string Content { get; set; }        
        public string ImageUrl { get; set; }
        public string Tags { get; set; }
        public int? CategoryId { get; set; }        
    }
}
