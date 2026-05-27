using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ConnectedDB.Models
{
    public class MyDbContext :DbContext

    {
        public DbSet<Emp> emps { get; set; }
        public MyDbContext(DbContextOptions options) : base(options)
        {

        }


    }
}
