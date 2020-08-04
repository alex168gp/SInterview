﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using SInterview.DataAccessLayer;

namespace SInterview.DataAccessLayer.Migrations
{
    [DbContext(typeof(SInterviewDbContext))]
    partial class InterviewDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("SInterview.DataAccessLayer.Candidate", b =>
                {
                    b.Property<int>("CandidateId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("candidate_id")
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:IdentitySequenceOptions", "'100', '1', '', '', 'False', '1'")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Email")
                        .HasColumnName("email")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("name")
                        .HasColumnType("text");

                    b.Property<string>("Position")
                        .HasColumnName("position")
                        .HasColumnType("text");

                    b.HasKey("CandidateId")
                        .HasName("pk_candidates");

                    b.ToTable("candidates");

                    b.HasData(
                        new
                        {
                            CandidateId = 1,
                            Name = "Tom",
                            Position = "Trainee"
                        },
                        new
                        {
                            CandidateId = 2,
                            Name = "Mick",
                            Position = "Mid"
                        },
                        new
                        {
                            CandidateId = 3,
                            Name = "Linda",
                            Position = "Trainee"
                        },
                        new
                        {
                            CandidateId = 4,
                            Name = "Perry",
                            Position = "Mid"
                        },
                        new
                        {
                            CandidateId = 5,
                            Name = "Tom",
                            Position = "Junior"
                        });
                });

