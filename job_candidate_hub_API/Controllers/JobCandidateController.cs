using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using job_candidate_hub_API.Models;
using job_candidate_hub_API.Data;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace job_candidate_hub_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobCandidateController : ControllerBase
    {
        private readonly JobCandidatesContext _context;
        public JobCandidateController(JobCandidatesContext context)
        {
            _context = context;
        }
        [HttpPost]
        public async Task<IActionResult> CreateEdit([FromBody] job_candidate candidate)
        {
            if (string.IsNullOrEmpty(candidate.Email))
            {
                return BadRequest("Email is required.");
            }
                var existingCandidate = await _context.Candidates
                .FirstOrDefaultAsync(c => c.Email == candidate.Email);

            if (existingCandidate != null)
            {
                //update existing candidate
                existingCandidate.FirstName = candidate.FirstName;
                existingCandidate.LastName = candidate.LastName;
                existingCandidate.PhoneNumber = candidate.PhoneNumber;
                existingCandidate.TimeAvailable = candidate.TimeAvailable;
                existingCandidate.Email = candidate.Email;
                existingCandidate.LinkedInURL = candidate.LinkedInURL;
                existingCandidate.GitHubProfileURL = candidate.GitHubProfileURL;
                _context.Candidates.Add(existingCandidate);
            }
            else
            {
                //Create new candidate
                _context.Candidates.Add(candidate);
            }
            await _context.SaveChangesAsync();
            return Ok();
            
        }
    }
}
