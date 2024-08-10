using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using job_candidate_hub_API.Models;
using job_candidate_hub_API.Data;
using System.Threading.Tasks;

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

    }
}
