﻿// <auto-generated />
using CommunityProject.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace CommunityProject.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    partial class DatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125");

            modelBuilder.Entity("CommunityProject.Models.BowlathonInfo", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address");

                    b.Property<string>("City");

                    b.Property<int>("CustID");

                    b.Property<DateTime>("DOB");

                    b.Property<string>("Email");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<string>("Payment");

                    b.Property<int>("Phone");

                    b.Property<bool>("PicConsent");

                    b.Property<string>("ShirtSize");

                    b.Property<string>("State");

                    b.Property<int>("TeamID");

                    b.Property<int>("ZIP");

                    b.HasKey("ID");

                    b.ToTable("BowlathonInfo");
                });

            modelBuilder.Entity("CommunityProject.Models.FishingDerbyInfo", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Consent");

                    b.Property<int>("CustID");

                    b.HasKey("ID");

                    b.ToTable("FishingDerbyInfo");
                });

            modelBuilder.Entity("CommunityProject.Models.GenInfo", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address");

                    b.Property<string>("City");

                    b.Property<DateTime>("DOB");

                    b.Property<string>("Email");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<int>("Phone");

                    b.Property<bool>("PicConsent");

                    b.Property<string>("ShirtSize");

                    b.Property<string>("State");

                    b.Property<int>("ZIP");

                    b.HasKey("ID");

                    b.ToTable("GenInfo");
                });

            modelBuilder.Entity("CommunityProject.Models.WalkathonInfo", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CustID");

                    b.Property<int>("Payment");

                    b.HasKey("ID");

                    b.ToTable("WalkathonInfo");
                });
#pragma warning restore 612, 618
        }
    }
}