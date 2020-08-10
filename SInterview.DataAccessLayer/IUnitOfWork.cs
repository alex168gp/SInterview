using System;

namespace SInterview.DataAccessLayer
{
    public interface IUnitOfWork : IDisposable
    {
        IBaseRepository<Candidate> CandidateRepository { get; }

        IBaseRepository<Interview> InterviewRepository { get; }

        IBaseRepository<Employee> EmployeeRepository { get; }

        IBaseRepository<EmployeeAvailableDates> EmployeeAvailableDatesRepository { get; }

        IBaseRepository<EmployeeInterviews> EmployeeInterviewsRepository { get; }

        void SaveChanges();
    }
}
