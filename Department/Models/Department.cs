using System.ComponentModel.DataAnnotations;

namespace DepartmentProject.Models
{
    public class Department
    {
        [Key]
        public int DepartId { get; set; }
        public string DepartmentName { get; set; }

        public IList<Personel> Personels { get; set; }

    }
}
