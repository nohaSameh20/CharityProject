﻿// <auto-generated />
using System;
using CharityProject.Persistance;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Charity.Persistence.Migrations
{
    [DbContext(typeof(DatabaseService))]
    [Migration("20210401011841_mig01")]
    partial class mig01
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Charity.Domain.Address.Nationality", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("Nationality");
                });

            modelBuilder.Entity("Charity.Domain.Adreess.City", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("CountryId");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.ToTable("City");
                });

            modelBuilder.Entity("Charity.Domain.Adreess.Country", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Country");
                });

            modelBuilder.Entity("Charity.Domain.Cases.Case", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CaseAge");

                    b.Property<string>("CaseAttachment");

                    b.Property<string>("CaseDescription")
                        .IsRequired();

                    b.Property<int>("CaseGender");

                    b.Property<string>("CaseName")
                        .IsRequired();

                    b.Property<string>("CasePhoneNumber")
                        .IsRequired();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("CreatedBy");

                    b.Property<string>("EntityName");

                    b.Property<int>("Entitytype");

                    b.Property<string>("FisrtAddress")
                        .IsRequired();

                    b.Property<string>("Region")
                        .IsRequired();

                    b.Property<int>("Religion");

                    b.Property<string>("SecondAddress");

                    b.Property<string>("SenderAddress")
                        .IsRequired();

                    b.Property<string>("SenderName")
                        .IsRequired();

                    b.Property<string>("SenderPhoneNumber")
                        .IsRequired();

                    b.Property<string>("UpdatedBy");

                    b.Property<DateTime>("UpdatedDate");

                    b.HasKey("Id");

                    b.ToTable("Case");
                });

            modelBuilder.Entity("Charity.Domain.Medias.Media", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("CreatedBy");

                    b.Property<string>("Descirption");

                    b.Property<string>("Image");

                    b.Property<int>("Type");

                    b.Property<string>("UpdatedBy");

                    b.Property<DateTime>("UpdatedDate");

                    b.Property<string>("Url");

                    b.HasKey("Id");

                    b.ToTable("Media");
                });

            modelBuilder.Entity("CharityProject.Domain.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("CityId");

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<string>("HashPassword")
                        .IsRequired();

                    b.Property<bool>("IsActive");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("LastName")
                        .IsRequired();

                    b.Property<Guid>("NationalityId");

                    b.Property<string>("PhoneNumber")
                        .IsRequired();

                    b.Property<string>("PrimaryAddress");

                    b.Property<string>("Salt")
                        .IsRequired();

                    b.Property<string>("SecondAddress");

                    b.Property<int>("UserRole");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.HasIndex("NationalityId");

                    b.ToTable("User");
                });

            modelBuilder.Entity("Charity.Domain.Adreess.City", b =>
                {
                    b.HasOne("Charity.Domain.Adreess.Country", "Country")
                        .WithMany("states")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CharityProject.Domain.User", b =>
                {
                    b.HasOne("Charity.Domain.Adreess.City", "City")
                        .WithMany()
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Charity.Domain.Address.Nationality", "Nationality")
                        .WithMany()
                        .HasForeignKey("NationalityId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
