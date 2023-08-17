using System.ComponentModel.DataAnnotations;

namespace PracticalTwentyFour.Application.Models
{
    public class EmployeeModel
    {
        public int Id { get; set; } 

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required]
        public decimal Salary { get; set; }

        [Required]
        [MaxLength(260)]
        [RegularExpression("^[\\w-\\.]+@([\\w-]+\\.)+[\\w-]{2,4}$", ErrorMessage = "Please enter valid email address")]
        [DataType(DataType.EmailAddress)]
        public string EmailAddress { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime JoiningDate { get; set; }

        public bool IsDeleted { get; set; } = false;

        [Required]
        [MaxLength(50)]
        public string Department { get; set; } = null!;
    }
}
