using SInterview.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Text;

namespace SInterview.BusinessLogicLayer
{
    public interface ICandidateService
    {
        IEnumerable<Candidate> GetAllCandidatesWithPosition(string position);
    }
}
