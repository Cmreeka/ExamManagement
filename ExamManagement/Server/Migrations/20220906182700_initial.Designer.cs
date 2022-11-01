﻿// <auto-generated />
using System;
using ExamManagement.Server.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ExamManagement.Server.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20220906182700_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.6");

            modelBuilder.Entity("ExamManagement.Server.Data.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("TEXT");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("ExamManagement.Server.Entities.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ConcurrentRegistrationCourse")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("CourseCode")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("CourseName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<int>("Credit")
                        .HasColumnType("INTEGER");

                    b.Property<int>("FacultyId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Lecture")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Practical")
                        .HasColumnType("INTEGER");

                    b.Property<string>("PreRequisiteCourse")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("SemesterTypeId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Tutorial")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("FacultyId");

                    b.HasIndex("SemesterTypeId");

                    b.ToTable("Course");
                });

            modelBuilder.Entity("ExamManagement.Server.Entities.ExamForm", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("FormFilledDate")
                        .HasColumnType("TEXT");

                    b.Property<int>("UserDetailExtensionStudentTemporaryId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("UserDetailExtensionStudentTemporaryId");

                    b.ToTable("ExamForm");
                });

            modelBuilder.Entity("ExamManagement.Server.Entities.ExamFormBack", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CourseId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ExamFormId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.HasIndex("ExamFormId");

                    b.ToTable("ExamFormBack");
                });

            modelBuilder.Entity("ExamManagement.Server.Entities.ExamFormConcurrent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CourseId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ExamFormId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.HasIndex("ExamFormId");

                    b.ToTable("ExamFormConcurrent");
                });

            modelBuilder.Entity("ExamManagement.Server.Entities.ExamFormPrerequisite", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CourseId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ExamFormId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.HasIndex("ExamFormId");

                    b.ToTable("ExamFormPrerequisite");
                });

            modelBuilder.Entity("ExamManagement.Server.Entities.ExamFormRegular", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CourseId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ExamFormId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.HasIndex("ExamFormId");

                    b.ToTable("ExamFormRegular");
                });

            modelBuilder.Entity("ExamManagement.Server.Entities.Faculty", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("FacultyName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Faculty");
                });

            modelBuilder.Entity("ExamManagement.Server.Entities.ItemType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ItemTypeCategoryId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ItemTypeCategoryId");

                    b.ToTable("ItemType");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ItemTypeCategoryId = 1,
                            Name = "FIRST SEMESTER"
                        },
                        new
                        {
                            Id = 2,
                            ItemTypeCategoryId = 1,
                            Name = "SECOND SEMESTER"
                        },
                        new
                        {
                            Id = 3,
                            ItemTypeCategoryId = 1,
                            Name = "THIRD SEMESTER"
                        },
                        new
                        {
                            Id = 4,
                            ItemTypeCategoryId = 1,
                            Name = "FOURTH SEMESTER"
                        },
                        new
                        {
                            Id = 5,
                            ItemTypeCategoryId = 1,
                            Name = "FIFTH SEMESTER"
                        },
                        new
                        {
                            Id = 6,
                            ItemTypeCategoryId = 1,
                            Name = "SIXTH SEMESTER"
                        },
                        new
                        {
                            Id = 7,
                            ItemTypeCategoryId = 1,
                            Name = "SEVENTH SEMESTER"
                        },
                        new
                        {
                            Id = 8,
                            ItemTypeCategoryId = 1,
                            Name = "EIGHTH SEMESTER"
                        });
                });

            modelBuilder.Entity("ExamManagement.Server.Entities.ItemTypeCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedCategoryName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("ItemTypeCategory");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryName = "Semester",
                            NormalizedCategoryName = "SEMESTER"
                        });
                });

            modelBuilder.Entity("ExamManagement.Server.Entities.Result", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("UserDetailExtensionStudentTemporaryId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("UserDetailExtensionStudentTemporaryId");

                    b.ToTable("Result");
                });

            modelBuilder.Entity("ExamManagement.Server.Entities.ResultExtension", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CourseId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Grade")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("ResultId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.HasIndex("ResultId");

                    b.ToTable("ResultExtension");
                });

            modelBuilder.Entity("ExamManagement.Server.Entities.UserDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ApplicationUserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<int>("FacultyId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("ApplicationUserId");

                    b.HasIndex("FacultyId");

                    b.ToTable("UserDetail");
                });

            modelBuilder.Entity("ExamManagement.Server.Entities.UserDetailExtension", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Batch")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("ExamNumber")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("RegistrationNumber")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("RollNumber")
                        .HasColumnType("INTEGER");

                    b.Property<int>("UserDetailId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("UserDetailId");

                    b.ToTable("UserDetailExtension");
                });

            modelBuilder.Entity("ExamManagement.Server.Entities.UserDetailExtensionStudentTemporary", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<int>("ExamYear")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Semester")
                        .HasColumnType("INTEGER");

                    b.Property<int>("UserDetailExtensionId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("UserDetailExtensionId");

                    b.ToTable("UserDetailExtensionStudentTemporary");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Value")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("ExamManagement.Server.Entities.Course", b =>
                {
                    b.HasOne("ExamManagement.Server.Entities.Faculty", "Faculty")
                        .WithMany()
                        .HasForeignKey("FacultyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ExamManagement.Server.Entities.ItemType", "SemesterType")
                        .WithMany()
                        .HasForeignKey("SemesterTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Faculty");

                    b.Navigation("SemesterType");
                });

            modelBuilder.Entity("ExamManagement.Server.Entities.ExamForm", b =>
                {
                    b.HasOne("ExamManagement.Server.Entities.UserDetailExtensionStudentTemporary", "UserDetailExtensionStudentTemporary")
                        .WithMany()
                        .HasForeignKey("UserDetailExtensionStudentTemporaryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UserDetailExtensionStudentTemporary");
                });

            modelBuilder.Entity("ExamManagement.Server.Entities.ExamFormBack", b =>
                {
                    b.HasOne("ExamManagement.Server.Entities.Course", "Course")
                        .WithMany()
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ExamManagement.Server.Entities.ExamForm", "ExamForm")
                        .WithMany()
                        .HasForeignKey("ExamFormId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("ExamForm");
                });

            modelBuilder.Entity("ExamManagement.Server.Entities.ExamFormConcurrent", b =>
                {
                    b.HasOne("ExamManagement.Server.Entities.Course", "Course")
                        .WithMany()
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ExamManagement.Server.Entities.ExamForm", "ExamForm")
                        .WithMany()
                        .HasForeignKey("ExamFormId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("ExamForm");
                });

            modelBuilder.Entity("ExamManagement.Server.Entities.ExamFormPrerequisite", b =>
                {
                    b.HasOne("ExamManagement.Server.Entities.Course", "Course")
                        .WithMany()
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ExamManagement.Server.Entities.ExamForm", "ExamForm")
                        .WithMany()
                        .HasForeignKey("ExamFormId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("ExamForm");
                });

            modelBuilder.Entity("ExamManagement.Server.Entities.ExamFormRegular", b =>
                {
                    b.HasOne("ExamManagement.Server.Entities.Course", "Course")
                        .WithMany()
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ExamManagement.Server.Entities.ExamForm", "ExamForm")
                        .WithMany()
                        .HasForeignKey("ExamFormId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("ExamForm");
                });

            modelBuilder.Entity("ExamManagement.Server.Entities.ItemType", b =>
                {
                    b.HasOne("ExamManagement.Server.Entities.ItemTypeCategory", "ItemTypeCategory")
                        .WithMany()
                        .HasForeignKey("ItemTypeCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ItemTypeCategory");
                });

            modelBuilder.Entity("ExamManagement.Server.Entities.Result", b =>
                {
                    b.HasOne("ExamManagement.Server.Entities.UserDetailExtensionStudentTemporary", "UserDetailExtensionStudentTemporary")
                        .WithMany()
                        .HasForeignKey("UserDetailExtensionStudentTemporaryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UserDetailExtensionStudentTemporary");
                });

            modelBuilder.Entity("ExamManagement.Server.Entities.ResultExtension", b =>
                {
                    b.HasOne("ExamManagement.Server.Entities.Course", "Course")
                        .WithMany()
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ExamManagement.Server.Entities.Result", "Result")
                        .WithMany()
                        .HasForeignKey("ResultId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Result");
                });

            modelBuilder.Entity("ExamManagement.Server.Entities.UserDetail", b =>
                {
                    b.HasOne("ExamManagement.Server.Data.ApplicationUser", "ApplicationUser")
                        .WithMany()
                        .HasForeignKey("ApplicationUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ExamManagement.Server.Entities.Faculty", "Faculty")
                        .WithMany()
                        .HasForeignKey("FacultyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ApplicationUser");

                    b.Navigation("Faculty");
                });

            modelBuilder.Entity("ExamManagement.Server.Entities.UserDetailExtension", b =>
                {
                    b.HasOne("ExamManagement.Server.Entities.UserDetail", "UserDetail")
                        .WithMany()
                        .HasForeignKey("UserDetailId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UserDetail");
                });

            modelBuilder.Entity("ExamManagement.Server.Entities.UserDetailExtensionStudentTemporary", b =>
                {
                    b.HasOne("ExamManagement.Server.Entities.UserDetailExtension", "UserDetailExtension")
                        .WithMany()
                        .HasForeignKey("UserDetailExtensionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UserDetailExtension");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("ExamManagement.Server.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("ExamManagement.Server.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ExamManagement.Server.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("ExamManagement.Server.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
