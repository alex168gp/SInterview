using SInterview.DataAccessLayer;
using System;
using System.Collections.Generic;

namespace SInterview.BusinessLogicLayer
{
    public interface IInterviewService
    {
        IEnumerable<Interview> GetAllInterviewsOnDate(DateTime date);

        IEnumerable<Interview> GetAllIterviewsAfterDate(DateTime date);
    }
}
