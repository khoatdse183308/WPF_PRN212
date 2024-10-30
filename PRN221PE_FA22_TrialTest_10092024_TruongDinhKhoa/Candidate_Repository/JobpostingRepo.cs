using Candidate_BusinessObjects;
using Candidate_DAOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candidate_Repository
{
    public class JobpostingRepo : IJobpostingRepo
    {
        public bool AddJobPosting(JobPosting jobPosting) => JobPostingDAO.Instance.AddJobPosting(jobPosting);

        public bool DeleteJobPosting(string jobPostingID) => JobPostingDAO.Instance.DeleteJobPosting(jobPostingID);

        public JobPosting GetJobPostingByID(string jobID) => JobPostingDAO.Instance.GetJobPostingByID(jobID);

        public List<JobPosting> GetJobPostings() => JobPostingDAO.Instance.GetJobPostings();

        public bool UpdateJobPosting(JobPosting jobPosting) => JobPostingDAO.Instance.UpdateJobPosting(jobPosting);
    }
}
