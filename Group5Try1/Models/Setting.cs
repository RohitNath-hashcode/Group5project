using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Group5Try1.Models
{
    [Table("AccountSetting")]
    public class Setting
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }

        [Column("Name")]
        [Required]
        [StringLength(50)]
        public string Name { get; set; }



        [Column("Email")]
        [Required]
        [StringLength(50)]
        public string Email { get; set; }



        [Column("Number")]
        [Required]
        [StringLength(50)]
        public int Number { get; set; }

        [Column("Practice Location")]
        [StringLength(50)]
        public string PracticeLesson { get; set; }

        [Column("NPI No")]
        [Required]
        [StringLength(50)]
        public string NPI_No { get; set; }

        [Column("Speciality_id")]
        [Required]
        public int Speciality_id { get; set; }

        [ForeignKey("Speciality_id")]
        public Speciality Speciality { get; set; }

        [Column("PLocation_id")]
        public int PLocation_id { get; set; }

        [ForeignKey("PLocation_id")]
        public PLocation PLocation { get; set; }

        /*

        [Column("Speciality")]
        [Required]
        [StringLength(50)]
        public string Speciality { get; set; }



        [Column("NPI No")]
        [Required]
        [StringLength(50)]
        public string NPI_No { get; set; }



        [Column("Practice Location")]
        [StringLength(50)]
        public string PracticeLesson { get; set; }*/
    }
}
