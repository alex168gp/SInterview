using SInterview.DataAccessLayer;
using System;
using System.Collections.Generic;

namespace SInterview.BusinessLogicLayer.Services
{
    /// <summary>
    /// 
    /// </summary>
    public class InterviewService : IInterviewService
    {
        private readonly IUnitOfWork mUnitOfWork;

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
		public InterviewService(IUnitOfWork unitOfWork)
        {
            mUnitOfWork = unitOfWork;
        }

        #endregion

        public IEnumerable<Interview> GetAllInterviewsOnDate(DateTime date)
        {
            return mUnitOfWork.InterviewRepository.GetAllInterviewsOnDate(date);
        }

        public IEnumerable<Interview> GetAllIterviewsAfterDate(DateTime date)
        {
            return mUnitOfWork.InterviewRepository.GetAllIterviewsAfterDate(date);
        }
    }
}
