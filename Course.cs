using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskDay4CSharp
{
    enum CourseLevel { 
    Beginner,
    Intermediate,
    Advanced 
    
    }
    internal class Course
    {
        public string Name { get; set; }
        public int Duration { get; set; }
        public string Track { get; set; }
        public Instructor CourseInstructor { get; set; }

        CourseLevel Level { get; set; }

        public void AssignInstructor(Instructor instructor) { 
        
          CourseInstructor = instructor;
        }
    }
}
