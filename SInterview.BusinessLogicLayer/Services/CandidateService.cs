using SInterview.DataAccessLayer;
using System.Collections.Generic;
using System.Linq;

namespace SInterview.BusinessLogicLayer.Services
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

        public IEnumerable<Candidate> GetCandidates() => mUnitOfWork.CandidateRepository.GetAll();

        public IEnumerable<Candidate> GetAllCandidatesWithPosition(string position) => mUnitOfWork.CandidateRepository.GetAllCandidatesWithPosition(position);
    }
}
