using BusReserve.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusReserve
{
    public class BusReserveContext : DbContext
    {
        public BusReserveContext(DbContextOptions<BusReserveContext> options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Bus> Buses { get; set; }
        public DbSet<BusRoute> BusRoutes { get; set; }
    }
}
