using System;

namespace SInterview.DataAccessLayer
{
    public interface IUnitOfWork : IDisposable
    {
        CandidateRepository CandidateRepository { get; }

        InterviewRepository InterviewRepository { get; }

        IBaseRepository<Employee> EmployeeRepository { get; }

        IBaseRepository<EmployeeAvailableDates> EmployeeAvailableDatesRepository { get; }

        IBaseRepository<EmployeeInterviews> EmployeeInterviewsRepository { get; }

        void SaveChanges();
    }
}
