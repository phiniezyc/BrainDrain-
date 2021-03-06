﻿// <auto-generated />
using BrainDrain.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BrainDrain.Migrations
{
    [DbContext(typeof(BrainDrainContext))]
    partial class BrainDrainContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("BrainDrain.Models.Command", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("HowTo")
                        .IsRequired()
                        .HasColumnType("varchar(250)")
                        .HasMaxLength(250);

                    b.Property<string>("Line")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Platform")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Commands");
                });
#pragma warning restore 612, 618
        }
    }
}
