using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Crud.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace Crud.Data
{
    public class DataBaseContext : DbContext
    {
        // public DataBaseContext(DbContextOptions<DataBaseContext>options):base(options)
        // {

        // }
        public DataBaseContext(DbContextOptions options) : base(options)
        {
        }


        public DbSet<Employee> Employees { get; set; }
    }
}