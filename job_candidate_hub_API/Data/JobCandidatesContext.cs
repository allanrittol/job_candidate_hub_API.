using Microsoft.EntityFrameworkCore;
using job_candidate_hub_API.Models;

namespace job_candidate_hub_API.Data
{
    public class JobCandidatesContext : DbContext
    {
        public JobCandidatesContext(DbContextOptions<JobCandidatesContext> options) : base(options) { }
        public DbSet<job_candidate> Candidates { get; set; }
    }
}
