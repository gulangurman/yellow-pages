namespace ShortListMVC.Models
{
    public class HomeViewModel
    {
        public IEnumerable<Category> Categories { get; set; }
        public IEnumerable<Post> Posts { get; set; }
        public IEnumerable<City> Cities { get; set; }
        public IEnumerable<CategoryStatsViewModel> CategoryStats { get; set; }
    }
}
