﻿using Candidate_BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candidate_Repository
{
    public interface ICandidateProfileRepo
    {
        public CandidateProfile GetCandidateProfileById(String id);

        public List<CandidateProfile> GetCandidateProfiles();
       
        public bool AddCandidateProfile(CandidateProfile candidateProfile);

        public bool DeleteCandidateProfile(String profileID);

        public bool UpdateCandidateProfile(CandidateProfile candidateProfile);

        public List<CandidateProfile> GetCanDidateProfilesByName(String name);


    }
}
