﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using eLaptops.Data;

#nullable disable

namespace eLaptops.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("eLaptops.Models.Company", b =>
                {
                    b.Property<int>("CompanyID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CompanyID"), 1L, 1);

                    b.Property<string>("CompanyLogo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CompanyID");

                    b.ToTable("Company");
                });

            modelBuilder.Entity("eLaptops.Models.Features", b =>
                {
                    b.Property<int>("FeatureID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FeatureID"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FeatureName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FeaturePictureURL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FeatureID");

                    b.ToTable("Features");
                });

            modelBuilder.Entity("eLaptops.Models.Features_Laptop", b =>
                {
                    b.Property<int>("FeatureID")
                        .HasColumnType("int");

                    b.Property<int>("LaptopID")
                        .HasColumnType("int");

                    b.HasKey("FeatureID", "LaptopID");

                    b.HasIndex("LaptopID");

                    b.ToTable("Features_Laptops");
                });

            modelBuilder.Entity("eLaptops.Models.Laptop", b =>
                {
                    b.Property<int>("LaptopID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LaptopID"), 1L, 1);

                    b.Property<string>("CPUModel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Colour")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CompanyID")
                        .HasColumnType("int");

                    b.Property<string>("ImageURL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ModelName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OperatingSystem")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<string>("RAM")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ScreenSize")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LaptopID");

                    b.HasIndex("CompanyID");

                    b.ToTable("Laptops");
                });

            modelBuilder.Entity("eLaptops.Models.Features_Laptop", b =>
                {
                    b.HasOne("eLaptops.Models.Features", "Features")
                        .WithMany("Features_Laptops")
                        .HasForeignKey("FeatureID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("eLaptops.Models.Laptop", "Laptop")
                        .WithMany("Features_Laptops")
                        .HasForeignKey("LaptopID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Features");

                    b.Navigation("Laptop");
                });

            modelBuilder.Entity("eLaptops.Models.Laptop", b =>
                {
                    b.HasOne("eLaptops.Models.Company", "Company")
                        .WithMany("Laptops")
                        .HasForeignKey("CompanyID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Company");
                });

            modelBuilder.Entity("eLaptops.Models.Company", b =>
                {
                    b.Navigation("Laptops");
                });

            modelBuilder.Entity("eLaptops.Models.Features", b =>
                {
                    b.Navigation("Features_Laptops");
                });

            modelBuilder.Entity("eLaptops.Models.Laptop", b =>
                {
                    b.Navigation("Features_Laptops");
                });
#pragma warning restore 612, 618
        }
    }
}
