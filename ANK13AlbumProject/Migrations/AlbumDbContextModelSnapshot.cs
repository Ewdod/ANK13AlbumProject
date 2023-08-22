﻿// <auto-generated />
using System;
using ANK13AlbumProject.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ANK13AlbumProject.Migrations
{
    [DbContext(typeof(AlbumDbContext))]
    partial class AlbumDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ANK13AlbumProject.Entities.Admin", b =>
                {
                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserName");

                    b.ToTable("Admins");
                });

            modelBuilder.Entity("ANK13AlbumProject.Entities.Album", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Sanatci")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("SatisDurumu")
                        .HasColumnType("bit");

                    b.Property<DateTime>("Yil")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Album");
                });
#pragma warning restore 612, 618
        }
    }
}
