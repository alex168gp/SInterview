using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SInterview.DataAccess
{
    /// <summary>
    /// Information about candidates
    /// </summary>
    public class Candidate
    {
        [Key]
        public int CandidateId { get; set; }

        /// <summary>
        /// The name of a candidate
        /// </summary>
        [Required]
        public string Name { get; set; }

        /// <summary>
        /// On what position candidate wants to apply
        /// </summary>
        public string Position { get; set; }

        /// <summary>
        /// Contact email with the candidate
        /// </summary>
        [EmailAddress]
        public string Email { get; set; }

        /// <summary>
        /// Interviews that candidate had or will have in the company
        /// </summary>
        public ICollection<Interview> Interviews { get; set; }
    }
}
