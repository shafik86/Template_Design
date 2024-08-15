using Microsoft.EntityFrameworkCore;
using Template_Design.shared;

namespace Template_Design.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
            
        }

        public DbSet<Template> Templates { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Template>().HasData(new Template
            {
                Id = 1,
                Name = "Penjagaan Asset",
                Description = "Reka bentuk ini menunjukkan prestasi dan data untuk Asset",
                PbiUrl = "https://app.powerbi.com/view?r=eyJrIjoiMjYyOTNmOGMtNjUwZC00MDAwLWE5ODUtYjY1MDI0OGUxMjRlIiwidCI6ImM2NWIxYzYzLTdjYjctNGFlNy05YzNjLTk5OWI0ZGE1MjM5NiIsImMiOjEwfQ%3D%3D",
                Thumb = "./images/default.jpg"
            });
            modelBuilder.Entity<Template>().HasData(new Template
            {
                Id = 2,
                Name = "Data Rangkaian",
                Description = "Reka Bentuk ini menunjukkan Data dan prestasi Data Rangkaian",
                PbiUrl = "https://app.powerbi.com/view?r=eyJrIjoiMmI0YjcyZDUtZjNhYy00MGMxLWEzZDktNTkzZDE5ZDQzZDUxIiwidCI6ImM2NWIxYzYzLTdjYjctNGFlNy05YzNjLTk5OWI0ZGE1MjM5NiIsImMiOjEwfQ%3D%3D",
                Thumb = "./images/default.jpg"
            });
            modelBuilder.Entity<Template>().HasData(new Template
            {
                Id = 3,
                Name = "Road Accident",
                Description = "Reka Bentuk ini menunjukkan Kadar berlakunya kemalangan dan juga kematian",
                PbiUrl = "https://app.powerbi.com/view?r=eyJrIjoiOTc4YmVjMGUtY2M4Ni00YTQwLWJmZTktNGQwM2I1NDE1NTZiIiwidCI6ImM2NWIxYzYzLTdjYjctNGFlNy05YzNjLTk5OWI0ZGE1MjM5NiIsImMiOjEwfQ%3D%3D",
                Thumb = "./images/default.jpg"
            });
            //modelBuilder.Entity<Template>().HasData(new Template
            //{

            //});
        }
    }
}
