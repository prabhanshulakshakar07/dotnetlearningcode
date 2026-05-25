using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using EntityFrameWork.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
namespace EntityFrameWork.DAL
{


    public class CustomerDbContext : DbContext

    {

        public DbSet<Customer> Customers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var builder = new ConfigurationBuilder();
            builder.SetBasePath(Directory.GetCurrentDirectory());
            builder.AddJsonFile("appsettings.json");
            IConfiguration config = builder.Build();
            var connectionString = config.GetConnectionString("constr");

            optionsBuilder.UseSqlServer(connectionString);


        }

    }

    }
