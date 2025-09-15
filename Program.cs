
using TaskDay4CSharp.Shapes;
namespace TaskDay4CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Department> departments = new List<Department>();
            departments.Add(new Department() { Name = "IT", Location = "Cairo" });
            departments.Add(new Department() { Name = "Backend", Location = "Alex" });
            departments.Add(new Department() { Name = "Frontend", Location = "Assiut" });


            Company company = new Company("It", "Cairo", departments);
            company.Departments[0].Employees = new List<Employee>()
                                              { new Employee() {Name = "Malak" , Age = 21 ,
                                               Courses = new List<Course>() { new Course(){Name = "ITI Backend", Duration = 1, Track = ".Net" } }
                                              , Department = new Department(){Name = "Backend",Employees = new List<Employee>() } } };


            #region Shapes

            List<Shape> shapes= new List<Shape>();
            shapes.Add(new Circle() {Radius = 7});
            shapes.Add(new Rectangle() {Length = 5, Width = 10});

           for(int i = 0; i < shapes.Count; i++)
            {
                Console.WriteLine($"Shape Name : {shapes[i].Name}");
                Console.WriteLine($"Area : {shapes[i].Area()}");
                shapes[i].Draw();
                Console.WriteLine();
            }
                Console.WriteLine();
        }
            #endregion

    }
}
 
