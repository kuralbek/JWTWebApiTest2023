﻿// <auto-generated />
using System;
using AuthTestCore.DBContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace AuthTestCore.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230816094734_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("AuthTestCore.ModelEntity.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name_role")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int?>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Role");
                });

            modelBuilder.Entity("AuthTestCore.ModelEntity.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("user_Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("AuthTestCore.ModelEntity.Role", b =>
                {
                    b.HasOne("AuthTestCore.ModelEntity.User", null)
                        .WithMany("roles")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("AuthTestCore.ModelEntity.User", b =>
                {
                    b.Navigation("roles");
                });
#pragma warning restore 612, 618
        }
    }
}
