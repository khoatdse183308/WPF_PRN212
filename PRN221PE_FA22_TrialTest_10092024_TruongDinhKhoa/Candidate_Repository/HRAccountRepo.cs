﻿using Candidate_BusinessObjects;
using Candidate_DAOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candidate_Repository
{
    public class HRAccountRepo : IHRAccountRepo
    {

        public Hraccount GetHraccountByEmail(string email)=>HRAccountDAO.Instance.GetHraccountByEmail(email);

        public List<Hraccount> GetHraccount() => HRAccountDAO.Instance.GetHraccounts();

    }
}
