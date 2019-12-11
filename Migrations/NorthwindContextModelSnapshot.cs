﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Northwind.Models;

namespace Northwind.Migrations
{
    [DbContext(typeof(NorthwindContext))]
    partial class NorthwindContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Northwind.Models.CartItem", b =>
                {
                    b.Property<int>("CartItemId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CartItemName");

                    b.Property<int>("CustomerId");

                    b.Property<int?>("DiscountID");

                    b.Property<int>("ProductId");

                    b.Property<int>("Quantity");

                    b.Property<decimal>("UnitPrice");

                    b.HasKey("CartItemId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("DiscountID");

                    b.HasIndex("ProductId");

                    b.ToTable("CartItems");
                });

            modelBuilder.Entity("Northwind.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryName");

                    b.Property<string>("Description");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("Northwind.Models.Contact", b =>
                {
                    b.Property<int>("ContactId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("ContactId");

                    b.ToTable("Contacts");
                });

            modelBuilder.Entity("Northwind.Models.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address");

                    b.Property<string>("City");

                    b.Property<string>("CompanyName")
                        .IsRequired();

                    b.Property<string>("Country");

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("Fax");

                    b.Property<string>("Phone");

                    b.Property<string>("PostalCode");

                    b.Property<string>("Region");

                    b.HasKey("CustomerId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("Northwind.Models.Discount", b =>
                {
                    b.Property<int>("DiscountID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Code");

                    b.Property<string>("Description");

                    b.Property<decimal>("DiscountPercent");

                    b.Property<DateTime>("EndTime");

                    b.Property<int>("ProductID");

                    b.Property<DateTime>("StartTime");

                    b.Property<string>("Title");

                    b.HasKey("DiscountID");

                    b.HasIndex("ProductID");

                    b.ToTable("Discounts");
                });

            modelBuilder.Entity("Northwind.Models.Employee", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address");

                    b.Property<DateTime?>("BirthDate");

                    b.Property<string>("City");

                    b.Property<string>("Country");

                    b.Property<string>("EmailAddress");

                    b.Property<string>("Extension");

                    b.Property<string>("FirstName");

                    b.Property<DateTime?>("HireDate");

                    b.Property<string>("HomePhone");

                    b.Property<string>("JobTitle");

                    b.Property<string>("LastName");

                    b.Property<string>("Notes");

                    b.Property<string>("PostalCode");

                    b.Property<string>("Region");

                    b.Property<int?>("ReportsTo");

                    b.Property<int?>("ReportsToEmployeeEmployeeId");

                    b.Property<DateTime?>("TerminationDate");

                    b.Property<string>("TitleOfCourtesy");

                    b.HasKey("EmployeeId");

                    b.HasIndex("ReportsToEmployeeEmployeeId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("Northwind.Models.EmployeeTerritory", b =>
                {
                    b.Property<int>("EmployeeId");

                    b.Property<int>("TerritoryId");

                    b.Property<int?>("EmployeeId1");

                    b.HasKey("EmployeeId", "TerritoryId");

                    b.HasIndex("EmployeeId1");

                    b.HasIndex("TerritoryId");

                    b.ToTable("EmployeeTerritories");
                });

            modelBuilder.Entity("Northwind.Models.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CustomerId");

                    b.Property<int>("EmployeeId");

                    b.Property<double>("Freight");

                    b.Property<DateTime?>("OrderDate");

                    b.Property<DateTime?>("RequiredDate");

                    b.Property<string>("ShipAddress");

                    b.Property<string>("ShipCity");

                    b.Property<string>("ShipCountry");

                    b.Property<string>("ShipName");

                    b.Property<string>("ShipPostalCode");

                    b.Property<string>("ShipStateOrRegion");

                    b.Property<int>("ShipVia");

                    b.Property<DateTime?>("ShippedDate");

                    b.Property<int?>("ShipperId");

                    b.HasKey("OrderId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("ShipperId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Northwind.Models.OrderDetail", b =>
                {
                    b.Property<int>("OrderId");

                    b.Property<int>("ProductId");

                    b.Property<decimal>("Discount");

                    b.Property<int>("Quantity");

                    b.Property<double>("UnitPrice");

                    b.HasKey("OrderId", "ProductId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("Northwind.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId");

                    b.Property<bool>("Discontinued");

                    b.Property<string>("ProductName");

                    b.Property<string>("QuantityPerUnit");

                    b.Property<short>("ReorderLevel");

                    b.Property<int?>("SupplierId");

                    b.Property<decimal>("UnitPrice");

                    b.Property<short>("UnitsInStock");

                    b.Property<short>("UnitsOnOrder");

                    b.HasKey("ProductId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("SupplierId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Northwind.Models.Region", b =>
                {
                    b.Property<int>("RegionId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("RegionDescription");

                    b.HasKey("RegionId");

                    b.ToTable("Regions");
                });

            modelBuilder.Entity("Northwind.Models.Shipper", b =>
                {
                    b.Property<int>("ShipperId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CompanyName");

                    b.Property<string>("Phone");

                    b.HasKey("ShipperId");

                    b.ToTable("Shippers");
                });

            modelBuilder.Entity("Northwind.Models.Supplier", b =>
                {
                    b.Property<int>("SupplierId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address");

                    b.Property<string>("City");

                    b.Property<string>("CompanyName");

                    b.Property<string>("ContactName");

                    b.Property<string>("ContactTitle");

                    b.Property<string>("Country");

                    b.Property<string>("Fax");

                    b.Property<string>("Phone");

                    b.Property<string>("PostalCode");

                    b.Property<string>("Region");

                    b.HasKey("SupplierId");

                    b.ToTable("Suppliers");
                });

            modelBuilder.Entity("Northwind.Models.Territory", b =>
                {
                    b.Property<int>("TerritoryId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("RegionId");

                    b.Property<string>("TerritoryDescription");

                    b.HasKey("TerritoryId");

                    b.HasIndex("RegionId");

                    b.ToTable("Territories");
                });

            modelBuilder.Entity("Northwind.Models.CartItem", b =>
                {
                    b.HasOne("Northwind.Models.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Northwind.Models.Discount", "Discount")
                        .WithMany()
                        .HasForeignKey("DiscountID");

                    b.HasOne("Northwind.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Northwind.Models.Discount", b =>
                {
                    b.HasOne("Northwind.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Northwind.Models.Employee", b =>
                {
                    b.HasOne("Northwind.Models.Employee", "ReportsToEmployee")
                        .WithMany("Employees")
                        .HasForeignKey("ReportsToEmployeeEmployeeId");
                });

            modelBuilder.Entity("Northwind.Models.EmployeeTerritory", b =>
                {
                    b.HasOne("Northwind.Models.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("EmployeeId1");

                    b.HasOne("Northwind.Models.Territory", "Territory")
                        .WithMany()
                        .HasForeignKey("TerritoryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Northwind.Models.Order", b =>
                {
                    b.HasOne("Northwind.Models.Customer", "Customer")
                        .WithMany("Orders")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Northwind.Models.Employee", "Employee")
                        .WithMany("Orders")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Northwind.Models.Shipper", "Shipper")
                        .WithMany("Orders")
                        .HasForeignKey("ShipperId");
                });

            modelBuilder.Entity("Northwind.Models.OrderDetail", b =>
                {
                    b.HasOne("Northwind.Models.Order", "Order")
                        .WithMany("OrderDetails")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Northwind.Models.Product", "Product")
                        .WithMany("OrderDetails")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Northwind.Models.Product", b =>
                {
                    b.HasOne("Northwind.Models.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Northwind.Models.Supplier", "Supplier")
                        .WithMany("Products")
                        .HasForeignKey("SupplierId");
                });

            modelBuilder.Entity("Northwind.Models.Territory", b =>
                {
                    b.HasOne("Northwind.Models.Region", "Region")
                        .WithMany("Territories")
                        .HasForeignKey("RegionId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
