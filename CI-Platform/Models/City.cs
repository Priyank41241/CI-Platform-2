using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CI_Platform.Models
{
    public class City
    {
        [Key]
        public int City_id { get; set; }
        [ForeignKey("Country_id")]
        public string Country_id { get; set; }
        public string Name { get; set; }
        public DateTime? Created_at { get; set; } = DateTime.Now;
        public DateTime? Updated_at { get;set; }
        public DateTime? Deleted_at { get; set; } 
    }
}
