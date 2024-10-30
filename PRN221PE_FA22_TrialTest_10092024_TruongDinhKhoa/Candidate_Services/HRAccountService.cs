using Candidate_BusinessObjects;
using Candidate_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candidate_Services
{
    public class HRAccountService : IHRAccountService
    {
        private IHRAccountRepo iAccountRepo;

        public HRAccountService()
        {
            iAccountRepo = new HRAccountRepo();
        }

        public List<Hraccount> GetHraccount() => iAccountRepo.GetHraccount();

        public Hraccount GetHraccountByEmail(string email) => iAccountRepo.GetHraccountByEmail(email);
    }
}
