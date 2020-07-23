using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SInterview.DataAccess
{
    /// <summary>
    /// Dates on which employees can attend interviews
    /// </summary>
    public class EmployeeAvailableDates
    {
        [Key]
        public int DateId { get; set; }

        /// <summary>
        /// Date, when employee can attend an interview
        /// </summary>
        public DateTime AvailabelDate { get; set; }

        /// <summary>
        /// Which employee should be available for an interview on the giving <see cref="AvailabelDate"/>
        /// </summary>
        public int EmployeeId { get; set; }

        /// <summary>
        /// Which employee should be available for an interview on the giving <see cref="AvailabelDate"/>
        /// </summary>
        public Employee Employee { get; set; }
    }
}
