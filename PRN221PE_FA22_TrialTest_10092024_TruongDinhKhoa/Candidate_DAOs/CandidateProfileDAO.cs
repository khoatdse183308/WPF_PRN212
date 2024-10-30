using Candidate_BusinessObjects;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Candidate_DAOs
{
    public class CandidateProfileDAO
    {
        private CandidateManagementContext context;
        private GenericDAO<CandidateProfile> candidateProfileDAO;
        private static CandidateProfileDAO instance;

        public CandidateProfileDAO()
        {
            candidateProfileDAO = new GenericDAO<CandidateProfile>(new CandidateManagementContext());
            context = new CandidateManagementContext();
        }

        public static CandidateProfileDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new CandidateProfileDAO();
                }
                return instance;
            }
        }
        public CandidateProfile GetCandidateProfileById(String id)
        {
            return candidateProfileDAO.GetById(id);
        }

        public List<CandidateProfile> GetCandidateProfiles()
        {
            return candidateProfileDAO.GetAll();
        }

        public bool AddCandidateProfile(CandidateProfile candidateProfile)
        {
            bool isSuccess = false;
            CandidateProfile candidate = this.GetCandidateProfileById(candidateProfile.CandidateId);
            try
            {
                if (candidate == null)
                {
                    //context.CandidateProfiles.Add(candidateProfile);
                    //context.SaveChanges();
                    candidateProfileDAO.Add(candidateProfile);
                    isSuccess = true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return isSuccess;
        }

        public bool DeleteCandidateProfile(String profileID)
        {
            bool isSuccess = false;
            CandidateProfile candidateProfile = this.GetCandidateProfileById(profileID);

            try
            {
                if (profileID != null)
                {
                    //context.CandidateProfiles.Remove(candidateProfile);
                    //context.SaveChanges();
                    candidateProfileDAO.Delete(profileID);
                    isSuccess = true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return isSuccess;
        }

        public bool UpdateCandidateProfile(CandidateProfile candidate)
        {
            if (GetCandidateProfileById(candidate.CandidateId) == null)
            {
                return false;
            }
            return candidateProfileDAO.Update(candidate);
        }
        public List<CandidateProfile> GetCanDidateProfilesByName(String name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                return candidateProfileDAO.GetAll();
            }

            return context.CandidateProfiles.Where(m => m.Fullname.Contains(name)).ToList();

        }
    }
}
