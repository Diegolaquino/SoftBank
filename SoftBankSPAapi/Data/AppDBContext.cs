using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace SoftBankSPAapi.Models
{
    public class AppDBContext : IdentityDbContext
    {
        public AppDBContext (DbContextOptions<AppDBContext> options)
            : base(options)
        {
        }

        public DbSet<Account> Accounts { get; set; }

        public DbSet<Customer> Customers { get; set; }
    }
}
