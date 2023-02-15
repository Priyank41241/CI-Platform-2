using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CI_Platform.Models
{
    public class Missions
    {   
        [Key]
        public int Mission_id { get; set; }
        [ForeignKey("Theme_id")]
        public int Theme_id { get; set; }
        [ForeignKey("City_id")]
        public int City_id { get; set; }
        [ForeignKey("Country_id")]
        public int Country_id { get; set; }
        public string Title { get; set; }
        public string Short_discription { get; set; }
        public string Description { get; set; }
        public DateTime? Start_date { get; set; }
        public DateTime? End_date  { get; set; }
        public enum Mission_type { Time, Goal}
        public enum Status { Running, Ended}
        public string Organization_name { get; set; }
        public string Organization_detail { get; set; }
        public enum Availability { Daily, Weekly, Weekend, Monthly}
        public DateTime? Created_at { get; set; } = DateTime.Now;
        public DateTime? Updated_at { get;set; }
        public DateTime? Deleted_at { get; set; }

    }
}
