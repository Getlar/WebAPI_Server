﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebAPI_Server.Repositories;

namespace WebAPI_Server.Migrations
{
    [DbContext(typeof(PersonContext))]
    [Migration("20200501130902_updatedProperties")]
    partial class updatedProperties
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebAPI_Server.Models.Person", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Complaint")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<DateTime>("DateOfArrrival")
                        .HasColumnType("datetime2");

                    b.Property<string>("SocialSecurityNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(11)")
                        .HasMaxLength(11);

                    b.Property<DateTime>("dateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("firstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("lastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.HasKey("id");

                    b.ToTable("People");
                });
#pragma warning restore 612, 618
        }
    }
}
