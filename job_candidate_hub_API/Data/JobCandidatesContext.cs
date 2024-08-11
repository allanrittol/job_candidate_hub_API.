using System;
using Microsoft.EntityFrameworkCore;
using job_candidate_hub_API.Models;

namespace job_candidate_hub_API.Data
{
    public class JobCandidatesContext : DbContext
    {
        public JobCandidatesContext(DbContextOptions<JobCandidatesContext> options) : base(options)
        {
        }
        public DbSet<job_candidate> Candidates { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var entity = modelBuilder.Entity<job_candidate>();
            modelBuilder.Entity<JobCandidatesContext>();
            {
                entity.HasKey(e => e.Email);
            }; 
        }

 
    }
}