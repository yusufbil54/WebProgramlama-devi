﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using WebApplication15.Data;

#nullable disable

namespace WebApplication15.Migrations.AppDbUcak
{
    [DbContext(typeof(AppDbUcakContext))]
    partial class AppDbUcakContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.23")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("WebApplication15.Data.FlyName", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("FlyNames");
                });

            modelBuilder.Entity("WebApplication15.Data.Voyage", b =>
                {
                    b.Property<int>("VoyageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("VoyageId"));

                    b.Property<string>("AirPlaneName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("From")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("FromDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("To")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("capacity")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("VoyageId");

                    b.ToTable("Voyages");
                });
#pragma warning restore 612, 618
        }
    }
}
