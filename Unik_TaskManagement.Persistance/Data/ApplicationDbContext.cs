using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unik_TaskManagement.Domain;

namespace Unik_TaskManagement.Persistence.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext ( DbContextOptions<ApplicationDbContext> options ) : base(options)
        {
        }
        public DbSet<Kunde> Kunder { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Opgave> Opgaver { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<Medarbejde> Medarbejder { get; set; }
        public DbSet<Booking> Booking { get; set; }
    }
}
