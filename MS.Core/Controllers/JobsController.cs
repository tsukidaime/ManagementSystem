using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MS.Core.Models;

namespace MS.Core.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public JobsController(AppDbContext context)
        {
            _context = context;
        }


        [HttpPost("{id}")]
        public IActionResult DistributeTask(Guid Id, Job task)
        {
            var users = _context.Users.TakeWhile(x => x.Department.Id == Id);
            if (users != null)
            {
                var sUsers = users.ToList();
                if (sUsers != null)
                {
                    sUsers.Sort();
                    var tasks = _context.Jobs.TakeWhile(x => x.Department.Id == Id);
                    foreach (Job job in tasks.TakeWhile(x => x.State == State.NotSelected))
                    {
                        double minRate = job.Complexity * (int)job.Priority;
                        foreach (User user in sUsers)
                        {
                            if (user.Rating >= minRate)
                            {
                                user.Jobs.Add(job);
                                job.User = user;
                            }
                        }
                    }
                    return Ok();
                }
                else
                    return BadRequest("There is no employee in department!");
            }
            else
                return BadRequest("There is no users");
        }


        // GET: api/Jobs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Job>>> GetJobs()
        {
            return await _context.Jobs.ToListAsync();
        }

        // GET: api/Jobs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Job>> GetJob(Guid id)
        {
            var job = await _context.Jobs.FindAsync(id);

            if (job == null)
            {
                return NotFound();
            }

            return job;
        }

        // PUT: api/Jobs/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutJob(Guid id, Job job)
        {
            if (id != job.Id)
            {
                return BadRequest();
            }

            _context.Entry(job).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!JobExists(id))
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

        // POST: api/Jobs
        [HttpPost]
        public async Task<ActionResult<Job>> PostJob(Job job)
        {
            _context.Jobs.Add(job);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetJob", new { id = job.Id }, job);
        }

        // DELETE: api/Jobs/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Job>> DeleteJob(Guid id)
        {
            var job = await _context.Jobs.FindAsync(id);
            if (job == null)
            {
                return NotFound();
            }

            _context.Jobs.Remove(job);
            await _context.SaveChangesAsync();

            return job;
        }

        private bool JobExists(Guid id)
        {
            return _context.Jobs.Any(e => e.Id == id);
        }
    }
}
