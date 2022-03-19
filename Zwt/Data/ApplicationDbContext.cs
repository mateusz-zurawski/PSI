using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Zwt.Data.Entity;

namespace Zwt.Data
{
    public class ApplicationDbContext : IdentityDbContext<AppUser, AppRole, string>
    {
            public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
                : base(options)
            {
            }

            public DbSet<Appointment> Appointments { get; set; }
        }

}
