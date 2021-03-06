﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Promact.Trappist.DomainModel.DbContext;
using Promact.Trappist.DomainModel.Enum;

namespace Promact.Trappist.Web.Migrations
{
    [DbContext(typeof(TrappistDbContext))]
    [Migration("20170816053431_AddedTestCaseResult")]
    partial class AddedTestCaseResult
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Promact.Trappist.DomainModel.Models.Category.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasMaxLength(150);

                    b.Property<DateTime>("CreatedDateTime");

                    b.Property<DateTime?>("UpdateDateTime");

                    b.HasKey("Id");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("Promact.Trappist.DomainModel.Models.Question.CodeSnippetQuestion", b =>
                {
                    b.Property<int>("Id");

                    b.Property<bool>("CheckCodeComplexity");

                    b.Property<bool>("CheckTimeComplexity");

                    b.Property<DateTime>("CreatedDateTime");

                    b.Property<bool>("RunBasicTestCase");

                    b.Property<bool>("RunCornerTestCase");

                    b.Property<bool>("RunNecessaryTestCase");

                    b.Property<DateTime?>("UpdateDateTime");

                    b.HasKey("Id");

                    b.ToTable("CodeSnippetQuestion");
                });

            modelBuilder.Entity("Promact.Trappist.DomainModel.Models.Question.CodeSnippetQuestionTestCases", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CodeSnippetQuestionId");

                    b.Property<DateTime>("CreatedDateTime");

                    b.Property<string>("TestCaseDescription");

                    b.Property<string>("TestCaseInput")
                        .IsRequired();

                    b.Property<double>("TestCaseMarks");

                    b.Property<string>("TestCaseOutput")
                        .IsRequired();

                    b.Property<string>("TestCaseTitle")
                        .IsRequired();

                    b.Property<int>("TestCaseType");

                    b.Property<DateTime?>("UpdateDateTime");

                    b.HasKey("Id");

                    b.HasIndex("CodeSnippetQuestionId");

                    b.ToTable("CodeSnippetQuestionTestCases");
                });

            modelBuilder.Entity("Promact.Trappist.DomainModel.Models.Question.CodingLanguage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedDateTime");

                    b.Property<string>("Language")
                        .IsRequired();

                    b.Property<DateTime?>("UpdateDateTime");

                    b.HasKey("Id");

                    b.ToTable("CodingLanguage");
                });

            modelBuilder.Entity("Promact.Trappist.DomainModel.Models.Question.Question", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CategoryID");

                    b.Property<string>("CreatedByUserId");

                    b.Property<DateTime>("CreatedDateTime");

                    b.Property<int>("DifficultyLevel");

                    b.Property<string>("QuestionDetail")
                        .IsRequired();

                    b.Property<int>("QuestionType");

                    b.Property<DateTime?>("UpdateDateTime");

                    b.Property<string>("UpdatedByUserId");

                    b.HasKey("Id");

                    b.HasIndex("CategoryID");

                    b.HasIndex("CreatedByUserId");

                    b.HasIndex("UpdatedByUserId");

                    b.ToTable("Question");
                });

            modelBuilder.Entity("Promact.Trappist.DomainModel.Models.Question.QuestionLanguageMapping", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedDateTime");

                    b.Property<int>("LanguageId");

                    b.Property<int>("QuestionId");

                    b.Property<DateTime?>("UpdateDateTime");

                    b.HasKey("Id");

                    b.HasIndex("LanguageId");

                    b.HasIndex("QuestionId");

                    b.ToTable("QuestionLanguageMapping");
                });

            modelBuilder.Entity("Promact.Trappist.DomainModel.Models.Question.SingleMultipleAnswerQuestion", b =>
                {
                    b.Property<int>("Id");

                    b.Property<DateTime>("CreatedDateTime");

                    b.Property<DateTime?>("UpdateDateTime");

                    b.HasKey("Id");

                    b.ToTable("SingleMultipleAnswerQuestion");
                });

            modelBuilder.Entity("Promact.Trappist.DomainModel.Models.Question.SingleMultipleAnswerQuestionOption", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedDateTime");

                    b.Property<bool>("IsAnswer");

                    b.Property<string>("Option")
                        .IsRequired();

                    b.Property<int>("SingleMultipleAnswerQuestionID");

                    b.Property<DateTime?>("UpdateDateTime");

                    b.HasKey("Id");

                    b.HasIndex("SingleMultipleAnswerQuestionID");

                    b.ToTable("SingleMultipleAnswerQuestionOption");
                });

            modelBuilder.Entity("Promact.Trappist.DomainModel.Models.Report.Report", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedDateTime");

                    b.Property<double>("Percentage");

                    b.Property<double>("Percentile");

                    b.Property<int>("TestAttendeeId");

                    b.Property<int>("TestStatus");

                    b.Property<int>("TimeTakenByAttendee");

                    b.Property<double>("TotalMarksScored");

                    b.Property<DateTime?>("UpdateDateTime");

                    b.HasKey("Id");

                    b.HasIndex("TestAttendeeId")
                        .IsUnique();

                    b.ToTable("Report");
                });

            modelBuilder.Entity("Promact.Trappist.DomainModel.Models.Test.Test", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AllowTestResume");

                    b.Property<int>("BrowserTolerance");

                    b.Property<decimal>("CorrectMarks");

                    b.Property<string>("CreatedByUserId");

                    b.Property<DateTime>("CreatedDateTime");

                    b.Property<int>("Duration");

                    b.Property<DateTime>("EndDate");

                    b.Property<decimal>("IncorrectMarks");

                    b.Property<bool>("IsLaunched");

                    b.Property<bool>("IsPaused");

                    b.Property<string>("Link");

                    b.Property<int>("OptionOrder");

                    b.Property<int>("QuestionOrder");

                    b.Property<DateTime>("StartDate");

                    b.Property<string>("TestName")
                        .IsRequired()
                        .HasMaxLength(150);

                    b.Property<DateTime?>("UpdateDateTime");

                    b.Property<string>("WarningMessage");

                    b.Property<int?>("WarningTime");

                    b.HasKey("Id");

                    b.HasIndex("CreatedByUserId");

                    b.ToTable("Test");
                });

            modelBuilder.Entity("Promact.Trappist.DomainModel.Models.Test.TestCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CategoryId");

                    b.Property<int>("TestId");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("TestId");

                    b.ToTable("TestCategory");
                });

            modelBuilder.Entity("Promact.Trappist.DomainModel.Models.Test.TestIpAddress", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedDateTime");

                    b.Property<string>("IpAddress");

                    b.Property<int>("TestId");

                    b.Property<DateTime?>("UpdateDateTime");

                    b.HasKey("Id");

                    b.HasIndex("TestId");

                    b.ToTable("TestIpAddresses");
                });

            modelBuilder.Entity("Promact.Trappist.DomainModel.Models.Test.TestQuestion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("QuestionId");

                    b.Property<int>("TestId");

                    b.HasKey("Id");

                    b.HasIndex("QuestionId");

                    b.HasIndex("TestId");

                    b.ToTable("TestQuestion");
                });

            modelBuilder.Entity("Promact.Trappist.DomainModel.Models.TestConduct.AttendeeAnswers", b =>
                {
                    b.Property<int>("Id");

                    b.Property<string>("Answers");

                    b.Property<DateTime>("CreatedDateTime");

                    b.Property<double>("TimeElapsed");

                    b.Property<DateTime?>("UpdateDateTime");

                    b.HasKey("Id");

                    b.ToTable("AttendeeAnswers");
                });

            modelBuilder.Entity("Promact.Trappist.DomainModel.Models.TestConduct.TestAnswers", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AnsweredCodeSnippet");

                    b.Property<int?>("AnsweredOption");

                    b.Property<DateTime>("CreatedDateTime");

                    b.Property<int>("TestConductId");

                    b.Property<DateTime?>("UpdateDateTime");

                    b.HasKey("Id");

                    b.HasIndex("TestConductId");

                    b.ToTable("TestAnswers");
                });

            modelBuilder.Entity("Promact.Trappist.DomainModel.Models.TestConduct.TestAttendees", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("CheckedCandidate");

                    b.Property<string>("ContactNumber")
                        .HasMaxLength(15);

                    b.Property<DateTime>("CreatedDateTime");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("RollNumber")
                        .IsRequired();

                    b.Property<bool>("StarredCandidate");

                    b.Property<int>("TestId");

                    b.Property<DateTime?>("UpdateDateTime");

                    b.HasKey("Id");

                    b.HasIndex("TestId");

                    b.ToTable("TestAttendees");
                });

            modelBuilder.Entity("Promact.Trappist.DomainModel.Models.TestConduct.TestCaseResult", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedDateTime");

                    b.Property<long>("Memory");

                    b.Property<string>("Output");

                    b.Property<long>("Processing");

                    b.Property<int>("TestCodeSolutionId");

                    b.Property<DateTime?>("UpdateDateTime");

                    b.HasKey("Id");

                    b.HasIndex("TestCodeSolutionId");

                    b.ToTable("TestCaseResult");
                });

            modelBuilder.Entity("Promact.Trappist.DomainModel.Models.TestConduct.TestCodeSolution", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedDateTime");

                    b.Property<int>("Language");

                    b.Property<int>("QuestionId");

                    b.Property<double>("Score");

                    b.Property<string>("Solution");

                    b.Property<int>("TestAttendeeId");

                    b.Property<DateTime?>("UpdateDateTime");

                    b.HasKey("Id");

                    b.HasIndex("QuestionId");

                    b.HasIndex("TestAttendeeId");

                    b.ToTable("TestCodeSolution");
                });

            modelBuilder.Entity("Promact.Trappist.DomainModel.Models.TestConduct.TestConduct", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedDateTime");

                    b.Property<int>("QuestionId");

                    b.Property<int>("QuestionStatus");

                    b.Property<int>("TestAttendeeId");

                    b.Property<DateTime?>("UpdateDateTime");

                    b.HasKey("Id");

                    b.HasIndex("QuestionId");

                    b.HasIndex("TestAttendeeId");

                    b.ToTable("TestConduct");
                });

            modelBuilder.Entity("Promact.Trappist.DomainModel.Models.TestLogs.TestLogs", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime?>("AwayFromTestWindow");

                    b.Property<DateTime?>("CloseWindowWithoutFinishingTest");

                    b.Property<DateTime>("CreatedDateTime");

                    b.Property<DateTime?>("DisconnectedFromServer");

                    b.Property<DateTime>("FillRegistrationForm");

                    b.Property<DateTime>("FinishTest");

                    b.Property<DateTime?>("ResumeTest");

                    b.Property<DateTime>("StartTest");

                    b.Property<int>("TestAttendeeId");

                    b.Property<DateTime?>("UpdateDateTime");

                    b.Property<DateTime>("VisitTestLink");

                    b.HasKey("Id");

                    b.HasIndex("TestAttendeeId")
                        .IsUnique();

                    b.ToTable("TestLogs");
                });

            modelBuilder.Entity("Promact.Trappist.Web.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<DateTime>("CreatedDateTime");

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150);

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("OrganizationName")
                        .HasMaxLength(150);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<DateTime?>("UpdatedDateTime");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRole")
                        .WithMany("Claims")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Promact.Trappist.Web.Models.ApplicationUser")
                        .WithMany("Claims")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Promact.Trappist.Web.Models.ApplicationUser")
                        .WithMany("Logins")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRole")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Promact.Trappist.Web.Models.ApplicationUser")
                        .WithMany("Roles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Promact.Trappist.DomainModel.Models.Question.CodeSnippetQuestion", b =>
                {
                    b.HasOne("Promact.Trappist.DomainModel.Models.Question.Question", "Question")
                        .WithOne("CodeSnippetQuestion")
                        .HasForeignKey("Promact.Trappist.DomainModel.Models.Question.CodeSnippetQuestion", "Id")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Promact.Trappist.DomainModel.Models.Question.CodeSnippetQuestionTestCases", b =>
                {
                    b.HasOne("Promact.Trappist.DomainModel.Models.Question.CodeSnippetQuestion", "CodeSnippetQuestion")
                        .WithMany("CodeSnippetQuestionTestCases")
                        .HasForeignKey("CodeSnippetQuestionId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Promact.Trappist.DomainModel.Models.Question.Question", b =>
                {
                    b.HasOne("Promact.Trappist.DomainModel.Models.Category.Category", "Category")
                        .WithMany("Question")
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Promact.Trappist.Web.Models.ApplicationUser", "CreatedByUser")
                        .WithMany()
                        .HasForeignKey("CreatedByUserId");

                    b.HasOne("Promact.Trappist.Web.Models.ApplicationUser", "UpdatedByUser")
                        .WithMany()
                        .HasForeignKey("UpdatedByUserId");
                });

            modelBuilder.Entity("Promact.Trappist.DomainModel.Models.Question.QuestionLanguageMapping", b =>
                {
                    b.HasOne("Promact.Trappist.DomainModel.Models.Question.CodingLanguage", "CodeLanguage")
                        .WithMany("QuestionLanguangeMapping")
                        .HasForeignKey("LanguageId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Promact.Trappist.DomainModel.Models.Question.CodeSnippetQuestion", "CodeSnippetQuestion")
                        .WithMany("QuestionLanguangeMapping")
                        .HasForeignKey("QuestionId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Promact.Trappist.DomainModel.Models.Question.SingleMultipleAnswerQuestion", b =>
                {
                    b.HasOne("Promact.Trappist.DomainModel.Models.Question.Question", "Question")
                        .WithOne("SingleMultipleAnswerQuestion")
                        .HasForeignKey("Promact.Trappist.DomainModel.Models.Question.SingleMultipleAnswerQuestion", "Id")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Promact.Trappist.DomainModel.Models.Question.SingleMultipleAnswerQuestionOption", b =>
                {
                    b.HasOne("Promact.Trappist.DomainModel.Models.Question.SingleMultipleAnswerQuestion", "SingleMultipleAnswerQuestion")
                        .WithMany("SingleMultipleAnswerQuestionOption")
                        .HasForeignKey("SingleMultipleAnswerQuestionID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Promact.Trappist.DomainModel.Models.Report.Report", b =>
                {
                    b.HasOne("Promact.Trappist.DomainModel.Models.TestConduct.TestAttendees", "TestAttendee")
                        .WithOne("Report")
                        .HasForeignKey("Promact.Trappist.DomainModel.Models.Report.Report", "TestAttendeeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Promact.Trappist.DomainModel.Models.Test.Test", b =>
                {
                    b.HasOne("Promact.Trappist.Web.Models.ApplicationUser", "CreatedByUser")
                        .WithMany()
                        .HasForeignKey("CreatedByUserId");
                });

            modelBuilder.Entity("Promact.Trappist.DomainModel.Models.Test.TestCategory", b =>
                {
                    b.HasOne("Promact.Trappist.DomainModel.Models.Category.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Promact.Trappist.DomainModel.Models.Test.Test", "Test")
                        .WithMany("TestCategory")
                        .HasForeignKey("TestId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Promact.Trappist.DomainModel.Models.Test.TestIpAddress", b =>
                {
                    b.HasOne("Promact.Trappist.DomainModel.Models.Test.Test", "Test")
                        .WithMany("TestIpAddress")
                        .HasForeignKey("TestId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Promact.Trappist.DomainModel.Models.Test.TestQuestion", b =>
                {
                    b.HasOne("Promact.Trappist.DomainModel.Models.Question.Question", "Question")
                        .WithMany()
                        .HasForeignKey("QuestionId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Promact.Trappist.DomainModel.Models.Test.Test", "Test")
                        .WithMany("TestQuestion")
                        .HasForeignKey("TestId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Promact.Trappist.DomainModel.Models.TestConduct.AttendeeAnswers", b =>
                {
                    b.HasOne("Promact.Trappist.DomainModel.Models.TestConduct.TestAttendees", "TestAttendees")
                        .WithOne("AttendeeAnswers")
                        .HasForeignKey("Promact.Trappist.DomainModel.Models.TestConduct.AttendeeAnswers", "Id")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Promact.Trappist.DomainModel.Models.TestConduct.TestAnswers", b =>
                {
                    b.HasOne("Promact.Trappist.DomainModel.Models.TestConduct.TestConduct", "TestConduct")
                        .WithMany("TestAnswers")
                        .HasForeignKey("TestConductId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Promact.Trappist.DomainModel.Models.TestConduct.TestAttendees", b =>
                {
                    b.HasOne("Promact.Trappist.DomainModel.Models.Test.Test", "Test")
                        .WithMany("TestAttendees")
                        .HasForeignKey("TestId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Promact.Trappist.DomainModel.Models.TestConduct.TestCaseResult", b =>
                {
                    b.HasOne("Promact.Trappist.DomainModel.Models.TestConduct.TestCodeSolution", "TestCodeSolution")
                        .WithMany("TestCaseResultCollection")
                        .HasForeignKey("TestCodeSolutionId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Promact.Trappist.DomainModel.Models.TestConduct.TestCodeSolution", b =>
                {
                    b.HasOne("Promact.Trappist.DomainModel.Models.Question.Question", "Question")
                        .WithMany()
                        .HasForeignKey("QuestionId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Promact.Trappist.DomainModel.Models.TestConduct.TestAttendees", "TestAttendee")
                        .WithMany()
                        .HasForeignKey("TestAttendeeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Promact.Trappist.DomainModel.Models.TestConduct.TestConduct", b =>
                {
                    b.HasOne("Promact.Trappist.DomainModel.Models.Question.Question", "Question")
                        .WithMany()
                        .HasForeignKey("QuestionId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Promact.Trappist.DomainModel.Models.TestConduct.TestAttendees", "TestAttendees")
                        .WithMany("TestConduct")
                        .HasForeignKey("TestAttendeeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Promact.Trappist.DomainModel.Models.TestLogs.TestLogs", b =>
                {
                    b.HasOne("Promact.Trappist.DomainModel.Models.TestConduct.TestAttendees", "TestAttendee")
                        .WithOne("TestLogs")
                        .HasForeignKey("Promact.Trappist.DomainModel.Models.TestLogs.TestLogs", "TestAttendeeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
