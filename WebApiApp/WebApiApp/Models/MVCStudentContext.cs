using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WebApiApp.Models
{
    public class MVCStudentContext:DbContext
    {
        public MVCStudentContext(DbContextOptions<MVCStudentContext>options)
            : base(options)
        {

        }
        public DbSet<WebApiApp.Models.Students> Student { get; set; }
    }
}
