using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SInterview.DataAccess
{
    /// <summary>
    /// Brief information on an employee
    /// </summary>
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }

        /// <summary>
        /// The name of an employee
        /// </summary>
        [Required]
        public string Name { get; set; }

        /// <summary>
        /// The position on which employee is inside the company (not project)
        /// </summary>
        [Required]
        public string Position { get; set; }

        /// <summary>
        /// On what dates employee should be available for attending interview
        /// </summary>
        public ICollection<EmployeeAvailableDates> AvailableDates { get; set; }

        /// <summary>
        /// Interviews that were attended by this employee
        /// </summary>
        public ICollection<EmployeeInterviews> EmployeeInterviews { get; set; }
    }
}
