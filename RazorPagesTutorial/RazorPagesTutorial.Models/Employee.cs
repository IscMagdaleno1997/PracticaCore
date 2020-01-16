namespace RazorPagesTutorial.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Photopath { get; set; }
        public Dept? Departament { get; set; }
    }

}
