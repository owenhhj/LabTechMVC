using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LabTechMVC.Models;

namespace LabTechMVC.Data
{
    public class LabTechMVCContext : DbContext
    {
        public LabTechMVCContext (DbContextOptions<LabTechMVCContext> options)
            : base(options)
        {
        }

        public DbSet<LabTechMVC.Models.Issue> Issue { get; set; } = default!;
    }
}
