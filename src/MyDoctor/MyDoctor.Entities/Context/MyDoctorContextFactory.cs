using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace MyDoctor.Entities.Context
{
    public class MyDoctorContextFactory : IDesignTimeDbContextFactory<MyDoctorContext>
    {
        public MyDoctorContext CreateDbContext(string[] args)
        {
            return CreateDb();
        }

        public MyDoctorContext CreateDb()
        {
            var optionsBuilder = new DbContextOptionsBuilder<MyDoctorContext>();

            optionsBuilder.UseNpgsql(@"Server=localhost;Port=5432;Database=MyDoctorContext;Pooling=true;");

            return new MyDoctorContext(optionsBuilder.Options);
        }
    }
}
