using System.ComponentModel.DataAnnotations;

namespace DepartmentProject.Models
{
    public class Personel
    {
        [Key]
        public int PersonelId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string City { get; set; }
        public int DepartId { get; set; }
        public virtual Department Department { get; set; }
    }
}
