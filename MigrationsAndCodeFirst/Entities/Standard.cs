using System.ComponentModel.DataAnnotations;

namespace MigrationsAndCodeFirst.Entities
{
    public class Standard
    {
        [Key]
        public int StandardId { get; set; }
        public string StandardName { get; set; }
    }
}
