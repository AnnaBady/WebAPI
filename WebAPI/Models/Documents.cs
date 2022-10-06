using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebAPI.Models
{
    public class Documents
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        public string Name { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Date { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Created { get; set; }
        [Column("Due_Date", TypeName = "datetime")]
        public DateTime? DueDate { get; set; }


        public int PriorityId { get; set; }
        public Priorities? Priority { get; set; }
        public List<Document_Files>? Files { get; set; }
    }
}
