using Candidate_BusinessObjects;
using Candidate_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candidate_Services
{
    public class CandidateProfileService : ICandidateProfileService
    {
        private ICandidateProfileRepo iCandidateProfileRepo;
        public CandidateProfileService()
        {
            iCandidateProfileRepo = new CandidateProfileRepo();
        }
        public bool AddCandidateProfile(CandidateProfile candidateProfile) => iCandidateProfileRepo.AddCandidateProfile(candidateProfile);

        public bool DeleteCandidateProfile(string profileID) => iCandidateProfileRepo.DeleteCandidateProfile(profileID);

        public CandidateProfile GetCandidateProfileById(string id) => iCandidateProfileRepo.GetCandidateProfileById(id);

        public List<CandidateProfile> GetCandidateProfiles() => iCandidateProfileRepo.GetCandidateProfiles();

        public List<CandidateProfile> GetCanDidateProfilesByName(string name) => iCandidateProfileRepo.GetCanDidateProfilesByName(name);

        public bool UpdateCandidateProfile(CandidateProfile candidate) => iCandidateProfileRepo.UpdateCandidateProfile( candidate);
    }
}
