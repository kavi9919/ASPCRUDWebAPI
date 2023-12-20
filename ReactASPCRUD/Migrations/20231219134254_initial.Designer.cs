﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ReactASPCRUD.Models;

#nullable disable

namespace ReactASPCRUD.Migrations
{
    [DbContext(typeof(StudentDbContext))]
    [Migration("20231219134254_initial")]
    partial class initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ReactASPCRUD.Models.Student", b =>
                {
                    b.Property<int>("stId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("stId"));

                    b.Property<string>("stCourse")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("stName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("stId");

                    b.ToTable("Students");
                });
#pragma warning restore 612, 618
        }
    }
}