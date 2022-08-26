using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Week5FS.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }
        [Required]
        [StringLength(160)]
        public string Name { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        public long Salary { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy}")]
        [DisplayName("Date of Birth")]
        public DateTime DateOfBirth { get; set; }
        
        public string Department { get; set; }

        /* not to show in database
        [NotMapped]
        public int MyProperty { get; set; }*/
    }
}
