﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WeatherApp.Data;

#nullable disable

namespace WeatherApp.Migrations
{
    [DbContext(typeof(WeatherAppContext))]
    [Migration("20230420214849_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.5");

            modelBuilder.Entity("WeatherApp.Models.Weather", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT");

                    b.Property<int>("Humidity")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Location")
                        .HasColumnType("TEXT");

                    b.Property<int>("Precipitation")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Temperature")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Wind")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Weather");
                });
#pragma warning restore 612, 618
        }
    }
}
