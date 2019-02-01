﻿// <auto-generated />
using System;
using EFCoreTutorials;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EFCoreTutorials.Migrations
{
    [DbContext(typeof(SchoolContext))]
    partial class SchoolContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.1-servicing-10028")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("EFCoreTutorials.Course", b =>
                {
                    b.Property<int>("CourseId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CourseName");

                    b.HasKey("CourseId");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("EFCoreTutorials.Grade", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("GradeName");

                    b.Property<string>("Section");

                    b.HasKey("Id");

                    b.ToTable("Grade");
                });

            modelBuilder.Entity("EFCoreTutorials.Student", b =>
                {
                    b.Property<int>("StudentId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateOfBirth");

                    b.Property<string>("FirstName");

                    b.Property<int>("GradeId");

                    b.Property<decimal>("Height");

                    b.Property<string>("LastName");

                    b.Property<byte[]>("Photo");

                    b.Property<float>("Weight");

                    b.HasKey("StudentId");

                    b.HasIndex("GradeId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("EFCoreTutorials.Student", b =>
                {
                    b.HasOne("EFCoreTutorials.Grade", "Grade")
                        .WithMany("Students")
                        .HasForeignKey("GradeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
