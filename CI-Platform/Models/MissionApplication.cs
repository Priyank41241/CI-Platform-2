using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CI_Platform.Models
{
    public class MissionApplication
    {
        [Key]
        public int Mission_application_id { get; set; }
        [ForeignKey("Mission_id")]
        public int Mission_id { get; set; }
        public int User_id { get; set; }
        public enum Approval_status { Pending, Approved, Decline}
        public DateTime Created_at { get; set; } = DateTime.Now;
        public DateTime? Updated_at { get; private set; }
        public DateTime? Deleted_at { get; set; }
    }
}
