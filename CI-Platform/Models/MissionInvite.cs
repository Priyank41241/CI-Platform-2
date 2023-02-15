namespace CI_Platform.Models
{
    public class MissionInvite
    {
        public string Mission_invite_id { get; set; }
        public int Mission_id { get; set; }
        public int From_user_id { get; set; }
        public int To_user_id { get; set;}
        public DateTime Created_at { get; set; } = DateTime.Now;
        public DateTime? Updated_at { get; private set; }
        public DateTime? Deleted_at { get; set; }
    }
}
