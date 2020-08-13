using System.Collections.Generic;

namespace SInterview.DataAccessLayer
{
    public interface ICandidateRepository : IBaseRepository<Candidate>
    {
        IEnumerable<Candidate> GetAllCandidatesWithPosition(string position);
    }
}