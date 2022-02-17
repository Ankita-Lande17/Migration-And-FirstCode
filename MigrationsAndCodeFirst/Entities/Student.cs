using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MigrationsAndCodeFirst.Entities
{
    [Table("StudentMaster")]
    public class Student
    {
        public int StudentId{get; set;}

        [Column("StudentName")]
        [MaxLength(20)]
        public string Name { get; set; }
        [NotMapped]
        public int Age { get; set; }
        public string Email { get; set; }
        public int StandardId { get; set; }
        [ForeignKey("StandardId")]
        public virtual Standard Standard{ get; set; }



    }
}
