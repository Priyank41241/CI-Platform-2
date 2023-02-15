using System.ComponentModel.DataAnnotations;

namespace CI_Platform.Models
{
    public class Cms_page
    {
        [Key]
        public int Cms_page_id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Slug { get; set; }
        public enum Status { No, Yes}
        public DateTime? Created_at { get; set; } = DateTime.Now;
        public DateTime? Updated_at { get; set; }
        public DateTime? Deleted_at { get; set; }
    }
}
