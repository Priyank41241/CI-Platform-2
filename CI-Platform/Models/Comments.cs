using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CI_Platform.Models
{
    public class Comments
    {
        [Key]
        public int Comment_id { get; set; }
        [ForeignKey("User_id")]
        public int User_id { get; set; }
        
        [ForeignKey("Mission_id")]
        public int Mission_id { get; set; }
        
        public enum CommentsStatus { Pending, Published} 
        public DateTime? Created_at { get; set; } = DateTime.Now;   
        public DateTime? Updated_at { get;set; }
        public DateTime? Deleted_at { get; set;}
    }
}
