using System.ComponentModel.DataAnnotations.Schema;

namespace Lab4.NewFolder
{
    public class Course
    {
        public Course()
        {
            Enrollments =new HashSet<Enrollment>();
        }
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CourseID { get; set; }
        public string Title { get; set; }
        public int Credits { get; set; }
        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}
