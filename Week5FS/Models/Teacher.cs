namespace Week5FS.Models
{
    public class Teacher
    {
        public int TeacherId { get; set; }
        public string TeacherName { get; set; }
        public  string TeacherAddress { get; set; }
        public int TeacherAge { get; set; }
        //public List<Subject> TeacherBubjects { get; set; } = new List<Subject>();// N:N
        public Subject Subject { get; set; } //N:1
    }
}
