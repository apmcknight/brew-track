using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using brew_track.Models;

    public class OrdersDatabaseContext : DbContext
    {
        public OrdersDatabaseContext (DbContextOptions<OrdersDatabaseContext> options)
            : base(options)
        {
        }

        public DbSet<brew_track.Models.Orders> Orders { get; set; }
    }
