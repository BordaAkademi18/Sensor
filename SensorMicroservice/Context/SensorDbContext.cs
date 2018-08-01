using Microsoft.EntityFrameworkCore;
using SensorMicroservice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SensorMicroservice.Context
{
    public class SensorDbContext : DbContext
    {
        public SensorDbContext(DbContextOptions<SensorDbContext> options) :base(options)
        {

        }



        public DbSet<AirQuality> AirQuality { get; set; }
        public DbSet<Coffee> Coffee { get; set; }
        public DbSet<RestRoom> RestRoom { get; set; }
    }
}
