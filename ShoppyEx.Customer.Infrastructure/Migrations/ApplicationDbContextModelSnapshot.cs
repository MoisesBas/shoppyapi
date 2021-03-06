// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ShoppyEx.Customer.Infrastructure.Persistence;

#nullable disable

namespace ShoppyEx.Customer.Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ShoppyEx.Customer.Core.Domain.Address.CustomerAddress", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Address1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("CustomerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("PostalCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Region")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("tblCustomerAddresses", "dbo");
                });

            modelBuilder.Entity("ShoppyEx.Customer.Core.Domain.Card.Card", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("CardExpMo")
                        .HasColumnType("int");

                    b.Property<int>("CardExpYr")
                        .HasColumnType("int");

                    b.Property<string>("CreditCard")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CreditCardTypeID")
                        .HasColumnType("int");

                    b.Property<Guid>("CustomerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsPrimary")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("tblCard", "dbo");
                });

            modelBuilder.Entity("ShoppyEx.Customer.Core.Domain.Customer.Customer", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("tblCustomer", "dbo");
                });

            modelBuilder.Entity("ShoppyEx.SharedKernel.SeedWork.Events.StoredEvent", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AggregateId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("MessageType")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Payload")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ProcessedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("tblStoredEvent", "dbo");
                });

            modelBuilder.Entity("ShoppyEx.Customer.Core.Domain.Address.CustomerAddress", b =>
                {
                    b.HasOne("ShoppyEx.Customer.Core.Domain.Customer.Customer", "Customer")
                        .WithMany("CustomerAddress")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired()
                        .HasConstraintName("FK_CustomerAddress_Customer_CustomerId");

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("ShoppyEx.Customer.Core.Domain.Card.Card", b =>
                {
                    b.HasOne("ShoppyEx.Customer.Core.Domain.Customer.Customer", "Customer")
                        .WithMany("Cards")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired()
                        .HasConstraintName("FK_Cards_Customer_CustomerId");

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("ShoppyEx.Customer.Core.Domain.Customer.Customer", b =>
                {
                    b.Navigation("Cards");

                    b.Navigation("CustomerAddress");
                });
#pragma warning restore 612, 618
        }
    }
}
