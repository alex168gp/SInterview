using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace SInterview.DataAccessLayer
{
    /// <summary>
    /// 
    /// </summary>
    public class UnitOfWork : IUnitOfWork
    {
        #region Private Members

        private readonly SInterviewDbContext mDbContext;

        private IBaseRepository<Candidate> mCandidateRepository;

        private IBaseRepository<Interview> mInterviewRepository;

        private IBaseRepository<Employee> mEmployeeRepository;

        private IBaseRepository<EmployeeAvailableDates> mEmployeeAvailableDatesRepository;

        private IBaseRepository<EmployeeInterviews> mEmployeeInterviewsRepository;

        #endregion

        #region Public Properties

        public IBaseRepository<Candidate> CandidateRepository => mCandidateRepository ?? new CandidateRepository(mDbContext);

        public IBaseRepository<Interview> InterviewRepository => mInterviewRepository ?? new InterviewRepository(mDbContext);

        public IBaseRepository<Employee> EmployeeRepository => mEmployeeRepository ?? new BaseRepository<Employee>(mDbContext);

        public IBaseRepository<EmployeeAvailableDates> EmployeeAvailableDatesRepository => mEmployeeAvailableDatesRepository ?? new BaseRepository<EmployeeAvailableDates>(mDbContext);

        public IBaseRepository<EmployeeInterviews> EmployeeInterviewsRepository => mEmployeeInterviewsRepository ?? new BaseRepository<EmployeeInterviews>(mDbContext);

        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="mDbContext"></param>
        public UnitOfWork(SInterviewDbContext mDbContext)
        {
            this.mDbContext = mDbContext;
        }

        #endregion

        #region Public Methods

        public void Dispose()
        {
            mDbContext.Dispose();
        } 

        public void SaveChanges()
        {
            mDbContext.SaveChanges();
        }

        #endregion
    }
}
