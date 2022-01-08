using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ServiceAuto1.Models;

namespace ServiceAuto1.Data
{
    public class ServiceAuto1Context : DbContext
    {
        public ServiceAuto1Context (DbContextOptions<ServiceAuto1Context> options)
            : base(options)
        {
        }

        public DbSet<ServiceAuto1.Models.Client> Client { get; set; }

        public DbSet<ServiceAuto1.Models.Review> Review { get; set; }

        public DbSet<ServiceAuto1.Models.Factura> Factura { get; set; }

        public DbSet<ServiceAuto1.Models.Programare> Programare { get; set; }

        public DbSet<ServiceAuto1.Models.Specializare> Specializare { get; set; }
    }
}
