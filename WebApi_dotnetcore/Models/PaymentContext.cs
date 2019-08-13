using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi_dotnetcore.Models
{
    public class PaymentContext : DbContext 
    {
        public PaymentContext(DbContextOptions<PaymentContext> options) : base(options)
        {

        }
            public DbSet<Payment> Payments { get; set; }
    }
}
