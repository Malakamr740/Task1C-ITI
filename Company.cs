

namespace TaskDay4CSharp
{
    internal class Company
    {
        public Company(string name, string address, List<Department> departments)
        {
            Name = name;
            Address = address;
            Departments = departments;
        }

        public string Name { get; set; }
        public string Address { get; set; }
        public List<Department> Departments { get; set; }

        
    }
}
