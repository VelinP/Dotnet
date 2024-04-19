﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyApp.Data;

#nullable disable

namespace MyApp.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240419192400_UserTableToDb")]
    partial class UserTableToDb
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("UserNamespace.User", b =>
                {
                    b.Property<int>("BaseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BaseId"));

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("BaseUsername")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BaseId");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
