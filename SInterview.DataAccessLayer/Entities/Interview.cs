using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SInterview.DataAccessLayer
{
    /// <summary>
    /// Details about interview 
    /// </summary>
    public class Interview
    {
        [Key]
        public int InterviewId { get; set; }

        /// <summary>
        /// The date of the interview
        /// </summary>
        [Column(TypeName = "date")]
        public DateTime? InterviewDate { get; set; }

        /// <summary>
        /// The time when an interview starts
        /// </summary>
        [Column(TypeName = "time")]
        public TimeSpan? InterviewStart { get; set; }

        /// <summary>
        /// The approximate time when the interview ends
        /// </summary>
        [Column(TypeName = "time")]
        public TimeSpan? InterviewEnd { get; set; }

        /// <summary>
        /// In what format the interview will be: off-line (in the company office or affiliated facilities)
        /// or on-line (through google meets/zoom/skype etc.)
        /// </summary>
        [Required]
        public bool IsOffline { get; set; }

        /// <summary>
        /// If <see cref="IsOffline"/> is true, the identifier for a room where the interview will be held
        /// </summary>
        public int? RoomId { get; set; }

        /// <summary>
        /// If <see cref="IsOffline"/> is false, the URL with the help of which candidate/employee can access interview on-line
        /// </summary>
        public string InviteURL { get; set; }

        /// <summary>
        /// The candidate that should be interviewed
        /// </summary>
        public int CandidateId { get; set; }

        /// <summary>
        /// The candidate that should be interviewed
        /// </summary>
        public Candidate Candidate { get; set; }

        public ICollection<EmployeeInterviews> EmployeeInterviews { get; set; }
    }
}
