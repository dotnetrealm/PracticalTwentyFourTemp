using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PracticalTwentyFour.Data.Entities
{
    public class Employee
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required]
        [Column(TypeName = "money")]
        public decimal Salary { get; set; }

        [Required]
        [MaxLength(260)]
        [RegularExpression("^[\\w-\\.]+@([\\w-]+\\.)+[\\w-]{2,4}$", ErrorMessage = "Please enter valid email address")]
        [DataType(DataType.EmailAddress)]
        public string EmailAddress { get; set; }

        [Required]
        [Column(TypeName = "date")]
        [DataType(DataType.Date)]
        public DateTime JoiningDate { get; set; }

        public bool IsDeleted { get; set; } = false;

        public int DepartmentId { get; set; }

        // Navigation property
        public Department Department { get; set; }
    }
}
