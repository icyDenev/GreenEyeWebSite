﻿// <auto-generated />
using LitWebSite.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LitWebSite.Migrations
{
    [DbContext(typeof(SensorDBContext))]
    partial class SensorDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("LitWebSite.Models.Sensors", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("CO");

                    b.Property<decimal>("CO2");

                    b.Property<decimal>("DownLeftLatitude");

                    b.Property<decimal>("DownLeftLongtitute");

                    b.Property<decimal>("O3");

                    b.Property<decimal>("PM25");

                    b.Property<decimal>("UpRightLatitude");

                    b.Property<decimal>("UpRightLongtitude");

                    b.HasKey("Id");

                    b.ToTable("SensorsData");
                });
#pragma warning restore 612, 618
        }
    }
}
