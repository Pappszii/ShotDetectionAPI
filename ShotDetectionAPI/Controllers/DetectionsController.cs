using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ShotDetectionAPI.Models;

namespace ShotDetectionAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DetectionsController : ControllerBase
    {
        private readonly DataBaseContext _context;

        public DetectionsController(DataBaseContext context)
        {
            _context = context;
        }

        // GET: api/Detections
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Detection>>> GetDetections()
        {
            return await _context.Detections.ToListAsync();
        }

        // GET: api/Detections/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Detection>> GetDetection(int id)
        {
            var detection = await _context.Detections.FindAsync(id);

            if (detection == null)
            {
                return NotFound();
            }

            return detection;
        }

        // PUT: api/Detections/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDetection(int id, Detection detection)
        {
            if (id != detection.Id)
            {
                return BadRequest();
            }

            _context.Entry(detection).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DetectionExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Detections
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Detection>> PostDetection(int sensorId)
        {
            Detection detection = new Detection()
            {
                SensorId = sensorId,
                TimeStamp = DateTime.UtcNow
            };

            _context.Detections.Add(detection);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDetection", new { id = detection.Id }, detection);
        }

        // DELETE: api/Detections/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Detection>> DeleteDetection(int id)
        {
            var detection = await _context.Detections.FindAsync(id);
            if (detection == null)
            {
                return NotFound();
            }

            _context.Detections.Remove(detection);
            await _context.SaveChangesAsync();

            return detection;
        }

        private bool DetectionExists(int id)
        {
            return _context.Detections.Any(e => e.Id == id);
        }
    }
}
