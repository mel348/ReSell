﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ReSell.Models;

namespace ReSell.Migrations
{
    [DbContext(typeof(ReSellContext))]
    partial class ReSellContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.28")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ReSell.Models.GarageSales", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Date")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(500)")
                        .HasMaxLength(500);

                    b.Property<string>("PostingTitle")
                        .HasColumnType("nvarchar(5)")
                        .HasMaxLength(5);

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(2)")
                        .HasMaxLength(2);

                    b.Property<int>("Time")
                        .HasColumnType("int");

                    b.Property<int>("Zipcode")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("GarageSales");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Address = "555 Bounty Blvd.",
                            City = "Traverse City",
                            Date = 0,
                            Description = "We have womens, mens, and childrens clothes.  Used Furniture, pet crate, lawn equipment, dvds, kitchenware, lamps, wall decor, and more knick knacks.",
                            Time = -100,
                            Zipcode = 49684
                        });
                });

            modelBuilder.Entity("ReSell.Models.Sellers", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GarageSalesID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(2)")
                        .HasMaxLength(2);

                    b.Property<int>("TradeID")
                        .HasColumnType("int");

                    b.Property<string>("Zip")
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.HasKey("ID");

                    b.HasIndex("GarageSalesID");

                    b.HasIndex("TradeID");

                    b.ToTable("Sellers");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            GarageSalesID = 0,
                            TradeID = 0
                        });
                });

            modelBuilder.Entity("ReSell.Models.Trade", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(500)")
                        .HasMaxLength(500);

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(2)")
                        .HasMaxLength(2);

                    b.Property<string>("TradeItem")
                        .IsRequired()
                        .HasColumnType("nvarchar(5)")
                        .HasMaxLength(5);

                    b.Property<int>("Zipcode")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Trades");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            City = "Traverse City",
                            Description = "I would like to trade my 2018 Kubota ZD1211 Lawn Mower, which I paid $18,900 for in 2018, only used at home, and is worth around $13,500 used.  I sold my home and no longer need this.I am in need of a pickup truck or suv for the winter season.",
                            State = "MI",
                            TradeItem = "Lawn Mower",
                            Zipcode = 49686
                        });
                });

            modelBuilder.Entity("ReSell.Models.Sellers", b =>
                {
                    b.HasOne("ReSell.Models.GarageSales", "GarageSales")
                        .WithMany()
                        .HasForeignKey("GarageSalesID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ReSell.Models.Trade", "Trade")
                        .WithMany()
                        .HasForeignKey("TradeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
