namespace ShortListMVC.Models
{
    public class EditPostViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string? ImageUrl { get; set; }
        public string? Tags { get; set; }
        public int? CategoryId { get; set; }
        public string? CityId { get; set; }
        public string? ContactPhone { get; set; }
        public string? ContactEmail { get; set; }

        public string AccountId { get; set; }
    }
}
