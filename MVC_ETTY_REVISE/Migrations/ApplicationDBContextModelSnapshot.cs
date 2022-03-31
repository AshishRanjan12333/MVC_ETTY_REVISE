﻿// <auto-generated />
using System;
using MVC_ETTY_REVISE.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MVC_ETTY_REVISE.Migrations
{
    [DbContext(typeof(ApplicationDBContext))]
    partial class ApplicationDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.23")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MVC_ETTY_REVISE.Models.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("C_Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("C_Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("C_Mobile")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("C_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("locationId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("locationId");

                    b.ToTable("GetCustomers");
                });

            modelBuilder.Entity("MVC_ETTY_REVISE.Models.Location", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Details")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Place")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("GetLocations");
                });

            modelBuilder.Entity("MVC_ETTY_REVISE.Models.Customer", b =>
                {
                    b.HasOne("MVC_ETTY_REVISE.Models.Location", "location")
                        .WithMany()
                        .HasForeignKey("locationId");
                });
#pragma warning restore 612, 618
        }
    }
}
