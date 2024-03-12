using Microsoft.EntityFrameworkCore;
using MyDoctor.Entities.Enums;
using MyDoctor.Entities.Model;
using MyDoctor.Entities.Models;

namespace MyDoctor.Entities.Configuration
{
    public static class EntitySeeds
    {
        public static void Seeds(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(CreateUsers());
        }

        private static List<User> CreateUsers()
        {
            return new List<User>()
            {
                new User("test@email.com", "12345678", UserType.Admin, new List<Password>(), new List<Patient>(), new List<Doctor>())
            };
        }
    }
}
