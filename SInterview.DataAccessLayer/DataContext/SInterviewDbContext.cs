using Microsoft.EntityFrameworkCore;

namespace SInterview.DataAccessLayer
{
    /// <summary>
    /// The context for an interview system
    /// </summary>
    public class SInterviewDbContext : DbContext
    {

        #region Tables

        public DbSet<Candidate> Candidates { get; set; }
        public DbSet<Interview> Interviews { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmployeeInterviews> EmployeeInterviews { get; set; }
        public DbSet<EmployeeAvailableDates> EmployeeAvailableDates { get; set; }

        #endregion

        // TODO: hide connection string somewhere
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseNpgsql("Host = localhost; " +
                                                                                                                  "Port = 5432; " +
                                                                                                                  "Database = SInterview; " +
                                                                                                                  "Username = postgres; " +
                                                                                                                  "Password = admin")
                                                                                                       // Extension method from EFCore.NamingConventions plugin
                                                                                                       // https://github.com/efcore/EFCore.NamingConventions
                                                                                                       .UseSnakeCaseNamingConvention();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Adding composite key for EmployeeInterviews
            modelBuilder.Entity<EmployeeInterviews>()
                .HasKey(ei => new { ei.InterviewId, ei.EmployeeId });

            #region Creating Relations

            modelBuilder.Entity<EmployeeInterviews>()
                .HasOne(ei => ei.Interview)
                .WithMany(i => i.EmployeeInterviews);

            modelBuilder.Entity<EmployeeInterviews>()
                .HasOne(ei => ei.Employee)
                .WithMany(e => e.EmployeeInterviews);

            #endregion

            // Seeding data
            SInterviewDbContextSeeder.Seed(modelBuilder);

            #region Setup Auto Increment For Non-Seed Entries

            // This means when an entry will be added to database for the first time,
            // and if ID not specified, ID will start from 100
            // All next entries will increment ID by 1

            modelBuilder.Entity<Employee>()
                .Property(e => e.EmployeeId)
                .HasIdentityOptions(startValue: 100);

            modelBuilder.Entity<Candidate>()
                .Property(c => c.CandidateId)
                .HasIdentityOptions(startValue: 100);

            modelBuilder.Entity<Interview>()
                .Property(e => e.InterviewId)
                .HasIdentityOptions(startValue: 100);

            modelBuilder.Entity<EmployeeAvailableDates>()
                .Property(c => c.DateId)
                .HasIdentityOptions(startValue: 100); 

            #endregion
        }
    }
}
