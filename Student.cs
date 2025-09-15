
namespace TaskDay4CSharp
{
    internal class Student : Person
    {
        public Student()
        {
            Id = IdGenerator.GenerateId();
        }
        public List<Course> courses { get; set; }
        public void RegisterCourse(Course course) { 
            courses.Add(course);
        }
        public override void Introduce()
        {
            Console.WriteLine("I am a learner");
        }
        public static void DisplayCourseLevelAfterRegistration(Course course) { 
        
        
        }
    }
}
