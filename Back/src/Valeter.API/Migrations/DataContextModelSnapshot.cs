﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Valeter.API.Data;

#nullable disable

namespace Valeter.API.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Valeter.API.Models.Client", b =>
                {
                    b.Property<int>("ClientId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ClientAddressLine1")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("ClientAddressLine2")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("ClientAddressNumber")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("ClientCountry")
                        .HasColumnType("int");

                    b.Property<string>("ClientEmail")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("ClientLocation")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("ClientName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("ClientPhone")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("ClientPostalCode")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("ClientTown")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("CompanyId")
                        .HasColumnType("int");

                    b.Property<string>("LogoUrl")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("ClientId");

                    b.HasIndex("CompanyId");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("Valeter.API.Models.Company", b =>
                {
                    b.Property<int>("CompanyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("CompanyAddress")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("CompanyAddressNumber")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("CompanyCity")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("CompanyCountry")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("CompanyEmail")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("CompanyPhone")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("CompanyPostalCode")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("CompanyRegion")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("LogoUrl")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("CompanyId");

                    b.ToTable("Companies");
                });

            modelBuilder.Entity("Valeter.API.Models.Costumer", b =>
                {
                    b.Property<int>("CostumerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("ClientId")
                        .HasColumnType("int");

                    b.Property<string>("CostumerEmail")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("CostumerName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("CostumerPhone")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("CostumerId");

                    b.HasIndex("ClientId");

                    b.ToTable("Costumers");
                });

            modelBuilder.Entity("Valeter.API.Models.Department", b =>
                {
                    b.Property<int>("DepartmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("DepartmentCode")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("DepartmentDescription")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("DepartmentName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("DepartmentId");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("Valeter.API.Models.FollowUp", b =>
                {
                    b.Property<int>("FollowUpId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("FollowUpDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("FollowUpDescription")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("FollowUpId");

                    b.HasIndex("UserId");

                    b.ToTable("FollowUps");
                });

            modelBuilder.Entity("Valeter.API.Models.Note", b =>
                {
                    b.Property<int>("NoteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("NoteContent")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("NoteDate")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("NoteId");

                    b.HasIndex("UserId");

                    b.ToTable("Notes");
                });

            modelBuilder.Entity("Valeter.API.Models.Parking", b =>
                {
                    b.Property<int>("ParkingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ParkingCode")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("ParkingDescription")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("ParkingName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("ParkingSpaceNumber")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("ParkingId");

                    b.ToTable("Parkings");
                });

            modelBuilder.Entity("Valeter.API.Models.Position", b =>
                {
                    b.Property<int>("PositionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("PositionDescription")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("PositionName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("PositionId");

                    b.ToTable("Positions");
                });

            modelBuilder.Entity("Valeter.API.Models.Test", b =>
                {
                    b.Property<int>("TestId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("TestId");

                    b.ToTable("Tests");
                });

            modelBuilder.Entity("Valeter.API.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<int>("PositionId")
                        .HasColumnType("int");

                    b.Property<string>("UserEmail")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("UserLogin")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("UserPassword")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("UserPhoneNumber")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("UserId");

                    b.HasIndex("DepartmentId");

                    b.HasIndex("PositionId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Valeter.API.Models.Vehicle", b =>
                {
                    b.Property<int>("VehicleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("VehicleColor")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("VehicleManufacturerId")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("VehicleManufacturerId1")
                        .HasColumnType("int");

                    b.Property<string>("VehicleModel")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("VehiclePrivReg")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("VehicleReg")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("VehicleTypeId")
                        .HasColumnType("int");

                    b.HasKey("VehicleId");

                    b.HasIndex("VehicleManufacturerId1");

                    b.HasIndex("VehicleTypeId");

                    b.ToTable("Vehicles");
                });

            modelBuilder.Entity("Valeter.API.Models.VehicleManufacturer", b =>
                {
                    b.Property<int>("VehicleManufacturerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("VehicleManufacturerDescription")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("VehicleManufacturerName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("VehicleManufacturerId");

                    b.ToTable("VehicleManufacturers");
                });

            modelBuilder.Entity("Valeter.API.Models.VehicleType", b =>
                {
                    b.Property<int>("VehicleTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("VehicleTypeDesription")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("VehicleTypeName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("VehicleTypeId");

                    b.ToTable("VehicleTypes");
                });

            modelBuilder.Entity("Valeter.API.Models.Washing", b =>
                {
                    b.Property<int>("WashingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("ClientId")
                        .HasColumnType("int");

                    b.Property<int>("CostumerId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Duration")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("TimeBook")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("TimeCollect")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("TimeFinish")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("TimeStart")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("VehicleId")
                        .HasColumnType("int");

                    b.Property<int>("WashingTypeId")
                        .HasColumnType("int");

                    b.HasKey("WashingId");

                    b.HasIndex("UserId");

                    b.ToTable("Washings");
                });

            modelBuilder.Entity("Valeter.API.Models.WashingStatus", b =>
                {
                    b.Property<int>("WashingStatusId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("WashingStatusCode")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("WashingStatusDescription")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("WashingStatusName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("WashingStatusId");

                    b.ToTable("WashingStatuses");
                });

            modelBuilder.Entity("Valeter.API.Models.WashingType", b =>
                {
                    b.Property<int>("WashingTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("WashingTypeCode")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("WashingTypeDescription")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("WashingTypeName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<float>("WashingTypePrice")
                        .HasColumnType("float");

                    b.Property<int>("WashingTypeTime")
                        .HasColumnType("int");

                    b.HasKey("WashingTypeId");

                    b.ToTable("WashingTypes");
                });

            modelBuilder.Entity("Valeter.API.Models.Client", b =>
                {
                    b.HasOne("Valeter.API.Models.Company", "Company")
                        .WithMany("Clients")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Company");
                });

            modelBuilder.Entity("Valeter.API.Models.Costumer", b =>
                {
                    b.HasOne("Valeter.API.Models.Client", "Client")
                        .WithMany()
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");
                });

            modelBuilder.Entity("Valeter.API.Models.FollowUp", b =>
                {
                    b.HasOne("Valeter.API.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Valeter.API.Models.Note", b =>
                {
                    b.HasOne("Valeter.API.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Valeter.API.Models.User", b =>
                {
                    b.HasOne("Valeter.API.Models.Department", "Department")
                        .WithMany()
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Valeter.API.Models.Position", "Position")
                        .WithMany()
                        .HasForeignKey("PositionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");

                    b.Navigation("Position");
                });

            modelBuilder.Entity("Valeter.API.Models.Vehicle", b =>
                {
                    b.HasOne("Valeter.API.Models.VehicleManufacturer", "VehicleManufacturer")
                        .WithMany()
                        .HasForeignKey("VehicleManufacturerId1")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Valeter.API.Models.VehicleType", "VehicleType")
                        .WithMany()
                        .HasForeignKey("VehicleTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("VehicleManufacturer");

                    b.Navigation("VehicleType");
                });

            modelBuilder.Entity("Valeter.API.Models.Washing", b =>
                {
                    b.HasOne("Valeter.API.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Valeter.API.Models.Company", b =>
                {
                    b.Navigation("Clients");
                });
#pragma warning restore 612, 618
        }
    }
}
