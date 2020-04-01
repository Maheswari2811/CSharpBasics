﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using generics.EntityFrameworkCore.trialtwocontextreplica;

namespace generics.Migrations.trialtwocontextreplicaMigrations
{
    [DbContext(typeof(trialtwocontextreplica))]
    [Migration("20200401083251_nullableforeignkey")]
    partial class nullableforeignkey
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("generics.EntityFrameworkCore.trialtwocontextreplica.employee", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("EmployeeDetailsId")
                        .HasColumnType("int");

                    b.Property<string>("lastname")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("id");

                    b.HasIndex("EmployeeDetailsId")
                        .IsUnique()
                        .HasFilter("[EmployeeDetailsId] IS NOT NULL");

                    b.ToTable("employee");
                });

            modelBuilder.Entity("generics.EntityFrameworkCore.trialtwocontextreplica.employeeDetails", b =>
                {
                    b.Property<int>("EmployeeDetailsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(500)");

                    b.HasKey("EmployeeDetailsId");

                    b.ToTable("employeeDetails");
                });

            modelBuilder.Entity("generics.EntityFrameworkCore.trialtwocontextreplica.employeestudentassociation", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("employeeid")
                        .HasColumnType("int");

                    b.Property<int>("studentid")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("employeeid");

                    b.HasIndex("studentid");

                    b.ToTable("employeestudentassociation");
                });

            modelBuilder.Entity("generics.EntityFrameworkCore.trialtwocontextreplica.student", b =>
                {
                    b.Property<int>("studentid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("studentid");

                    b.ToTable("student");
                });

            modelBuilder.Entity("generics.EntityFrameworkCore.trialtwocontextreplica.employee", b =>
                {
                    b.HasOne("generics.EntityFrameworkCore.trialtwocontextreplica.employeeDetails", "employeeDetails")
                        .WithOne("employee")
                        .HasForeignKey("generics.EntityFrameworkCore.trialtwocontextreplica.employee", "EmployeeDetailsId")
                        .HasConstraintName("FK_employeedetailsid_employeedetails");
                });

            modelBuilder.Entity("generics.EntityFrameworkCore.trialtwocontextreplica.employeestudentassociation", b =>
                {
                    b.HasOne("generics.EntityFrameworkCore.trialtwocontextreplica.employee", "employees")
                        .WithMany("employeestudentassociations")
                        .HasForeignKey("employeeid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("generics.EntityFrameworkCore.trialtwocontextreplica.student", "students")
                        .WithMany("employeestudentassociation")
                        .HasForeignKey("studentid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
