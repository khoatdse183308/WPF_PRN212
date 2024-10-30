using Candidate_BusinessObjects;
using Candidate_DAOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candidate_Repository
{
    public interface IJobpostingRepo
    {
        public JobPosting GetJobPostingByID(string jobID);

        public List<JobPosting> GetJobPostings();

        public bool AddJobPosting(JobPosting jobPosting);

        public bool DeleteJobPosting(string jobPostingID);

        public bool UpdateJobPosting(JobPosting jobPosting);
    }
}
