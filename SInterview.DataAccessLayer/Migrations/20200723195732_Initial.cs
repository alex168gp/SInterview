using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace SInterview.DataAccessLayer.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "candidates",
                columns: table => new
                {
                    candidate_id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(nullable: false),
                    position = table.Column<string>(nullable: true),
                    email = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_candidates", x => x.candidate_id);
                });

            migrationBuilder.CreateTable(
                name: "employees",
                columns: table => new
                {
                    employee_id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(nullable: false),
                    position = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_employees", x => x.employee_id);
                });

            migrationBuilder.CreateTable(
                name: "interviews",
                columns: table => new
                {
                    interview_id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    interview_date = table.Column<DateTime>(type: "date", nullable: true),
                    interview_start = table.Column<TimeSpan>(type: "time", nullable: true),
                    interview_end = table.Column<TimeSpan>(type: "time", nullable: true),
                    is_offline = table.Column<bool>(nullable: false),
                    room_id = table.Column<int>(nullable: true),
                    invite_url = table.Column<string>(nullable: true),
                    candidate_id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_interviews", x => x.interview_id);
                    table.ForeignKey(
                        name: "fk_interviews_candidates_candidate_id",
                        column: x => x.candidate_id,
                        principalTable: "candidates",
                        principalColumn: "candidate_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "employee_available_dates",
                columns: table => new
                {
                    date_id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    availabel_date = table.Column<DateTime>(nullable: false),
                    employee_id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_employee_available_dates", x => x.date_id);
                    table.ForeignKey(
                        name: "fk_employee_available_dates_employees_employee_id",
                        column: x => x.employee_id,
                        principalTable: "employees",
                        principalColumn: "employee_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "employee_interviews",
                columns: table => new
                {
                    interview_id = table.Column<int>(nullable: false),
                    employee_id = table.Column<int>(nullable: false),
                    evaluation_is_positive = table.Column<bool>(nullable: true),
                    evaluation_details = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_employee_interviews", x => new { x.interview_id, x.employee_id });
                    table.ForeignKey(
                        name: "fk_employee_interviews_employees_employee_id",
                        column: x => x.employee_id,
                        principalTable: "employees",
                        principalColumn: "employee_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_employee_interviews_interviews_interview_id",
                        column: x => x.interview_id,
                        principalTable: "interviews",
                        principalColumn: "interview_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "candidates",
                columns: new[] { "candidate_id", "email", "name", "position" },
                values: new object[,]
                {
                    { 1, null, "Tom", "Trainee" },
                    { 2, null, "Mick", "Mid" },
                    { 3, null, "Linda", "Trainee" },
                    { 4, null, "Perry", "Mid" },
                    { 5, null, "Tom", "Junior" }
                });

            migrationBuilder.InsertData(
                table: "employees",
                columns: new[] { "employee_id", "name", "position" },
                values: new object[,]
                {
                    { 1, "Rick", "Head" },
                    { 2, "Mike", "Mid" },
                    { 3, "Sandy", "Senior" },
                    { 4, "Tom", "Mid" }
                });

            migrationBuilder.InsertData(
                table: "employee_available_dates",
                columns: new[] { "date_id", "availabel_date", "employee_id" },
                values: new object[,]
                {
                    { 1, new DateTime(2019, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 2, new DateTime(2020, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 4, new DateTime(2020, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 3, new DateTime(2020, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 5, new DateTime(2020, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 6, new DateTime(2020, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 }
                });

            migrationBuilder.InsertData(
                table: "interviews",
                columns: new[] { "interview_id", "candidate_id", "interview_date", "interview_end", "interview_start", "invite_url", "is_offline", "room_id" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2019, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(1, 1, 0, 0, 0), new TimeSpan(1, 0, 0, 0, 0), null, true, 1 },
                    { 2, 2, new DateTime(2020, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 13, 0, 0, 0), new TimeSpan(0, 12, 0, 0, 0), null, true, 1 },
                    { 6, 2, null, null, null, null, false, null },
                    { 3, 3, new DateTime(2020, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 14, 30, 0, 0), new TimeSpan(0, 13, 30, 0, 0), null, true, 1 },
                    { 4, 4, new DateTime(2020, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 13, 0, 0, 0), new TimeSpan(0, 12, 0, 0, 0), null, true, 2 },
                    { 7, 4, null, null, null, null, false, null },
                    { 5, 5, new DateTime(2020, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 13, 30, 0, 0), new TimeSpan(0, 13, 30, 0, 0), null, true, 2 },
                    { 8, 5, null, null, null, null, false, null }
                });

            migrationBuilder.InsertData(
                table: "employee_interviews",
                columns: new[] { "interview_id", "employee_id", "evaluation_details", "evaluation_is_positive" },
                values: new object[,]
                {
                    { 1, 1, "Decent", true },
                    { 1, 2, "No questions were answered, has no ", false },
                    { 2, 1, "Answered all my questions without any problem. Worked with everything we use on our project", true },
                    { 2, 3, "Pretty good", true }
                });

            migrationBuilder.CreateIndex(
                name: "ix_employee_available_dates_employee_id",
                table: "employee_available_dates",
                column: "employee_id");

            migrationBuilder.CreateIndex(
                name: "ix_employee_interviews_employee_id",
                table: "employee_interviews",
                column: "employee_id");

            migrationBuilder.CreateIndex(
                name: "ix_interviews_candidate_id",
                table: "interviews",
                column: "candidate_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "employee_available_dates");

            migrationBuilder.DropTable(
                name: "employee_interviews");

            migrationBuilder.DropTable(
                name: "employees");

            migrationBuilder.DropTable(
                name: "interviews");

            migrationBuilder.DropTable(
                name: "candidates");
        }
    }
}
