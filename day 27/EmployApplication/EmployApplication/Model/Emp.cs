using System.ComponentModel.DataAnnotations;

namespace EmployApplication.Model
{
    public class Emp
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }
        public string? Gender { get; set; }
        public decimal Salary { get; set; }
    }
}
