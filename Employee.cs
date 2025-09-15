

namespace TaskDay4CSharp
{
    internal class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Department Department { get; set; }
        public List<Course> Courses { get; set; }

        public override string ToString()
        {
            Console.WriteLine($"Name = {Name}");
            Console.WriteLine($"Age = {Age}");
            Console.WriteLine($"Department = {Department.Name}");
            Console.WriteLine("Courses : ");
            for ( int i = 0; i < Courses.Count; i++)
            {
                Console.WriteLine($"Course {i + 1} : {Courses[i].Name}");
            }
            return "";
        }
    }
}
