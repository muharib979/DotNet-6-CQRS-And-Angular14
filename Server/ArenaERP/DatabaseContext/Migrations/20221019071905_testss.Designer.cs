﻿// <auto-generated />
using System;
using DatabaseContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DatabaseContext.Migrations
{
    [DbContext(typeof(DatabaseContextDb))]
    [Migration("20221019071905_testss")]
    partial class testss
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ModelClass.ERP.DTO.AccChart", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("AccType")
                        .HasColumnType("int");

                    b.Property<int?>("AccountGroupId")
                        .HasColumnType("int");

                    b.Property<int>("AccountId")
                        .HasColumnType("int");

                    b.Property<string>("AccountName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AccountNamed")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AccountNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AliasName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BIN")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("BalanceType")
                        .HasColumnType("int");

                    b.Property<int>("BranchId")
                        .HasColumnType("int");

                    b.Property<int?>("CommissionTypeId")
                        .HasColumnType("int");

                    b.Property<int>("CompId")
                        .HasColumnType("int");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("CreditDays")
                        .HasColumnType("int");

                    b.Property<decimal?>("CreditLimit")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("CurrencyId")
                        .HasColumnType("int");

                    b.Property<decimal?>("CurrencyRate")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("DepriciationRate")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("DetailsId")
                        .HasColumnType("int");

                    b.Property<int?>("DiscountTypeId")
                        .HasColumnType("int");

                    b.Property<decimal?>("FCAcc")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("FCAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("GroupAccountId")
                        .HasColumnType("int");

                    b.Property<int?>("HeadGroupId")
                        .HasColumnType("int");

                    b.Property<string>("HeadGroupName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("IsActive")
                        .HasColumnType("int");

                    b.Property<int?>("IsBillbyBill")
                        .HasColumnType("int");

                    b.Property<int?>("IsBothBill")
                        .HasColumnType("int");

                    b.Property<int?>("IsCostCenter")
                        .HasColumnType("int");

                    b.Property<int?>("IsEmployee")
                        .HasColumnType("int");

                    b.Property<int?>("IsIndependSubledger")
                        .HasColumnType("int");

                    b.Property<int?>("IsInventory")
                        .HasColumnType("int");

                    b.Property<int?>("IsSalesAccount")
                        .HasColumnType("int");

                    b.Property<int?>("IsSubledger")
                        .HasColumnType("int");

                    b.Property<int?>("LowerGroupId")
                        .HasColumnType("int");

                    b.Property<int?>("NoteToHeadId")
                        .HasColumnType("int");

                    b.Property<decimal?>("OpenningBalance")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("PrintPorder")
                        .HasColumnType("int");

                    b.Property<int?>("Status")
                        .HasColumnType("int");

                    b.Property<int?>("SubLeadeger")
                        .HasColumnType("int");

                    b.Property<string>("TIN")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UpdatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("isFixed")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("AccChart");
                });

            modelBuilder.Entity("ModelClass.ERP.DTO.Branch", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("BranchId")
                        .HasColumnType("int");

                    b.Property<int>("CompId")
                        .HasColumnType("int");

                    b.Property<string>("ContactNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CriteriaId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShortName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Status")
                        .HasColumnType("int");

                    b.Property<int?>("Type")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Branch");
                });

            modelBuilder.Entity("ModelClass.ERP.DTO.Brand", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("BrandName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CompId")
                        .HasColumnType("int");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("IsActive")
                        .HasColumnType("int");

                    b.Property<int>("ModuleId")
                        .HasColumnType("int");

                    b.Property<int?>("SortOrder")
                        .HasColumnType("int");

                    b.Property<int?>("Status")
                        .HasColumnType("int");

                    b.Property<string>("UpdatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Brand");
                });

            modelBuilder.Entity("ModelClass.ERP.DTO.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CompId")
                        .HasColumnType("int");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("IsParent")
                        .HasColumnType("int");

                    b.Property<int?>("IsProduction")
                        .HasColumnType("int");

                    b.Property<int?>("ParentId")
                        .HasColumnType("int");

                    b.Property<int?>("ProductType")
                        .HasColumnType("int");

                    b.Property<int?>("ProductionLevel")
                        .HasColumnType("int");

                    b.Property<int?>("Status")
                        .HasColumnType("int");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("ModelClass.ERP.DTO.ChallanDetails", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<decimal?>("BoxConv")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("BranchId")
                        .HasColumnType("int");

                    b.Property<string>("ChallanDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ChallanId")
                        .HasColumnType("int");

                    b.Property<int?>("ChallanNatureId")
                        .HasColumnType("int");

                    b.Property<int?>("ChallanNo")
                        .HasColumnType("int");

                    b.Property<string>("ChallanType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CompId")
                        .HasColumnType("int");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DestinationGownId")
                        .HasColumnType("int");

                    b.Property<decimal?>("Factor")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("GodownId")
                        .HasColumnType("int");

                    b.Property<int?>("OrderId")
                        .HasColumnType("int");

                    b.Property<string>("PDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PartyId")
                        .HasColumnType("int");

                    b.Property<decimal?>("PcsQty")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("ProductId")
                        .HasColumnType("int");

                    b.Property<string>("ProductionDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("QuoteId")
                        .HasColumnType("int");

                    b.Property<int?>("RefAutoId")
                        .HasColumnType("int");

                    b.Property<string>("Remarks")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Status")
                        .HasColumnType("int");

                    b.Property<int?>("TransId")
                        .HasColumnType("int");

                    b.Property<decimal?>("UniquePrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("UniqueQty")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("UnitId")
                        .HasColumnType("int");

                    b.Property<decimal?>("UnitPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("UnitQty")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("ChallanDetail");
                });

            modelBuilder.Entity("ModelClass.ERP.DTO.ChallanMaster", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("BillTo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("BranchId")
                        .HasColumnType("int");

                    b.Property<int>("ChallanId")
                        .HasColumnType("int");

                    b.Property<int>("ChallanNo")
                        .HasColumnType("int");

                    b.Property<string>("ChallanType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CompId")
                        .HasColumnType("int");

                    b.Property<string>("ContactNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeliveryLocation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DriverContactNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DriverName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("NatureId")
                        .HasColumnType("int");

                    b.Property<string>("Note")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PartyId")
                        .HasColumnType("int");

                    b.Property<int?>("RefId")
                        .HasColumnType("int");

                    b.Property<string>("RefNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SalesPersonId")
                        .HasColumnType("int");

                    b.Property<int?>("Status")
                        .HasColumnType("int");

                    b.Property<string>("TransPortName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TransportId")
                        .HasColumnType("int");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("ChallanMaster");
                });

            modelBuilder.Entity("ModelClass.ERP.DTO.Color", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ColorName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CompId")
                        .HasColumnType("int");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("IsActive")
                        .HasColumnType("int");

                    b.Property<int?>("ModuleId")
                        .HasColumnType("int");

                    b.Property<int?>("SortOrder")
                        .HasColumnType("int");

                    b.Property<int?>("Status")
                        .HasColumnType("int");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Colors");
                });

            modelBuilder.Entity("ModelClass.ERP.DTO.ExceptionLogs", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ApplicationName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("ExceptionDetails")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ExceptionType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Message")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RequestUrl")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ExceptionLogs");
                });

            modelBuilder.Entity("ModelClass.ERP.DTO.Godown", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("BranchId")
                        .HasColumnType("int");

                    b.Property<int>("CompId")
                        .HasColumnType("int");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("GodownId")
                        .HasColumnType("int");

                    b.Property<string>("GodownLocation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GodownName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("IsParent")
                        .HasColumnType("int");

                    b.Property<int?>("LayerId")
                        .HasColumnType("int");

                    b.Property<int?>("ParentId")
                        .HasColumnType("int");

                    b.Property<int?>("Status")
                        .HasColumnType("int");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Godown");
                });

            modelBuilder.Entity("ModelClass.ERP.DTO.Modules", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("IsActive")
                        .HasColumnType("int");

                    b.Property<int?>("IsParent")
                        .HasColumnType("int");

                    b.Property<string>("ModuleRoutePath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ParentModuleId")
                        .HasColumnType("int");

                    b.Property<int?>("SerialNo")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Modules");
                });

            modelBuilder.Entity("ModelClass.ERP.DTO.Pages", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("ModuleId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PageRoutePath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SerialNo")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Pages");
                });

            modelBuilder.Entity("ModelClass.ERP.DTO.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("BillType")
                        .HasColumnType("int");

                    b.Property<int?>("BillUnitId")
                        .HasColumnType("int");

                    b.Property<decimal?>("BoxConv")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("BrandId")
                        .HasColumnType("int");

                    b.Property<int?>("CategoryId")
                        .HasColumnType("int");

                    b.Property<int?>("ColorId")
                        .HasColumnType("int");

                    b.Property<int>("CompId")
                        .HasColumnType("int");

                    b.Property<decimal?>("CostPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("Factor")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("Factor2")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ModuelId")
                        .HasColumnType("int");

                    b.Property<int?>("ModuleId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("OriginId")
                        .HasColumnType("int");

                    b.Property<int?>("PParentId")
                        .HasColumnType("int");

                    b.Property<string>("ProductBarCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int?>("ProductType")
                        .HasColumnType("int");

                    b.Property<decimal?>("SalePrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("ShortCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SizeofProduct")
                        .HasColumnType("int");

                    b.Property<int?>("SortOrder")
                        .HasColumnType("int");

                    b.Property<int?>("Status")
                        .HasColumnType("int");

                    b.Property<int>("UnitId")
                        .HasColumnType("int");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal?>("Vatrate")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("ModelClass.ERP.DTO.ProductCategories", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<int>("CompId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int?>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("ProductCategory");
                });

            modelBuilder.Entity("ModelClass.ERP.DTO.ProductColor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("ColorId")
                        .HasColumnType("int");

                    b.Property<int>("CompId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int?>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("ProductColor");
                });

            modelBuilder.Entity("ModelClass.ERP.DTO.ProductSupplier", b =>
                {
                    b.Property<int>("ProductSuplierId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductSuplierId"), 1L, 1);

                    b.Property<int>("BranchId")
                        .HasColumnType("int");

                    b.Property<int>("CompId")
                        .HasColumnType("int");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int?>("Status")
                        .HasColumnType("int");

                    b.Property<int>("SupplierId")
                        .HasColumnType("int");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("ProductSuplierId");

                    b.HasIndex("ProductId");

                    b.HasIndex("SupplierId");

                    b.ToTable("ProductSupplier");
                });

            modelBuilder.Entity("ModelClass.ERP.DTO.ProductType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("CompId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ProductType");
                });

            modelBuilder.Entity("ModelClass.ERP.DTO.ProductUnit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CompId")
                        .HasColumnType("int");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Factor")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("IsDefaultBillUnit")
                        .HasColumnType("int");

                    b.Property<int?>("IsDefaultChallanUnit")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int?>("Status")
                        .HasColumnType("int");

                    b.Property<int>("UnitId")
                        .HasColumnType("int");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("ProductUnitConv");
                });

            modelBuilder.Entity("ModelClass.ERP.DTO.Unit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CompId")
                        .HasColumnType("int");

                    b.Property<int?>("IsBox")
                        .HasColumnType("int");

                    b.Property<int?>("Status")
                        .HasColumnType("int");

                    b.Property<string>("UnitDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("UnitFactor")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("UnitId")
                        .HasColumnType("int");

                    b.Property<string>("UnitName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Unit");
                });

            modelBuilder.Entity("ModelClass.ERP.DTO.ProductSupplier", b =>
                {
                    b.HasOne("ModelClass.ERP.DTO.Product", "Product")
                        .WithMany("ProductSupplier")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ModelClass.ERP.DTO.AccChart", "AccChart")
                        .WithMany("ProductSupplier")
                        .HasForeignKey("SupplierId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AccChart");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("ModelClass.ERP.DTO.AccChart", b =>
                {
                    b.Navigation("ProductSupplier");
                });

            modelBuilder.Entity("ModelClass.ERP.DTO.Product", b =>
                {
                    b.Navigation("ProductSupplier");
                });
#pragma warning restore 612, 618
        }
    }
}
