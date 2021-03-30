using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DirectReport.Models;
using Microsoft.EntityFrameworkCore;

namespace DirectReport.Data
{
    public class PureQuestDbContext : DbContext
    {
        public PureQuestDbContext(DbContextOptions options) : base(options)
        {
        }

        DbSet<User> User { get; set; }
    }
}
