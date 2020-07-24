namespace SInterview.DataAccessLayer
{
    /// <summary>
    /// Employee feedback on how candidate passed the interview
    /// </summary>
    public class EmployeeInterviews
    {
        /// <summary>
        /// An interview where employee participated
        /// </summary>
        public int InterviewId { get; set; }

        /// <summary>
        /// An interview where employee participated
        /// </summary>
        public Interview Interview { get; set; }

        /// <summary>
        /// Employee that will participate in an interview
        /// </summary>
        public int EmployeeId { get; set; }

        /// <summary>
        /// Employee that will participate in an interview
        /// </summary>
        public Employee Employee { get; set; }

        /// <summary>
        /// General evaluation, was candidate good or not during interview
        /// </summary>
        public bool? EvaluationIsPositive { get; set; }

        /// <summary>
        /// Notes on why general evaluation was good or bad
        /// </summary>
        public string EvaluationDetails { get; set; }
    }
}
