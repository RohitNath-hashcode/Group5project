using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Group5Try1.Models
{
    public class Speciality
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }

        [Column("Catagory")]
        [Required]
        [StringLength(50)]
        public string Catagory { get; set; }
    }
}
