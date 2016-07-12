using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContosoUni.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string LastName { set; get; }
        public string FirstMidName { set; get; }
        public DateTime EnrollmentDate { set; get; }

        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}