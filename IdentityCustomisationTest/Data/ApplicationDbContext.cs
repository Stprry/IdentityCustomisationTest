using System;
using System.Collections.Generic;
using System.Text;
using IdentityCustomisationTest.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using IdentityCustomisationTest.Models;

namespace IdentityCustomisationTest.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<IdentityCustomisationTest.Models.Property> Property { get; set; }
    }
}
