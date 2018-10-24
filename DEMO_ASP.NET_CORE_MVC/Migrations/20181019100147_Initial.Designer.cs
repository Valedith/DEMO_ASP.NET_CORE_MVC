﻿// <auto-generated />
using System;
using DEMO_ASP.NET_CORE_MVC.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DEMO_ASP.NET_CORE_MVC.Migrations
{
    [DbContext(typeof(RestaurantContext))]
    [Migration("20181019100147_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DEMO_ASP.NET_CORE_MVC.Models.Recipe", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Quantity");

                    b.Property<string>("RecipeName");

                    b.Property<DateTime>("RegisterDate");

                    b.Property<bool>("isAvailable");

                    b.HasKey("ID");

                    b.ToTable("Recipe");
                });
#pragma warning restore 612, 618
        }
    }
}
