using Candidate_BusinessObjects;
using Candidate_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candidate_Services
{
    public class JobpostingService : IJobpostingService
    {
        private readonly IJobpostingRepo iJobpostingRepo;
        public JobpostingService()
        {
            iJobpostingRepo = new JobpostingRepo(); 
        }

        public bool AddJobPosting(JobPosting jobPosting) => iJobpostingRepo.AddJobPosting(jobPosting);

        public bool DeleteJobPosting(string jobPostingID) => iJobpostingRepo.DeleteJobPosting(jobPostingID);

        public JobPosting GetJobPostingByID(string jobID) => iJobpostingRepo.GetJobPostingByID(jobID);

        public List<JobPosting> GetJobPostings() => iJobpostingRepo.GetJobPostings();

        public bool UpdateJobPosting(JobPosting jobPosting) => iJobpostingRepo.UpdateJobPosting(jobPosting);
    }
}
