using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShotDetectionAPI.Models
{
    public class Detection
    {
       public int Id { get; set; }
       public DateTime TimeStamp { get; set; }
       public float Longitude { get; set; }
       public float Latitude { get; set; }

    }
}
