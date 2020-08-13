using SInterview.DataAccessLayer;
using System.Collections.Generic;
using System.Linq;

namespace SInterview.BusinessLogicLayer
{
    /// <summary>
    /// 
    /// </summary>
    public class CandidateService : ICandidateService
    {
        private readonly IUnitOfWork mUnitOfWork;

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
		public CandidateService(IUnitOfWork unitOfWork)
        {
            mUnitOfWork = unitOfWork;
        }

        #endregion

        public IEnumerable<Candidate> GetAllCandidatesWithPosition(string position)
        {
            var unitOfWork = mUnitOfWork;
            var interviews = unitOfWork.InterviewRepository.GetAll().ToList();
            var candidates = unitOfWork.CandidateRepository.GetAll().ToList();
            var employeeInterviews = unitOfWork.EmployeeInterviewsRepository.GetAll().ToList();

            var qq = (from c in candidates
                      join i in interviews on c.CandidateId equals i.CandidateId
                      join ei in employeeInterviews on i.InterviewId equals ei.InterviewId
                      where c.CandidateId == 1
                      select new { c.Name, c.Position, i.InterviewDate, ei.EvaluationDetails })
                     .ToList();

            return candidates;
        }
    }
}
