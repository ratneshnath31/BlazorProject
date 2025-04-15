﻿// <auto-generated />
using System;
using BlazorMediLab.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BlazorMediLab.Migrations
{
    [DbContext(typeof(SurveyDbContext))]
    partial class SurveyDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BlazorMediLab.Models.PHQ2Model", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Question1")
                        .HasColumnType("int");

                    b.Property<int>("Question2")
                        .HasColumnType("int");

                    b.Property<DateTime>("SubmittedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("TotalScore")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("PHQ2Responses");
                });
#pragma warning restore 612, 618
        }
    }
}