            modelBuilder.Entity("SInterview.DataAccessLayer.Employee", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("employee_id")
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:IdentitySequenceOptions", "'100', '1', '', '', 'False', '1'")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("name")
                        .HasColumnType("text");

                    b.Property<string>("Position")
                        .IsRequired()
                        .HasColumnName("position")
                        .HasColumnType("text");

                    b.HasKey("EmployeeId")
                        .HasName("pk_employees");

                    b.ToTable("employees");

                    b.HasData(
                        new
                        {
                            EmployeeId = 1,
                            Name = "Rick",
                            Position = "Head"
                        },
                        new
                        {
                            EmployeeId = 2,
                            Name = "Mike",
                            Position = "Mid"
                        },
                        new
                        {
                            EmployeeId = 3,
                            Name = "Sandy",
                            Position = "Senior"
                        },
                        new
                        {
                            EmployeeId = 4,
                            Name = "Tom",
                            Position = "Mid"
                        });
                });

            modelBuilder.Entity("SInterview.DataAccessLayer.EmployeeAvailableDates", b =>
                {
                    b.Property<int>("DateId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("date_id")
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:IdentitySequenceOptions", "'100', '1', '', '', 'False', '1'")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("AvailabelDate")
                        .HasColumnName("availabel_date")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("EmployeeId")
                        .HasColumnName("employee_id")
                        .HasColumnType("integer");

                    b.HasKey("DateId")
                        .HasName("pk_employee_available_dates");

                    b.HasIndex("EmployeeId")
                        .HasName("ix_employee_available_dates_employee_id");

                    b.ToTable("employee_available_dates");

                    b.HasData(
                        new
                        {
                            DateId = 1,
                            AvailabelDate = new DateTime(2019, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EmployeeId = 1
                        },
                        new
                        {
                            DateId = 2,
                            AvailabelDate = new DateTime(2020, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EmployeeId = 1
                        },
                        new
                        {
                            DateId = 3,
                            AvailabelDate = new DateTime(2020, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EmployeeId = 2
                        },
                        new
                        {
                            DateId = 4,
                            AvailabelDate = new DateTime(2020, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EmployeeId = 1
                        },
                        new
                        {
                            DateId = 5,
                            AvailabelDate = new DateTime(2020, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EmployeeId = 3
                        },
                        new
                        {
                            DateId = 6,
                            AvailabelDate = new DateTime(2020, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EmployeeId = 4
                        });
                });

            modelBuilder.Entity("SInterview.DataAccessLayer.EmployeeInterviews", b =>
                {
                    b.Property<int>("InterviewId")
                        .HasColumnName("interview_id")
                        .HasColumnType("integer");

                    b.Property<int>("EmployeeId")
                        .HasColumnName("employee_id")
                        .HasColumnType("integer");

                    b.Property<string>("EvaluationDetails")
                        .HasColumnName("evaluation_details")
                        .HasColumnType("text");

                    b.Property<bool?>("EvaluationIsPositive")
                        .HasColumnName("evaluation_is_positive")
                        .HasColumnType("boolean");

                    b.HasKey("InterviewId", "EmployeeId")
                        .HasName("pk_employee_interviews");

                    b.HasIndex("EmployeeId")
                        .HasName("ix_employee_interviews_employee_id");

                    b.ToTable("employee_interviews");

                    b.HasData(
                        new
                        {
                            InterviewId = 1,
                            EmployeeId = 1,
                            EvaluationDetails = "Decent",
                            EvaluationIsPositive = true
                        },
                        new
                        {
                            InterviewId = 2,
                            EmployeeId = 1,
                            EvaluationDetails = "Answered all my questions without any problem. Worked with everything we use on our project",
                            EvaluationIsPositive = true
                        },
                        new
                        {
                            InterviewId = 2,
                            EmployeeId = 3,
                            EvaluationDetails = "Pretty good",
                            EvaluationIsPositive = true
                        },
                        new
                        {
                            InterviewId = 1,
                            EmployeeId = 2,
                            EvaluationDetails = "No questions were answered, has no ",
                            EvaluationIsPositive = false
                        });
                });

            modelBuilder.Entity("SInterview.DataAccessLayer.Interview", b =>
                {
                    b.Property<int>("InterviewId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("interview_id")
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:IdentitySequenceOptions", "'100', '1', '', '', 'False', '1'")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("CandidateId")
                        .HasColumnName("candidate_id")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("InterviewDate")
                        .HasColumnName("interview_date")
                        .HasColumnType("date");

                    b.Property<TimeSpan?>("InterviewEnd")
                        .HasColumnName("interview_end")
                        .HasColumnType("time");

                    b.Property<TimeSpan?>("InterviewStart")
                        .HasColumnName("interview_start")
                        .HasColumnType("time");

                    b.Property<string>("InviteURL")
                        .HasColumnName("invite_url")
                        .HasColumnType("text");

                    b.Property<bool>("IsOffline")
                        .HasColumnName("is_offline")
                        .HasColumnType("boolean");

                    b.Property<int?>("RoomId")
                        .HasColumnName("room_id")
                        .HasColumnType("integer");

                    b.HasKey("InterviewId")
                        .HasName("pk_interviews");

                    b.HasIndex("CandidateId")
                        .HasName("ix_interviews_candidate_id");

                    b.ToTable("interviews");

                    b.HasData(
                        new
                        {
                            InterviewId = 1,
                            CandidateId = 1,
                            InterviewDate = new DateTime(2019, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            InterviewEnd = new TimeSpan(1, 1, 0, 0, 0),
                            InterviewStart = new TimeSpan(1, 0, 0, 0, 0),
                            IsOffline = true,
                            RoomId = 1
                        },
                        new
                        {
                            InterviewId = 2,
                            CandidateId = 2,
                            InterviewDate = new DateTime(2020, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            InterviewEnd = new TimeSpan(0, 13, 0, 0, 0),
                            InterviewStart = new TimeSpan(0, 12, 0, 0, 0),
                            IsOffline = true,
                            RoomId = 1
                        },
                        new
                        {
                            InterviewId = 3,
                            CandidateId = 3,
                            InterviewDate = new DateTime(2020, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            InterviewEnd = new TimeSpan(0, 14, 30, 0, 0),
                            InterviewStart = new TimeSpan(0, 13, 30, 0, 0),
                            IsOffline = true,
                            RoomId = 1
                        },
                        new
                        {
                            InterviewId = 4,
                            CandidateId = 4,
                            InterviewDate = new DateTime(2020, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            InterviewEnd = new TimeSpan(0, 13, 0, 0, 0),
                            InterviewStart = new TimeSpan(0, 12, 0, 0, 0),
                            IsOffline = true,
                            RoomId = 2
                        },
                        new
                        {
                            InterviewId = 5,
                            CandidateId = 5,
                            InterviewDate = new DateTime(2020, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            InterviewEnd = new TimeSpan(0, 13, 30, 0, 0),
                            InterviewStart = new TimeSpan(0, 13, 30, 0, 0),
                            IsOffline = true,
                            RoomId = 2
                        },
                        new
                        {
                            InterviewId = 6,
                            CandidateId = 2,
                            IsOffline = false
                        },
                        new
                        {
                            InterviewId = 7,
                            CandidateId = 4,
                            IsOffline = false
                        },
                        new
                        {
                            InterviewId = 8,
                            CandidateId = 5,
                            IsOffline = false
                        });
                });

            modelBuilder.Entity("SInterview.DataAccessLayer.EmployeeAvailableDates", b =>
                {
                    b.HasOne("SInterview.DataAccessLayer.Employee", "Employee")
                        .WithMany("AvailableDates")
                        .HasForeignKey("EmployeeId")
                        .HasConstraintName("fk_employee_available_dates_employees_employee_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SInterview.DataAccessLayer.EmployeeInterviews", b =>
                {
                    b.HasOne("SInterview.DataAccessLayer.Employee", "Employee")
                        .WithMany("EmployeeInterviews")
                        .HasForeignKey("EmployeeId")
                        .HasConstraintName("fk_employee_interviews_employees_employee_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SInterview.DataAccessLayer.Interview", "Interview")
                        .WithMany("EmployeeInterviews")
                        .HasForeignKey("InterviewId")
                        .HasConstraintName("fk_employee_interviews_interviews_interview_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SInterview.DataAccessLayer.Interview", b =>
                {
                    b.HasOne("SInterview.DataAccessLayer.Candidate", "Candidate")
                        .WithMany("Interviews")
                        .HasForeignKey("CandidateId")
                        .HasConstraintName("fk_interviews_candidates_candidate_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
