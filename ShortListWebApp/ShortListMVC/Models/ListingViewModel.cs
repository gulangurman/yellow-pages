namespace ShortListMVC.Models
{
    public class ListingViewModel
    {
        public IEnumerable<Post> Posts { get; set; }  
        public IEnumerable<CategoryStatsViewModel> CategoryStats { get; set; }
    }
}
