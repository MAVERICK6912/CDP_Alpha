using System.Collections.Generic;

namespace CDP_Alpha.Models
{
    public class Course
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public string AuthenticationKey { get; set; }
        public List<Feedback> Feedbacks { get; set; }
        public int MyProperty { get; set; }
        public List<Topic> Topics { get; set; }
    }
}