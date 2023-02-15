using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CI_Platform.Models
{
    public class MissionDocuments
    {
        [Key]
        public int Mission_document_id { get; set; }
        [ForeignKey("Mission_id")]
        public int Mission_id { get; set; }
        public string DocumentName { get; set; }
        public string DocumentType { get; set; }
        public string DocumentPath  { get; set; }
        public DateTime Created_at { get; set; } = DateTime.Now;
        public DateTime? Updated_at { get; private set; }
        public DateTime? Deleted_at { get; set; }
    }
}
