using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CDP_Alpha.Models
{
    public class Trainer
    {
        public int EmployeeId { get; set; }
        public string TrainerName { get; set; }
        public string TrainerDomain { get; set; }
        public List<Course> Courses { get; set; }'
        public List<Trainee> Trainees { get; set; }

    }
}