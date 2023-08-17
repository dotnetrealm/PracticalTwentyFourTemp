using System.ComponentModel.DataAnnotations;

namespace PracticalTwentyFour.Data.Entities
{
    public class Department
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        // Relational property
        public ICollection<Employee> Employees { get; set; }
    }
}
