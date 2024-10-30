using Candidate_BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candidate_Services
{
    public interface IJobpostingService
    {
        public JobPosting GetJobPostingByID(string jobID);

        public List<JobPosting> GetJobPostings();

        public bool AddJobPosting(JobPosting jobPosting);

        public bool DeleteJobPosting(string jobPostingID);

        public bool UpdateJobPosting(JobPosting jobPosting);
    }
}
