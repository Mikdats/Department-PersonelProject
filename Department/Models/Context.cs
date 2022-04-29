using DepartmentExample.Models;
using Microsoft.EntityFrameworkCore;

namespace DepartmentProject.Models
{
    public class Context : DbContext
    {
        protected override void OnConfiguring
            (DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-HNE43R2; " +
                "database=corepersonel;integrated security=true;");
        }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Personel> Personels { get; set; }
        public DbSet<Admin> Admins { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>().HasData(
                  new Department { DepartId = 1, DepartmentName = "Muhasebe" },
                  new Department { DepartId = 2, DepartmentName = "Satın Alma" },
                  new Department { DepartId = 3, DepartmentName = "Müdür" },
                  new Department { DepartId = 4, DepartmentName = "Müdür Yardımcısı" },
                  new Department { DepartId = 5, DepartmentName = "Danışma" },
                  new Department { DepartId = 6, DepartmentName = "Sekreter" }
                );
            modelBuilder.Entity<Personel>().HasData(
                  new Personel { PersonelId = 1, Name = "Mikdat" ,Surname="Gürses",City="Trabzon", DepartId=3},
                  new Personel { PersonelId = 2, Name = "Bilge", Surname = "Yılmaz", City = "Rize", DepartId = 4 },
                  new Personel { PersonelId = 3, Name = "Yalçın", Surname = "Uzun", City = "Samsun", DepartId = 1 },
                  new Personel { PersonelId = 4, Name = "Dilara", Surname = "İzibüyük", City = "Sivas", DepartId = 2 },
                  new Personel { PersonelId = 5, Name = "Furkan", Surname = "Elmas", City = "Sinop", DepartId = 5 },
                  new Personel { PersonelId = 6, Name = "Enes", Surname = "Akpınar", City = "Erzincan", DepartId = 5 },
                  new Personel { PersonelId = 7, Name = "Burak", Surname = "Kapıcı", City = "Muş", DepartId = 6 }

                );
        }
    }

}
