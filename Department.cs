

namespace TaskDay4CSharp
{
    internal class Department
    {
        public Department()
        {
            Employees = new List<Employee>();
        }
        public Department(string name, string location, List<Employee> employees)
        {
            Name = name;
            Location = location;
            Employees = employees;
        }

        public string Name { get; set; }
        public string  Location  { get; set; }
        public List<Employee> Employees { get; set; }


    }
}
