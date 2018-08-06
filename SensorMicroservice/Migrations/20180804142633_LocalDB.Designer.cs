﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SensorMicroservice.Context;

namespace SensorMicroservice.Migrations
{
    [DbContext(typeof(SensorDbContext))]
    [Migration("20180804142633_LocalDB")]
    partial class LocalDB
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SensorMicroservice.Models.AirQuality", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("HardwareId");

                    b.Property<DateTime>("Time");

                    b.Property<int>("Value");

                    b.HasKey("ID");

                    b.ToTable("AirQuality");
                });

            modelBuilder.Entity("SensorMicroservice.Models.Coffee", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("BeginProcess")
                        .HasColumnName("BeginProcess");

                    b.Property<int>("CurrentLevel");

                    b.Property<DateTime>("EndProcess")
                        .HasColumnName("EndProcess");

                    b.Property<int>("HardwareId");

                    b.HasKey("ID");

                    b.ToTable("Coffee","Alesta");
                });

            modelBuilder.Entity("SensorMicroservice.Models.RestRoom", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("BeginProcess");

                    b.Property<DateTime>("EndProcess");

                    b.Property<int>("HardwareId");

                    b.Property<bool>("Value");

                    b.HasKey("ID");

                    b.ToTable("RestRoom");
                });
#pragma warning restore 612, 618
        }
    }
}
