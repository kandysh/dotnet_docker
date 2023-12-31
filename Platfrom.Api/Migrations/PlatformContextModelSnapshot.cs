﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Platfrom.Api.DataAccess;

#nullable disable

namespace Platfrom.Api.Migrations
{
    [DbContext(typeof(PlatformContext))]
    partial class PlatformContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Platfrom.Api.DataAccess.Platform", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Cost")
                        .IsRequired()
                        .HasColumnType("nvarchar");

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2023, 7, 22, 20, 12, 55, 235, DateTimeKind.Utc).AddTicks(5782));

                    b.Property<DateTime>("ModifiedAt")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2023, 7, 22, 20, 12, 55, 235, DateTimeKind.Utc).AddTicks(6088));

                    b.Property<string>("PlatformName")
                        .IsRequired()
                        .HasColumnType("nvarchar");

                    b.Property<string>("Publisher")
                        .IsRequired()
                        .HasColumnType("nvarchar");

                    b.HasKey("Id");

                    b.ToTable("PlatformTbl", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
