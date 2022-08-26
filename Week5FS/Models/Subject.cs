using System.ComponentModel.DataAnnotations;

namespace Week5FS.Models
{
    public class Subject
    {
        [Key]
        public int SubjectId { get; set; }
        public string? SubjectName { get; set; }
        public string? SubjectTerm { get; set; }
        public int SubjectCredit { get; set; }  
        public List<Teacher> SubjectTeachers { get; set; }= new List<Teacher>();
    }
}
