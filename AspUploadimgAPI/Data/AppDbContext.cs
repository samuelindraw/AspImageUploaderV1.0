using AspUploadimgAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspUploadimgAPI.Data
{
    public class AppDbContext :DbContext
    {
        public AppDbContext(DbContextOptions options)
           : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
    }
}
