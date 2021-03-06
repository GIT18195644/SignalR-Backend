using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using APISignalR.Models;

namespace APISignalR.Data
{
    public class MyDbContext : DbContext
    {
        public MyDbContext (DbContextOptions<MyDbContext> options)
            : base(options)
        {
        }

        public DbSet<APISignalR.Models.Employee> Employee { get; set; }
        public DbSet<Notification> Notification { get; set; }
    }
}
