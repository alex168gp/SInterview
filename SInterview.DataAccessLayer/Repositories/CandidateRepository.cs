using System.Collections.Generic;
using System.Linq;

namespace SInterview.DataAccessLayer
{
    public class CandidateRepository : BaseRepository<Candidate>, ICandidateRepository
    {
        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="context"></param>
        public CandidateRepository(SInterviewDbContext context) : base(context) { }

        #endregion

        /// <summary>
        /// Get a list of all candidates with specified position
        /// </summary>
        /// <param name="position">A position of <see cref="Candidate"/></param>
        /// <returns>All employees with specified position</returns>
        public IEnumerable<Candidate> GetAllCandidatesWithPosition (string position)
        {
            return mEntities.Where(cand => cand.Position.Equals(position));
        }
    }
}
