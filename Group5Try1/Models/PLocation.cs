using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Group5Try1.Models
{
    public class PLocation
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }

        [Column("Location")]
        [StringLength(50)]
        [Required]
        public string Location { get; set; }
    }
}
