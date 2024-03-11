using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDoctor.Entities
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

            optionsBuilder.UseNpgsql(@"User ID =postgres;Password=1;Server=localhost;Port=5432;Database=FitStepDb;Integrated Security=true;Pooling=true;");

            return new MyDoctorContext(optionsBuilder.Options);
        }
    }
}
