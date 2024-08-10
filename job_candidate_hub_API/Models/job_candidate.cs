namespace job_candidate_hub_API.Models
{
    public class job_candidate
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int PhoneNumber { get; set; }
        public string Email { get; set; }
        public DateTime TimeAvailable { get; set; }
        public string LinkedInURL { get; set; }
        public string GitHubProfileURL { get; set; }
        public string Comment { get; set; }
    }
}
