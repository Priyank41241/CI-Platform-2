using System.ComponentModel.DataAnnotations;

namespace CI_Platform.Models
{
    public class Banner
    {
        [Key]
        public int Banner_id { get; set; }
        public string Image { get; set; }
        public string text { get; set; }
        public int sort_order { get; set; } = 0;
        public DateTime? created_at { get; set; } = DateTime.Now;
        public DateTime? updated_at { get;set; }
        public DateTime? daleted_at { get; set; }
    }
}
