﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace brew_track.Migrations
{
    [DbContext(typeof(OrdersDatabaseContext))]
    [Migration("20200808041220_InitalCreate")]
    partial class InitalCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.6");

            modelBuilder.Entity("brew_track.Models.Orders", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CarType")
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .HasColumnType("TEXT");

                    b.Property<string>("Items")
                        .HasColumnType("TEXT");

                    b.Property<string>("TableNumber")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}