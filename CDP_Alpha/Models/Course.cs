using System.Collections.Generic;

namespace CDP_Alpha.Models
{
    public class Course
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public string AuthenticationKey { get; set; }
        public List<Feedback> Feedbacks { get; set; }
        public List<Trainer> Trainers { get; set; }
        public List<Trainee> Trainees { get; set; }
    }
}