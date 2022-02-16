
namespace Composition_From_Project.Entities
{
    internal class Department
    {
        public string Name { get; set; }

        public Department() { }
        public Department(string name)
        {
            Name = name;
        }
    }
}
