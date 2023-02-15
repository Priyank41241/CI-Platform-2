using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CI_Platform.Models
{
    public class GoalMission
    {
        [Key]
        public int Goal_mission_id { get; set; }
        [ForeignKey("Mission_id")]
        public int Mission_id { get; set; }
        public string Goal_objective_text { get; set; }
        public int Goal_value { get; set; }
        public DateTime? Created_at { get; set; } = DateTime.Now;
        public DateTime? Updated_at { get; set; }
        public DateTime? Deleted_at { get; set; }
    }
}
