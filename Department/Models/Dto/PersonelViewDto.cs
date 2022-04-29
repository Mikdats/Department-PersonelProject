namespace DepartmentExample.Models.Dto
{
    public class PersonelViewDto : IDto
    {
        public int PersonelId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string City { get; set; }
        public string DepartName { get; set; }
    }
}
