﻿// <auto-generated />
using System;
using ElectricityApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ElectricityApp.Migrations
{
    [DbContext(typeof(Database))]
    partial class DatabaseModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ElectricityApp.Models.DomesticUser", b =>
                {
                    b.Property<string>("Network")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("ObjIdNum")
                        .HasColumnType("int");

                    b.Property<string>("ObjName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ObjType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("ProducedElectricity")
                        .HasColumnType("float");

                    b.Property<double>("UsedElectricity")
                        .HasColumnType("float");

                    b.HasKey("Network");

                    b.ToTable("DomesticUsers");
                });
#pragma warning restore 612, 618
        }
    }
}
