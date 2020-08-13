using System;
using System.Collections.Generic;
using System.Linq;

namespace SInterview.DataAccessLayer
{
    public class InterviewRepository : BaseRepository<Interview>, IInterviewRepository
    {
        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public InterviewRepository(SInterviewDbContext context) : base(context) { }

        #endregion

        // TODO: Keep them separate or merge?
        /// <summary>
        /// Get a list of all the interviews on specified date
        /// </summary>
        /// <param name="date">Specified date where the interviews should have been held</param>
        /// <returns>A list of interviews on specified date</returns>
        public IEnumerable<Interview> GetAllInterviewsOnDate(DateTime date)
        {
            return mEntities.Where(interview => interview.InterviewDate.Value.Date == date.Date)
                            .ToList();
        }

        /// <summary>
        /// Get a list of all the interviews after specified date NOT including specified date
        /// </summary>
        /// <param name="date">Specified date after which a list of interviews will be made on condition their dates will be after specified date</param>
        /// <returns>A list of interviews after specified date</returns>
        public IEnumerable<Interview> GetAllIterviewsAfterDate(DateTime date)
        {
            return mEntities.Where(interview => interview.InterviewDate.Value.Date > date.Date)
                            .ToList();
        }
    }
}
