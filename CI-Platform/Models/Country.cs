using System.ComponentModel.DataAnnotations;

namespace CI_Platform.Models
{
    public class Country
    {
        [Key]
        public int Country_id { get; set; }
        public string Name { get; set; }
        public string ISO { get; set; }
        public DateTime? Created_at { get; set; } = DateTime.Now;
        public DateTime? Updated_at { get; set;}
        public DateTime? Deleted_at { get; set; }
    }
}
