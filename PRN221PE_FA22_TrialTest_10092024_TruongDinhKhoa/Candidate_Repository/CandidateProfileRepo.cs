using Candidate_BusinessObjects;
using Candidate_DAOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candidate_Repository
{
    public class CandidateProfileRepo : ICandidateProfileRepo
    {
        public bool AddCandidateProfile(CandidateProfile candidateProfile) => CandidateProfileDAO.Instance.AddCandidateProfile(candidateProfile);
        public bool DeleteCandidateProfile(string profileID) => CandidateProfileDAO.Instance.DeleteCandidateProfile(profileID);
        public CandidateProfile GetCandidateProfileById(string id) => CandidateProfileDAO.Instance.GetCandidateProfileById(id);
        public List<CandidateProfile> GetCandidateProfiles() => CandidateProfileDAO.Instance.GetCandidateProfiles();

        public List<CandidateProfile> GetCanDidateProfilesByName(string name) => CandidateProfileDAO.Instance.GetCanDidateProfilesByName(name);

        public bool UpdateCandidateProfile(CandidateProfile candidate) => CandidateProfileDAO.Instance.UpdateCandidateProfile( candidate);
    }
}
