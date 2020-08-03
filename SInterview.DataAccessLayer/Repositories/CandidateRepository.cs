using System.Collections.Generic;
using System.Linq;

namespace SInterview.DataAccessLayer
{
    public class CandidateRepository : BaseRepository<Candidate>
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
            /*
            // TODO: Add a way to pass object, then cast it to a type of Employee.Position and search for matches in database
            // something like object position -> (typeof(Candidate.Position)) position, then use it for search
            if (position != null)
            {
                // Get employee as type
                var typeCandidate = new Candidate().GetType();

                // Get property info of a Candidate.Position property
                var propertyPosition = typeCandidate.GetProperty("Position");

                // Convert position to type of the Candidate.Position property
                // we get object(typeof(Candidate.Position)), not typeof(Candidate.Position)
                // it could be casted to typeof(Candidate.Position), but only manually
                var positionWithProperType = Convert.ChangeType(position, propertyPosition.PropertyType);

                // this will never work since type don't match
                // dynamic can't be used too
                var candidatesByPosition = mEntities.Where(cand => cand.Position.Equals(positionWithProperType)).ToList();
            }
            */

            /*
            // Another option. We can expect that position object will be identifier: most likely if type string will be changed,
            // it will be enum, or PositionID (type int), or Position type, and we can check what we have in object position and cast it
            if (position is string)
            {
                string posStr = (string)position;
                candidatesByPosition = mEntities.Where(cand => cand.Position.Equals(posStr)).ToList();
            }
            else if (position is int)
            {
                int posInt = (int)position;
                candidatesByPosition = mEntities.Where(cand => cand.Position.Equals(posInt)).ToList();
            }
            */
            IEnumerable<Candidate> candidatesByPosition = mEntities.Where(cand => cand.Position.Equals(position))
                                                                   .ToList();
            return candidatesByPosition;
        }
    }
}
