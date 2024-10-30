using Candidate_BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candidate_DAOs
{
    public class JobPostingDAO
    {
        //private CandidateManagementContext dbcontext;
        private GenericDAO<JobPosting> jobPostingDAO;
        private static JobPostingDAO instance;
        public JobPostingDAO()
        {
            jobPostingDAO = new GenericDAO<JobPosting> (new CandidateManagementContext());
        }
        public static JobPostingDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new JobPostingDAO();
                }
                return instance;
            }
            
        }

        //JobPosting hướng tới đối tượng ở dưới database
        public JobPosting GetJobPostingByID(string jobID)
        {
            return jobPostingDAO.GetById (jobID);
        }

        public List<JobPosting> GetJobPostings()
        {
            return jobPostingDAO.GetAll();
        }

        public bool AddJobPosting(JobPosting jobPosting)
        {
            bool isSuccess = false;
            JobPosting jobPosting1 = this.GetJobPostingByID(jobPosting.PostingId);
            try
            {
                if (jobPosting1 == null)
                {
                    jobPostingDAO.Add(jobPosting);
                    isSuccess = true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return isSuccess;
        }

        public bool DeleteJobPosting(string jobPostingID)
        {
            bool isSuccess = false;
            JobPosting jobPosting1 = this.GetJobPostingByID(jobPostingID);
            try
            {
                if (jobPosting1 != null)
                {
                    jobPostingDAO.Delete(jobPostingID);
                    isSuccess = true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return isSuccess;
        }

        public bool UpdateJobPosting(JobPosting jobPosting)
        {
            bool isSuccess = false;
            JobPosting jobPosting1 = this.GetJobPostingByID(jobPosting.PostingId);

            try
            {
                if (jobPosting1 != null)
                {
                    jobPostingDAO.Update(jobPosting);
                    isSuccess = true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return isSuccess;
        }

    }
}
