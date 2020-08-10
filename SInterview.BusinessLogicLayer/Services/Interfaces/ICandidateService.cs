using SInterview.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Text;

namespace SInterview.BusinessLogicLayer.Services
{
    interface ICandidateService
    {
        IEnumerable<Candidate> GetAllCandidatesWithPosition(string position);
    }
}
