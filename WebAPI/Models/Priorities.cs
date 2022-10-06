using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata;

namespace WebAPI.Models
{
    public class Priorities
    {
        public Priorities()
        {
            Documents = new HashSet<Documents>();
        }

        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [StringLength(50)]
        public string Name { get; set; }

        public virtual ICollection<Documents> Documents { get; set; }
    }
}
