﻿// <auto-generated />
using System;
using AjaxCrud.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AjaxCrud.Migrations
{
    [DbContext(typeof(TransactionDbContext))]
    partial class TransactionDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("AjaxCrud.Models.TransactionModel", b =>
                {
                    b.Property<int>("TransactionID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("AccountNumber")
                        .HasColumnType("Nvarchar(12)");

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<string>("BankName")
                        .HasColumnType("Nvarchar(100)");

                    b.Property<string>("BeneficiaryName")
                        .HasColumnType("Nvarchar(100)");

                    b.Property<DateTime>("EntryDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("SWIFTCode")
                        .HasColumnType("Nvarchar(11)");

                    b.HasKey("TransactionID");

                    b.ToTable("transactions");
                });
#pragma warning restore 612, 618
        }
    }
}
