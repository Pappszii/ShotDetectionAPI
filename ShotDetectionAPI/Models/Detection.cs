﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ShotDetectionAPI.Models
{
    public class Detection
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public DateTime TimeStamp { get; set; }
        public Sensor Sensor { get; set; }
        public int SensorId { get; set; }
    }
}
