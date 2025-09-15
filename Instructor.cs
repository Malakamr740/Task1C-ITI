
namespace TaskDay4CSharp
{
    internal class Instructor : Person
    {
        public Instructor()
        {
            Id = IdGenerator.GenerateId();
        }
        public void TeachCourse(Course course) { 
         course.AssignInstructor(this);
        }
        public override void Introduce()
        {
            Console.WriteLine("I am a Teacher");
        }
    }
}
