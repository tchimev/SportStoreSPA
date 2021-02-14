﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using SportsStore.Models;

namespace SportsStore.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SportsStore.Models.CartLine", b =>
                {
                    b.Property<long>("CartLineId")
                        .ValueGeneratedOnAdd();

                    b.Property<long?>("OrderId");

                    b.Property<long>("ProductId");

                    b.Property<int>("Quantity");

                    b.HasKey("CartLineId");

                    b.HasIndex("OrderId");

                    b.ToTable("CartLine");
                });

            modelBuilder.Entity("SportsStore.Models.Order", b =>
                {
                    b.Property<long>("OrderId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<long>("PaymentId");

                    b.Property<bool>("Shipped");

                    b.HasKey("OrderId");

                    b.HasIndex("PaymentId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("SportsStore.Models.Payment", b =>
                {
                    b.Property<long>("PaymentId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AuthCode");

                    b.Property<string>("CardExpiry")
                        .IsRequired();

                    b.Property<string>("CardNumber")
                        .IsRequired();

                    b.Property<int>("CardSecurityCode");

                    b.Property<decimal>("Total");

                    b.HasKey("PaymentId");

                    b.ToTable("Payment");
                });

            modelBuilder.Entity("SportsStore.Models.Product", b =>
                {
                    b.Property<long>("ProductId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Category");

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.Property<decimal>("Price");

                    b.Property<long?>("SupplierId");

                    b.HasKey("ProductId");

                    b.HasIndex("SupplierId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("SportsStore.Models.Rating", b =>
                {
                    b.Property<long>("RatingId")
                        .ValueGeneratedOnAdd();

                    b.Property<long?>("ProductId");

                    b.Property<int>("Stars");

                    b.HasKey("RatingId");

                    b.HasIndex("ProductId");

                    b.ToTable("Ratings");
                });

            modelBuilder.Entity("SportsStore.Models.Supplier", b =>
                {
                    b.Property<long>("SupplierId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("City");

                    b.Property<string>("Name");

                    b.Property<string>("State");

                    b.HasKey("SupplierId");

                    b.ToTable("Suppliers");
                });

            modelBuilder.Entity("SportsStore.Models.CartLine", b =>
                {
                    b.HasOne("SportsStore.Models.Order")
                        .WithMany("Products")
                        .HasForeignKey("OrderId");
                });

            modelBuilder.Entity("SportsStore.Models.Order", b =>
                {
                    b.HasOne("SportsStore.Models.Payment", "Payment")
                        .WithMany()
                        .HasForeignKey("PaymentId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SportsStore.Models.Product", b =>
                {
                    b.HasOne("SportsStore.Models.Supplier", "Supplier")
                        .WithMany("Products")
                        .HasForeignKey("SupplierId")
                        .OnDelete(DeleteBehavior.SetNull);
                });

            modelBuilder.Entity("SportsStore.Models.Rating", b =>
                {
                    b.HasOne("SportsStore.Models.Product", "Product")
                        .WithMany("Ratings")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
