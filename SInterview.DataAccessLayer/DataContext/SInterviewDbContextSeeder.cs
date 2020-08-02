using Microsoft.EntityFrameworkCore;

namespace SInterview.DataAccessLayer
{
    /// <summary>
    /// Populate the database with <see cref="SInterviewDbContext"/>
    /// </summary>
    public class SInterviewDbContextSeeder
    {
        /// <summary>
        /// Populate the SInterview database
        /// </summary>
        /// <param name="modelBuilder"></param>
        public static void Seed(ModelBuilder modelBuilder)
        {
            // TODO: need more meaningful seed data

            #region Employees
            
            modelBuilder.Entity<Employee>().HasData(
                new Employee { EmployeeId = 1, Name = "Rick", Position = "Head" },
                new Employee { EmployeeId = 2, Name = "Mike", Position = "Mid" },
                new Employee { EmployeeId = 3, Name = "Sandy", Position = "Senior" },
                new Employee { EmployeeId = 4, Name = "Tom", Position = "Mid" }
                );
            
            #endregion

            #region Candidates

            modelBuilder.Entity<Candidate>().HasData(
                new { CandidateId = 1, Name = "Tom", Position = "Trainee" },
                new { CandidateId = 2, Name = "Mick", Position = "Mid" },
                new { CandidateId = 3, Name = "Linda", Position = "Trainee" },
                new { CandidateId = 4, Name = "Perry", Position = "Mid" },
                new { CandidateId = 5, Name = "Tom", Position = "Junior" }
                );

            #endregion

            #region Interviews

            modelBuilder.Entity<Interview>().HasData(
                new Interview { InterviewId = 1, InterviewDate = new System.DateTime(2019, 5, 5), InterviewStart = new System.TimeSpan(24, 0, 0), InterviewEnd = new System.TimeSpan(25, 0, 0), IsOffline = true, RoomId = 1, CandidateId = 1 },
                new Interview { InterviewId = 2, InterviewDate = new System.DateTime(2020, 9, 10), InterviewStart = new System.TimeSpan(12, 0, 0), InterviewEnd = new System.TimeSpan(13, 0, 0), IsOffline = true, RoomId = 1, CandidateId = 2 },
                new Interview { InterviewId = 3, InterviewDate = new System.DateTime(2020, 9, 10), InterviewStart = new System.TimeSpan(13, 30, 0), InterviewEnd = new System.TimeSpan(14, 30, 0), IsOffline = true, RoomId = 1, CandidateId = 3 },
                new Interview { InterviewId = 4, InterviewDate = new System.DateTime(2020, 9, 14), InterviewStart = new System.TimeSpan(12, 0, 0), InterviewEnd = new System.TimeSpan(13, 0, 0), IsOffline = true, RoomId = 2, CandidateId = 4 },
                new Interview { InterviewId = 5, InterviewDate = new System.DateTime(2020, 9, 14), InterviewStart = new System.TimeSpan(13, 30, 0), InterviewEnd = new System.TimeSpan(13, 30, 0), IsOffline = true, RoomId = 2, CandidateId = 5 },
                new Interview { InterviewId = 6, IsOffline = false, CandidateId = 2 },
                new Interview { InterviewId = 7, IsOffline = false, CandidateId = 4 },
                new Interview { InterviewId = 8, IsOffline = false, CandidateId = 5 }
                );

            #endregion

            #region EmployeeAvailableDates

            modelBuilder.Entity<EmployeeAvailableDates>().HasData(
                new EmployeeAvailableDates { DateId = 1, EmployeeId = 1, AvailabelDate = new System.DateTime(2019, 5, 5) },
                new EmployeeAvailableDates { DateId = 2, EmployeeId = 1, AvailabelDate = new System.DateTime(2020, 9, 10) },
                new EmployeeAvailableDates { DateId = 3, EmployeeId = 2, AvailabelDate = new System.DateTime(2020, 9, 10) },
                new EmployeeAvailableDates { DateId = 4, EmployeeId = 1, AvailabelDate = new System.DateTime(2020, 9, 12) },
                new EmployeeAvailableDates { DateId = 5, EmployeeId = 3, AvailabelDate = new System.DateTime(2020, 9, 12) },
                new EmployeeAvailableDates { DateId = 6, EmployeeId = 4, AvailabelDate = new System.DateTime(2020, 9, 12) }
                );

            #endregion

            #region EmployeeInterviews

            modelBuilder.Entity<EmployeeInterviews>().HasData(
                new EmployeeInterviews { EmployeeId = 1, EvaluationIsPositive = true, EvaluationDetails = "Decent", InterviewId = 1 },
                new EmployeeInterviews { EmployeeId = 1, EvaluationIsPositive = true, EvaluationDetails = "Answered all my questions without any problem. Worked with everything we use on our project", InterviewId = 2 },
                new EmployeeInterviews { EmployeeId = 3, EvaluationIsPositive = true, EvaluationDetails = "Pretty good", InterviewId = 2 },
                new EmployeeInterviews { EmployeeId = 2, EvaluationIsPositive = false, EvaluationDetails = "No questions were answered, has no ", InterviewId = 1 }
                ); 

            #endregion

        }
    }
}
