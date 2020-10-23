using Microsoft.EntityFrameworkCore;


namespace ShotDetectionAPI.Models
{
    public class SensorContext:DbContext
    {
        public SensorContext(DbContextOptions<SensorContext> options)
            : base(options)
        {

        }

        public DbSet<Sensor> Sensors { get; set; }
    }
}
