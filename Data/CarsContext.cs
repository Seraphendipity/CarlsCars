using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CC;

    // Context Class for Model -- interacts with DB.

    public class CarsContext : DbContext
    {
        public CarsContext (DbContextOptions<CarsContext> options)
            : base(options)
        {
        }

        public DbSet<CC.Car> Car { get; set; } = default!;
    }
