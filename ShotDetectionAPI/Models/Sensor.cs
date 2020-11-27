using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShotDetectionAPI.Models
{
    public class Sensor
    {
        public long Id { get; set; }
        public float Latitude { get; set; }
        public float Longitude { get; set; }
        public float Voltage { get; set; }
        public List<Detection> Detections { get; set; }
    }
}
