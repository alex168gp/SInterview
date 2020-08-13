using System;
using System.Collections.Generic;
using System.Text;

namespace SInterview.DataAccessLayer
{
    public interface IInterviewRepository : IBaseRepository<Interview>
    {
        IEnumerable<Interview> GetAllInterviewsOnDate(DateTime date);

        IEnumerable<Interview> GetAllIterviewsAfterDate(DateTime date);
    }
}
