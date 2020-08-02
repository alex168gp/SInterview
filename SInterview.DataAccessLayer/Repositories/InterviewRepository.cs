using System;
using System.Collections.Generic;
using System.Linq;

namespace SInterview.DataAccessLayer
{
    public class InterviewRepository : BaseRepository<Interview>
    {
        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public InterviewRepository(SInterviewDbContext context) : base(context) { }

        #endregion

        /// <summary>
        /// Get a list of all the interviews on specified date
        /// </summary>
        /// <param name="date">Specified date where the interviews should have been held</param>
        /// <returns>A list of interviews on specified date</returns>
        public IEnumerable<Interview> GetAllInterviewsOnDate(DateTime date)
        {
            IEnumerable<Interview> interviewsOnDate = mEntities.Where(interview => interview.InterviewDate.Equals(date)).ToList();
            return interviewsOnDate;
        }
    }
}
