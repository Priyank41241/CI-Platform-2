using System.ComponentModel.DataAnnotations;

namespace CI_Platform.Models
{
    public class Admin
    {
        [Key]
        public int Admin_id { get; set; }
        public string? First_name { get; set;}
        public string? Last_name { get; set;}
        public string Email { get; set;}
        public string Password { get; set;}
        public DateTime Created_at { get; set; } = DateTime.Now;
        public DateTime? Updated_at { get; private set; }   
        public  DateTime? Deleted_at { get; set; }

    }
}
