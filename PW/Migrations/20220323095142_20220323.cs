using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PW.Migrations
{
    public partial class _20220323 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "PW");

            migrationBuilder.CreateTable(
                name: "CourseCategory",
                schema: "PW",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    ConcurrencyToken = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedByUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedByUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedByClient = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdatedByUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateByUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UpdatedByClient = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseCategory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Grade",
                schema: "PW",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Level = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Details = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    ConcurrencyToken = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedByUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedByUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedByClient = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdatedByUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateByUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UpdatedByClient = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grade", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Parent",
                schema: "PW",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Mobile = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Password = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DateOfBirth = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    ConcurrencyToken = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastLogInDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastLogInIp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedByUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedByUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedByClient = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdatedByUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateByUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UpdatedByClient = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parent", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                schema: "PW",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Password = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    EncodedPassword = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    ConcurrencyToken = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedByUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedByUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedByClient = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdatedByUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateByUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UpdatedByClient = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Course",
                schema: "PW",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Details = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CourseStartDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    CourseEndEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    Fee = table.Column<double>(type: "float", nullable: false),
                    CourseCategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GradeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    ConcurrencyToken = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedByUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedByUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedByClient = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdatedByUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateByUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UpdatedByClient = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Course", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Course_CourseCategory_CourseCategoryId",
                        column: x => x.CourseCategoryId,
                        principalSchema: "PW",
                        principalTable: "CourseCategory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Course_Grade_GradeId",
                        column: x => x.GradeId,
                        principalSchema: "PW",
                        principalTable: "Grade",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Student",
                schema: "PW",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Mobile = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Password = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DateOfBirth = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    ParentId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    ConcurrencyToken = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastLogInDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastLogInIp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedByUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedByUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedByClient = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdatedByUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateByUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UpdatedByClient = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Student_Parent_ParentId",
                        column: x => x.ParentId,
                        principalSchema: "PW",
                        principalTable: "Parent",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CourseAttachments",
                schema: "PW",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    ImageType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ImagePath = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    EncodedData = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    CourseId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    ConcurrencyToken = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedByUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedByUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedByClient = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdatedByUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateByUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UpdatedByClient = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseAttachments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CourseAttachments_Course_CourseId",
                        column: x => x.CourseId,
                        principalSchema: "PW",
                        principalTable: "Course",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CourseStudent",
                schema: "PW",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CourseId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StudentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    ConcurrencyToken = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedByUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedByUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedByClient = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdatedByUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateByUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UpdatedByClient = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseStudent", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CourseStudent_Course_CourseId",
                        column: x => x.CourseId,
                        principalSchema: "PW",
                        principalTable: "Course",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CourseStudent_Student_StudentId",
                        column: x => x.StudentId,
                        principalSchema: "PW",
                        principalTable: "Student",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Course_CourseCategoryId",
                schema: "PW",
                table: "Course",
                column: "CourseCategoryId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Course_GradeId",
                schema: "PW",
                table: "Course",
                column: "GradeId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CourseAttachments_CourseId",
                schema: "PW",
                table: "CourseAttachments",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_CourseStudent_CourseId",
                schema: "PW",
                table: "CourseStudent",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_CourseStudent_StudentId",
                schema: "PW",
                table: "CourseStudent",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_Student_ParentId",
                schema: "PW",
                table: "Student",
                column: "ParentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CourseAttachments",
                schema: "PW");

            migrationBuilder.DropTable(
                name: "CourseStudent",
                schema: "PW");

            migrationBuilder.DropTable(
                name: "User",
                schema: "PW");

            migrationBuilder.DropTable(
                name: "Course",
                schema: "PW");

            migrationBuilder.DropTable(
                name: "Student",
                schema: "PW");

            migrationBuilder.DropTable(
                name: "CourseCategory",
                schema: "PW");

            migrationBuilder.DropTable(
                name: "Grade",
                schema: "PW");

            migrationBuilder.DropTable(
                name: "Parent",
                schema: "PW");
        }
    }
}
