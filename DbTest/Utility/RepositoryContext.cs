using DbTest.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DbTest.Utility
{
    public class RepositoryContext:DbContext
    {
        public RepositoryContext(DbContextOptions options)
           : base(options)
        {
        }

        public DbSet<User> users { get; set; }
    }
}
