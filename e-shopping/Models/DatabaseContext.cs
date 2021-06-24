using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace e_shopping.Models
{
    public class DatabaseContext: Microsoft.EntityFrameworkCore.DbContext
    {
        public DatabaseContext()
        {
        }

        public DatabaseContext(DbContextOptions<DatabaseContext> options):base(options)
        {
            
        }
        public Microsoft.EntityFrameworkCore.DbSet<Admin> Admins { get; set; }
    }
}
