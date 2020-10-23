using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShotDetectionAPI.Models
{
    public class DetectionContext:DbContext
    {
        public DetectionContext(DbContextOptions<DetectionContext> options)
            : base(options)
        {

        }

        public DbSet<Detection> Detections { get; set; }
    }
}
