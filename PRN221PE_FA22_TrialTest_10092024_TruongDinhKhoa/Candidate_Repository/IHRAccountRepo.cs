using Candidate_BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candidate_Repository
{
    public interface IHRAccountRepo
    {
        //Interface ko cho code vì nó chỉ define hàm;
        public Hraccount GetHraccountByEmail(string email);

        public List<Hraccount> GetHraccount();
    }
}
