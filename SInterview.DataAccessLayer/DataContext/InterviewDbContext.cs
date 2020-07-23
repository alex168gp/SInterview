using Microsoft.EntityFrameworkCore;

namespace SInterview.DataAccess
{
    /// <summary>
    /// The context for an interview system
    /// </summary>
    public class InterviewDbContext : DbContext
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
            InterviewDbContextSeeder.Seed(modelBuilder);
        }
    }
}
