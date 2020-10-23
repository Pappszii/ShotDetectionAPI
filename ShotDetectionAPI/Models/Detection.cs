using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShotDetectionAPI.Models
{
    public class Detection
    {
        DateTime TimeStamp { get; set; }
        int Id { get; set; }
        float Longitude { get; set; }
        float Latitude { get; set; }

    }
}
