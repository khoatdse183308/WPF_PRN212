using Candidate_BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candidate_DAOs
{
    public class HRAccountDAO
    {
        //private CandidateManagementContext dbContext;
        private GenericDAO<Hraccount> hrAccountDAO;
        private static HRAccountDAO instance = null;

        public static HRAccountDAO Instance
        {
            // Singleton Pattern Design
            get
            {
                if (instance == null)
                {
                    instance = new HRAccountDAO();
                }
                return instance;
            }
        }

        public HRAccountDAO()
        {
            hrAccountDAO = new GenericDAO<Hraccount> (new CandidateManagementContext());
        }

        public Hraccount GetHraccountByEmail(string email)
        {
            // SingleOrDefault: trả về 1 dòng hoặc null
            //m=>m toán tử lamda, query đc trên đối tượng
            return hrAccountDAO.GetById(email);
        }

        public List<Hraccount> GetHraccounts() 
        {
            return hrAccountDAO.GetAll();
        }
    }
}
