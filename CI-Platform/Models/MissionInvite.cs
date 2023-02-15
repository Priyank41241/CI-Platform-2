using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CI_Platform.Models
{
    public class MissionInvite
    {
        [Key]
        public string Mission_invite_id { get; set; }
        [ForeignKey("Mission_id")]
        public int Mission_id { get; set; }
        [ForeignKey("User_id")]
        public int From_user_id { get; set; }
        [ForeignKey("User_id")]
        public int To_user_id { get; set;}
        public DateTime Created_at { get; set; } = DateTime.Now;
        public DateTime? Updated_at { get; private set; }
        public DateTime? Deleted_at { get; set; }
    }
}
