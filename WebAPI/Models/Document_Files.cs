using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata;

namespace WebAPI.Models
{
    public class Document_Files
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }

        [Column("File_Path")]
        public string FilePath { get; set; }

        [Column("Document_ID")]
        public int? DocumentId { get; set; }
        [ForeignKey("DocumentId")]
        public Documents Document { get; set; }
    }
}
