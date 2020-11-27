using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShotDetectionAPI.Models
{
    public class DataBaseContext:DbContext
    {
        public DataBaseContext(DbContextOptions<DataBaseContext> options)
            : base(options)
        {

        }

        public DbSet<Detection> Detections { get; set; }
        public DbSet<Shot> Shots { get; set; }
        public DbSet<Sensor> Sensors { get; set; }


    }
}
